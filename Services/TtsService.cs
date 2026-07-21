using System;
using System.Collections.Generic;
using System.IO;
using System.Speech.Synthesis;
using System.Threading.Tasks;
using TTS_Windows_App.Models;

namespace TTS_Windows_App.Services
{
    /// <summary>
    /// Lớp dịch vụ chuyển đổi văn bản thành giọng nói (Text-To-Speech)
    /// </summary>
    public class TtsService : IDisposable
    {
        private readonly SpeechSynthesizer _synthesizer;

        public bool IsSpeaking { get; private set; }
        public bool IsPaused { get; private set; }

        public event EventHandler<SpeakCompletedEventArgs> SpeakCompleted;
        public event EventHandler<SpeakProgressEventArgs> SpeakProgress;

        public TtsService()
        {
            _synthesizer = new SpeechSynthesizer();
            _synthesizer.SpeakCompleted += (s, e) =>
            {
                IsSpeaking = false;
                IsPaused = false;
                SpeakCompleted?.Invoke(this, e);
            };

            _synthesizer.SpeakProgress += (s, e) =>
            {
                SpeakProgress?.Invoke(this, e);
            };
        }

        /// <summary>
        /// Lấy danh sách tất cả các giọng đọc đã được cài đặt trên hệ thống Windows
        /// </summary>
        public List<VoiceItem> GetInstalledVoices()
        {
            var list = new List<VoiceItem>();
            try
            {
                foreach (InstalledVoice voice in _synthesizer.GetInstalledVoices())
                {
                    VoiceInfo info = voice.VoiceInfo;
                    list.Add(new VoiceItem
                    {
                        Id = info.Name,
                        Name = info.Name,
                        Culture = info.Culture.DisplayName,
                        Gender = info.Gender.ToString()
                    });
                }
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException($"Lỗi khi lấy danh sách giọng đọc: {ex.Message}", ex);
            }
            return list;
        }

        /// <summary>
        /// Phát âm thanh từ văn bản
        /// </summary>
        public void Speak(string text, string voiceName, int rate = 0, int volume = 100)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                throw new ArgumentException("Văn bản đọc không được để trống.");
            }

            try
            {
                _synthesizer.SpeakAsyncCancelAll();

                if (!string.IsNullOrEmpty(voiceName))
                {
                    _synthesizer.SelectVoice(voiceName);
                }

                _synthesizer.Rate = Math.Max(-10, Math.Min(10, rate));
                _synthesizer.Volume = Math.Max(0, Math.Min(100, volume));

                IsSpeaking = true;
                IsPaused = false;
                _synthesizer.SpeakAsync(text);
            }
            catch (Exception ex)
            {
                IsSpeaking = false;
                IsPaused = false;
                throw new Exception($"Không thể tổng hợp giọng nói: {ex.Message}", ex);
            }
        }

        /// <summary>
        /// Tạm dừng phát âm thanh
        /// </summary>
        public void Pause()
        {
            if (IsSpeaking && !IsPaused)
            {
                _synthesizer.Pause();
                IsPaused = true;
            }
        }

        /// <summary>
        /// Tiếp tục phát âm thanh sau khi tạm dừng
        /// </summary>
        public void Resume()
        {
            if (IsSpeaking && IsPaused)
            {
                _synthesizer.Resume();
                IsPaused = false;
            }
        }

        /// <summary>
        /// Dừng hẳn quá trình đọc
        /// </summary>
        public void Stop()
        {
            if (IsSpeaking)
            {
                _synthesizer.SpeakAsyncCancelAll();
                IsSpeaking = false;
                IsPaused = false;
            }
        }

        /// <summary>
        /// Xuất giọng nói ra file âm thanh .WAV
        /// </summary>
        public Task ExportToWavAsync(string text, string voiceName, string outputFilePath, int rate = 0, int volume = 100)
        {
            return Task.Run(() =>
            {
                using (var synth = new SpeechSynthesizer())
                {
                    if (!string.IsNullOrEmpty(voiceName))
                    {
                        synth.SelectVoice(voiceName);
                    }

                    synth.Rate = Math.Max(-10, Math.Min(10, rate));
                    synth.Volume = Math.Max(0, Math.Min(100, volume));

                    synth.SetOutputToWaveFile(outputFilePath);
                    synth.Speak(text);
                    synth.SetOutputToNull();
                }
            });
        }

        public void Dispose()
        {
            _synthesizer?.Dispose();
        }
    }
}
