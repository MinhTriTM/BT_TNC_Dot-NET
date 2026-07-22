using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using BT_TNC_Dot_NET.Models;

namespace BT_TNC_Dot_NET.Services
{
    public class VieNeuVoiceItem
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Culture { get; set; } = "vi-VN";
        public string Gender { get; set; } = "Female"; // Male, Female
        public string Age { get; set; } = "Adult";     // Child, Young, Adult, Senior
        public string Persona { get; set; } = "Warm";   // Excited, Warm, Serious, Mysterious
        public string Region { get; set; } = "Bắc";    // Bắc, Trung, Nam

        public override string ToString()
        {
            return Name;
        }
    }

    public class VieNeuTtsService : IDisposable
    {
        private readonly string _vieNeuDir;
        private SoundPlayer _soundPlayer;
        private Process _runningProcess;
        private bool _isSpeaking;

        public bool IsSpeaking => _isSpeaking;

        public VieNeuTtsService(string vieNeuDir)
        {
            _vieNeuDir = vieNeuDir;
        }

        public List<VieNeuVoiceItem> GetPresetVoices()
        {
            var defaultVoices = new List<VieNeuVoiceItem>
            {
                new VieNeuVoiceItem { Id = "Trúc Ly", Name = "Trúc Ly (Nữ · Bắc · Tự nhiên)", Gender = "Female", Age = "Young", Persona = "Warm", Region = "Bắc" },
                new VieNeuVoiceItem { Id = "Phạm Tuyên", Name = "Phạm Tuyên (Nam · Bắc · Tự nhiên)", Gender = "Male", Age = "Adult", Persona = "Serious", Region = "Bắc" },
                new VieNeuVoiceItem { Id = "Minh Đức", Name = "Minh Đức (Nam · Bắc · Tin tức)", Gender = "Male", Age = "Adult", Persona = "Serious", Region = "Bắc" },
                new VieNeuVoiceItem { Id = "Thái Sơn", Name = "Thái Sơn (Nam · Nam · Kể chuyện)", Gender = "Male", Age = "Adult", Persona = "Mysterious", Region = "Nam" },
                new VieNeuVoiceItem { Id = "Xuân Vĩnh", Name = "Xuân Vĩnh (Nam · Nam · Tự nhiên)", Gender = "Male", Age = "Young", Persona = "Excited", Region = "Nam" },
                new VieNeuVoiceItem { Id = "Thanh Bình", Name = "Thanh Bình (Nam · Bắc · Kể chuyện)", Gender = "Male", Age = "Senior", Persona = "Warm", Region = "Bắc" },
                new VieNeuVoiceItem { Id = "Ngọc Linh", Name = "Ngọc Linh (Nữ · Bắc · Kể chuyện)", Gender = "Female", Age = "Child", Persona = "Excited", Region = "Bắc" },
                new VieNeuVoiceItem { Id = "Đoan Trang", Name = "Đoan Trang (Nữ · Bắc · Tự nhiên)", Gender = "Female", Age = "Young", Persona = "Warm", Region = "Bắc" },
                new VieNeuVoiceItem { Id = "Mai Anh", Name = "Mai Anh (Nữ · Bắc · Tin tức)", Gender = "Female", Age = "Adult", Persona = "Serious", Region = "Bắc" },
                new VieNeuVoiceItem { Id = "Thục Đoan", Name = "Thục Đoan (Nữ · Nam · Kể chuyện)", Gender = "Female", Age = "Senior", Persona = "Warm", Region = "Nam" },
                new VieNeuVoiceItem { Id = "Minh Triết", Name = "Minh Triết (Nam · Nam · Tin tức)", Gender = "Male", Age = "Young", Persona = "Serious", Region = "Nam" },
                new VieNeuVoiceItem { Id = "Thùy Dung", Name = "Thùy Dung (Nữ · Nam · Tin tức)", Gender = "Female", Age = "Young", Persona = "Excited", Region = "Nam" },
                new VieNeuVoiceItem { Id = "Quang Sơn", Name = "Quang Sơn (Nam · Trung · Tự nhiên)", Gender = "Male", Age = "Adult", Persona = "Warm", Region = "Trung" },
                new VieNeuVoiceItem { Id = "Ngọc Trân", Name = "Ngọc Trân (Nữ · Trung · Tự nhiên)", Gender = "Female", Age = "Child", Persona = "Excited", Region = "Trung" }
            };

            return defaultVoices;
        }

        public async Task<string> GenerateAudioWavAsync(string text, string voice, string style, double pitch, string outputPath, string cloneAudioPath = "")
        {
            string scriptPath = Path.Combine(_vieNeuDir, "vieneu_bridge.py");
            if (!File.Exists(scriptPath))
            {
                throw new FileNotFoundException($"Không tìm thấy script bridge: {scriptPath}");
            }

            string venvPython = Path.Combine(_vieNeuDir, ".venv", "Scripts", "python.exe");
            bool useVenv = File.Exists(venvPython);

            string exePath = useVenv ? venvPython : "uv";
            string pitchStr = pitch.ToString("0.0", CultureInfo.InvariantCulture);
            string escapedText = text.Replace("\"", "\\\"").Replace("\r", " ").Replace("\n", " ");

            string cloneArg = !string.IsNullOrEmpty(cloneAudioPath) ? $"--clone-audio \"{cloneAudioPath}\"" : "";

            string arguments = useVenv
                ? $"\"{scriptPath}\" --text \"{escapedText}\" --voice \"{voice}\" --style \"{style}\" --pitch {pitchStr} {cloneArg} --output \"{outputPath}\""
                : $"run python \"{scriptPath}\" --text \"{escapedText}\" --voice \"{voice}\" --style \"{style}\" --pitch {pitchStr} {cloneArg} --output \"{outputPath}\"";

            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = exePath,
                Arguments = arguments,
                WorkingDirectory = _vieNeuDir,
                UseShellExecute = false,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                CreateNoWindow = true,
                StandardOutputEncoding = Encoding.UTF8
            };

            // Tự động bật chế độ Offline cho Hugging Face Hub nếu không có mạng để tránh crash khi check update
            if (!System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
            {
                psi.EnvironmentVariables["HF_HUB_OFFLINE"] = "1";
            }
            psi.EnvironmentVariables["HF_HUB_DISABLE_SYMLINKS_WARNING"] = "1";

            return await Task.Run(() =>
            {
                using (_runningProcess = Process.Start(psi))
                {
                    string error = _runningProcess.StandardError.ReadToEnd();
                    string output = _runningProcess.StandardOutput.ReadToEnd();
                    _runningProcess.WaitForExit();

                    if (_runningProcess.ExitCode != 0)
                    {
                        throw new Exception($"Lỗi VieNeu-TTS AI Engine: {error}\nOutput: {output}");
                    }

                    return outputPath;
                }
            });
        }

        public async Task SpeakAsync(string text, string voice, string style, double pitch, Action<string> statusCallback, string cloneAudioPath = "")
        {
            Stop();

            _isSpeaking = true;
            statusCallback?.Invoke("⏳ VieNeu-TTS AI đang suy luận giọng nói...");

            string tempFile = Path.Combine(Path.GetTempPath(), $"vieneu_{Guid.NewGuid():N}.wav");
            try
            {
                await GenerateAudioWavAsync(text, voice, style, pitch, tempFile, cloneAudioPath);

                statusCallback?.Invoke($"▶ Đang phát âm thanh VieNeu-TTS AI ({voice})...");

                _soundPlayer = new SoundPlayer(tempFile);
                await Task.Run(() =>
                {
                    _soundPlayer.PlaySync();
                });
            }
            finally
            {
                _isSpeaking = false;
                try
                {
                    if (File.Exists(tempFile)) File.Delete(tempFile);
                }
                catch { }
            }
        }

        public void Stop()
        {
            try
            {
                if (_soundPlayer != null)
                {
                    _soundPlayer.Stop();
                    _soundPlayer.Dispose();
                    _soundPlayer = null;
                }

                if (_runningProcess != null && !_runningProcess.HasExited)
                {
                    _runningProcess.Kill();
                    _runningProcess = null;
                }
            }
            catch { }
            finally
            {
                _isSpeaking = false;
            }
        }

        public void Dispose()
        {
            Stop();
        }
    }
}
