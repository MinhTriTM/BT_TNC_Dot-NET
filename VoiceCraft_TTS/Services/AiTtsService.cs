using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using NAudio.Wave;
using VoiceCraft_TTS.Models;

namespace VoiceCraft_TTS.Services
{
    public class AiTtsService : IDisposable
    {
        private readonly HttpClient _httpClient = new HttpClient { Timeout = TimeSpan.FromSeconds(30) };
        private readonly string _baseUrl = "http://127.0.0.1:8000";

        private WaveOutEvent? _waveOut;
        private Mp3FileReader? _mp3Reader;
        private MemoryStream? _audioStream;

        public event EventHandler? PlaybackStopped;

        public async Task<List<VoiceModel>> GetAiVoicesAsync()
        {
            var list = new List<VoiceModel>();
            try
            {
                var response = await _httpClient.GetAsync($"{_baseUrl}/voices");
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    using var doc = JsonDocument.Parse(json);
                    foreach (var element in doc.RootElement.EnumerateArray())
                    {
                        list.Add(new VoiceModel
                        {
                            Id = element.GetProperty("id").GetString() ?? "",
                            Name = element.GetProperty("name").GetString() ?? "",
                            Language = element.GetProperty("lang").GetString() ?? "",
                            Gender = element.GetProperty("gender").GetString() ?? "",
                            Source = "AI Neural Engine"
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Lỗi lấy danh sách giọng AI: {ex.Message}");
            }
            return list;
        }

        public async Task<byte[]> SynthesizeAudioAsync(string text, string voiceId, int rate = 0, int pitch = 0)
        {
            var payload = new
            {
                text = text,
                voice = voiceId,
                rate = rate,
                pitch = pitch
            };

            var jsonContent = new StringContent(JsonSerializer.Serialize(payload), Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync($"{_baseUrl}/synthesize", jsonContent);

            if (!response.IsSuccessStatusCode)
            {
                string errText = await response.Content.ReadAsStringAsync();
                throw new Exception($"AI Engine trả về lỗi: {response.StatusCode} - {errText}");
            }

            return await response.Content.ReadAsByteArrayAsync();
        }

        public async Task PlayAsync(string text, string voiceId, int rate = 0, int pitch = 0)
        {
            Stop();

            byte[] audioBytes = await SynthesizeAudioAsync(text, voiceId, rate, pitch);

            _audioStream = new MemoryStream(audioBytes);
            _mp3Reader = new Mp3FileReader(_audioStream);

            _waveOut = new WaveOutEvent();
            _waveOut.Init(_mp3Reader);
            _waveOut.PlaybackStopped += (s, e) => PlaybackStopped?.Invoke(this, EventArgs.Empty);
            _waveOut.Play();
        }

        public void Pause()
        {
            if (_waveOut != null && _waveOut.PlaybackState == PlaybackState.Playing)
            {
                _waveOut.Pause();
            }
        }

        public void Resume()
        {
            if (_waveOut != null && _waveOut.PlaybackState == PlaybackState.Paused)
            {
                _waveOut.Play();
            }
        }

        public void Stop()
        {
            if (_waveOut != null)
            {
                _waveOut.Stop();
                _waveOut.Dispose();
                _waveOut = null;
            }
            if (_mp3Reader != null)
            {
                _mp3Reader.Dispose();
                _mp3Reader = null;
            }
            if (_audioStream != null)
            {
                _audioStream.Dispose();
                _audioStream = null;
            }
        }

        public async Task ExportToFileAsync(string text, string voiceId, string filePath, int rate = 0, int pitch = 0)
        {
            byte[] audioBytes = await SynthesizeAudioAsync(text, voiceId, rate, pitch);
            await File.WriteAllBytesAsync(filePath, audioBytes);
        }

        public void Dispose()
        {
            Stop();
            _httpClient.Dispose();
        }
    }
}
