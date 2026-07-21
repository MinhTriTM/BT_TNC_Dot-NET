using System;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace VoiceCraft_TTS.Services
{
    public class PythonBackendManager
    {
        private Process? _pythonProcess;
        private readonly string _backendUrl = "http://127.0.0.1:8000/";
        private static readonly HttpClient _httpClient = new HttpClient { Timeout = TimeSpan.FromSeconds(2) };

        public bool IsRunning { get; private set; }

        public async Task StartBackendAsync()
        {
            // Kiểm tra xem backend đã chạy sẵn chưa
            if (await CheckBackendOnlineAsync())
            {
                IsRunning = true;
                return;
            }

            try
            {
                string baseDir = AppDomain.CurrentDomain.BaseDirectory;
                // Tìm đường dẫn tới AI_Backend/main.py
                string backendPath = Path.Combine(baseDir, "..", "..", "..", "..", "AI_Backend", "main.py");
                backendPath = Path.GetFullPath(backendPath);

                if (!File.Exists(backendPath))
                {
                    // Thử tìm trong thư mục hiện tại
                    backendPath = Path.GetFullPath(Path.Combine(baseDir, "AI_Backend", "main.py"));
                }

                if (File.Exists(backendPath))
                {
                    var startInfo = new ProcessStartInfo
                    {
                        FileName = "python",
                        Arguments = $"\"{backendPath}\"",
                        UseShellExecute = false,
                        CreateNoWindow = true,
                        RedirectStandardOutput = true,
                        RedirectStandardError = true,
                        WorkingDirectory = Path.GetDirectoryName(backendPath)
                    };

                    _pythonProcess = new Process { StartInfo = startInfo };
                    _pythonProcess.Start();

                    // Đợi backend khởi động
                    for (int i = 0; i < 10; i++)
                    {
                        await Task.Delay(1000);
                        if (await CheckBackendOnlineAsync())
                        {
                            IsRunning = true;
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Lỗi khởi động Python backend: {ex.Message}");
            }
        }

        public async Task<bool> CheckBackendOnlineAsync()
        {
            try
            {
                var response = await _httpClient.GetAsync(_backendUrl);
                return response.IsSuccessStatusCode;
            }
            catch
            {
                return false;
            }
        }

        public void StopBackend()
        {
            try
            {
                if (_pythonProcess != null && !_pythonProcess.HasExited)
                {
                    _pythonProcess.Kill(true);
                    _pythonProcess.Dispose();
                    _pythonProcess = null;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Lỗi khi tắt Python backend: {ex.Message}");
            }
        }
    }
}
