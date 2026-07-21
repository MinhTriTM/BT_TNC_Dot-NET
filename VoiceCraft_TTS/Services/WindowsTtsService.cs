using System;
using System.Collections.Generic;
using System.IO;
using System.Speech.Synthesis;
using System.Threading.Tasks;
using VoiceCraft_TTS.Models;

namespace VoiceCraft_TTS.Services
{
    public class WindowsTtsService : IDisposable
    {
        private readonly SpeechSynthesizer _synthesizer;

        public event EventHandler<SpeakCompletedEventArgs>? SpeakCompleted;

        public WindowsTtsService()
        {
            _synthesizer = new SpeechSynthesizer();
            _synthesizer.SpeakCompleted += (s, e) => SpeakCompleted?.Invoke(this, e);
        }

        public List<VoiceModel> GetInstalledVoices()
        {
            var list = new List<VoiceModel>();
            foreach (var voice in _synthesizer.GetInstalledVoices())
            {
                var info = voice.VoiceInfo;
                list.Add(new VoiceModel
                {
                    Id = info.Name,
                    Name = info.Name,
                    Language = info.Culture.DisplayName,
                    Gender = info.Gender.ToString(),
                    Source = "Windows Engine"
                });
            }
            return list;
        }

        public void Speak(string text, string voiceName, int rate = 0, int volume = 100)
        {
            _synthesizer.SpeakAsyncCancelAll();
            if (!string.IsNullOrEmpty(voiceName))
            {
                _synthesizer.SelectVoice(voiceName);
            }
            _synthesizer.Rate = Math.Clamp(rate, -10, 10);
            _synthesizer.Volume = Math.Clamp(volume, 0, 100);
            _synthesizer.SpeakAsync(text);
        }

        public void Pause()
        {
            if (_synthesizer.State == SynthesizerState.Speaking)
            {
                _synthesizer.Pause();
            }
        }

        public void Resume()
        {
            if (_synthesizer.State == SynthesizerState.Paused)
            {
                _synthesizer.Resume();
            }
        }

        public void Stop()
        {
            _synthesizer.SpeakAsyncCancelAll();
        }

        public async Task ExportToWavAsync(string text, string voiceName, string outputFilePath, int rate = 0, int volume = 100)
        {
            await Task.Run(() =>
            {
                using (var synth = new SpeechSynthesizer())
                {
                    if (!string.IsNullOrEmpty(voiceName))
                    {
                        synth.SelectVoice(voiceName);
                    }
                    synth.Rate = Math.Clamp(rate, -10, 10);
                    synth.Volume = Math.Clamp(volume, 0, 100);
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
