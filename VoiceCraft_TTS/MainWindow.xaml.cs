using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Animation;
using Microsoft.Win32;
using VoiceCraft_TTS.Models;
using VoiceCraft_TTS.Services;

namespace VoiceCraft_TTS
{
    public partial class MainWindow : Window
    {
        private readonly WindowsTtsService _windowsTtsService;
        private readonly AiTtsService _aiTtsService;
        private readonly PythonBackendManager _pythonManager;

        private List<VoiceModel> _windowsVoices = new();
        private List<VoiceModel> _aiVoices = new();
        private readonly ObservableCollection<HistoryItem> _historyItems = new();

        private bool _isSpeaking = false;
        private bool _isPaused = false;
        private System.Windows.Threading.DispatcherTimer? _visualizerTimer;
        private readonly Random _random = new();

        public MainWindow()
        {
            InitializeComponent();

            _windowsTtsService = new WindowsTtsService();
            _aiTtsService = new AiTtsService();
            _pythonManager = new PythonBackendManager();

            LstHistory.ItemsSource = _historyItems;

            _windowsTtsService.SpeakCompleted += WindowsTtsService_SpeakCompleted;
            _aiTtsService.PlaybackStopped += AiTtsService_PlaybackStopped;

            SetupVisualizerTimer();
            Loaded += MainWindow_Loaded;
            Closing += MainWindow_Closing;
        }

        private async void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            // 1. Tải danh sách giọng Windows Native
            _windowsVoices = _windowsTtsService.GetInstalledVoices();

            // 2. Khởi động Python AI Backend ngầm
            TxtStatus.Text = "AI Engine: Đang kết nối...";
            StatusDot.Fill = new SolidColorBrush(Color.FromRgb(245, 158, 11)); // Amber color

            await _pythonManager.StartBackendAsync();

            if (_pythonManager.IsRunning)
            {
                TxtStatus.Text = "AI Engine: Đã kết nối";
                StatusDot.Fill = new SolidColorBrush(Color.FromRgb(16, 185, 129)); // Green
                _aiVoices = await _aiTtsService.GetAiVoicesAsync();
            }
            else
            {
                TxtStatus.Text = "AI Engine: Offline (Chỉ dùng Windows)";
                StatusBadge.Background = new SolidColorBrush(Color.FromRgb(153, 27, 27)); // Red background
                StatusDot.Fill = new SolidColorBrush(Color.FromRgb(239, 68, 68)); // Red
            }

            // 3. Hiển thị giọng mặc định theo Engine lựa chọn
            LoadVoicesForSelectedEngine();

            // Text mẫu ban đầu
            TxtInputText.Text = "Xin chào! Chào mừng bạn đến với ứng dụng VoiceCraft TTS Studio. " +
                                "Hệ thống hỗ trợ cả giọng đọc Windows Native offline và giọng AI Neural tự nhiên truyền cảm. " +
                                "Hãy chọn giọng đọc và nhấn nút Đọc Văn Bản để trải nghiệm!";
        }

        private void MainWindow_Closing(object? sender, System.ComponentModel.CancelEventArgs e)
        {
            _windowsTtsService.Stop();
            _aiTtsService.Stop();
            _pythonManager.StopBackend();
            _windowsTtsService.Dispose();
            _aiTtsService.Dispose();
        }

        private void LoadVoicesForSelectedEngine()
        {
            CboVoices.Items.Clear();

            if (RbWindowsEngine.IsChecked == true)
            {
                foreach (var v in _windowsVoices)
                {
                    CboVoices.Items.Add(v);
                }
            }
            else
            {
                if (_aiVoices.Count == 0 && !_pythonManager.IsRunning)
                {
                    MessageBox.Show("AI Engine đang offline. Đang chuyển về giọng Windows Engine.", 
                                    "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                    RbWindowsEngine.IsChecked = true;
                    return;
                }
                foreach (var v in _aiVoices)
                {
                    CboVoices.Items.Add(v);
                }
            }

            if (CboVoices.Items.Count > 0)
            {
                CboVoices.SelectedIndex = 0;
            }
        }

        private void Engine_SelectionChanged(object sender, RoutedEventArgs e)
        {
            if (IsLoaded)
            {
                LoadVoicesForSelectedEngine();
            }
        }

        private void CboVoices_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (CboVoices.SelectedItem is VoiceModel selectedVoice)
            {
                TxtVoiceLang.Text = $"{selectedVoice.Language} ({selectedVoice.Gender})";
            }
        }

        private async void BtnPlay_Click(object sender, RoutedEventArgs e)
        {
            string text = TxtInputText.Text.Trim();
            if (string.IsNullOrEmpty(text))
            {
                MessageBox.Show("Vui lòng nhập văn bản cần đọc!", "Cảnh báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if (CboVoices.SelectedItem is not VoiceModel selectedVoice)
            {
                MessageBox.Show("Vui lòng chọn giọng đọc!", "Cảnh báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            int rate = (int)SliderSpeed.Value;
            int pitch = (int)SliderPitch.Value;
            int volume = (int)SliderVolume.Value;

            try
            {
                StartPlaybackAnimation();
                TxtPlaybackStatus.Text = $"▶ Đang đọc bằng [{selectedVoice.Source}]: {selectedVoice.Name}";

                if (RbWindowsEngine.IsChecked == true)
                {
                    _windowsTtsService.Speak(text, selectedVoice.Id, rate, volume);
                }
                else
                {
                    await _aiTtsService.PlayAsync(text, selectedVoice.Id, rate, pitch);
                }

                // Lưu vào lịch sử
                _historyItems.Insert(0, new HistoryItem
                {
                    Text = text,
                    VoiceName = selectedVoice.Name,
                    Engine = selectedVoice.Source,
                    Timestamp = DateTime.Now
                });
            }
            catch (Exception ex)
            {
                StopPlaybackAnimation();
                MessageBox.Show($"Lỗi phát âm thanh: {ex.Message}", "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void BtnPause_Click(object sender, RoutedEventArgs e)
        {
            if (!_isSpeaking) return;

            if (!_isPaused)
            {
                if (RbWindowsEngine.IsChecked == true) _windowsTtsService.Pause();
                else _aiTtsService.Pause();

                _isPaused = true;
                TxtPlaybackStatus.Text = "⏸ Đang tạm dừng";
                _visualizerTimer?.Stop();
            }
            else
            {
                if (RbWindowsEngine.IsChecked == true) _windowsTtsService.Resume();
                else _aiTtsService.Resume();

                _isPaused = false;
                TxtPlaybackStatus.Text = "▶ Tiếp tục đọc...";
                _visualizerTimer?.Start();
            }
        }

        private void BtnStop_Click(object sender, RoutedEventArgs e)
        {
            _windowsTtsService.Stop();
            _aiTtsService.Stop();
            StopPlaybackAnimation();
        }

        private async void BtnExport_Click(object sender, RoutedEventArgs e)
        {
            string text = TxtInputText.Text.Trim();
            if (string.IsNullOrEmpty(text))
            {
                MessageBox.Show("Vui lòng nhập văn bản cần xuất ra file!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if (CboVoices.SelectedItem is not VoiceModel selectedVoice)
            {
                MessageBox.Show("Vui lòng chọn giọng đọc!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            bool isAi = RbAiEngine.IsChecked == true;
            SaveFileDialog dlg = new SaveFileDialog
            {
                Filter = isAi ? "Audio MP3 (*.mp3)|*.mp3" : "Audio WAV (*.wav)|*.wav",
                FileName = $"VoiceCraft_Export_{DateTime.Now:yyyyMMdd_HHmmss}"
            };

            if (dlg.ShowDialog() == true)
            {
                try
                {
                    int rate = (int)SliderSpeed.Value;
                    int pitch = (int)SliderPitch.Value;
                    int volume = (int)SliderVolume.Value;

                    if (isAi)
                    {
                        await _aiTtsService.ExportToFileAsync(text, selectedVoice.Id, dlg.FileName, rate, pitch);
                    }
                    else
                    {
                        await _windowsTtsService.ExportToWavAsync(text, selectedVoice.Id, dlg.FileName, rate, volume);
                    }

                    MessageBox.Show($"Đã xuất file âm thanh thành công!\nĐường dẫn: {dlg.FileName}", 
                                    "Thành công", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi xuất file: {ex.Message}", "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void BtnOpenFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog
            {
                Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
            };

            if (dlg.ShowDialog() == true)
            {
                try
                {
                    TxtInputText.Text = File.ReadAllText(dlg.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Không thể đọc file: {ex.Message}", "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void BtnClear_Click(object sender, RoutedEventArgs e)
        {
            TxtInputText.Clear();
        }

        private void BtnClearHistory_Click(object sender, RoutedEventArgs e)
        {
            _historyItems.Clear();
        }

        private void LstHistory_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (LstHistory.SelectedItem is HistoryItem item)
            {
                TxtInputText.Text = item.Text;
            }
        }

        private void TxtInputText_TextChanged(object sender, TextChangedEventArgs e)
        {
            string text = TxtInputText.Text;
            int charCount = text.Length;
            int wordCount = text.Split(new[] { ' ', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries).Length;
            TxtCharCount.Text = $"{charCount:N0} ký tự | {wordCount:N0} từ";
        }

        private void SliderSpeed_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (TxtSpeedVal != null)
            {
                double val = Math.Round(e.NewValue, 1);
                TxtSpeedVal.Text = val >= 0 ? $"+{val}" : $"{val}";
            }
        }

        private void SliderPitch_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (TxtPitchVal != null)
            {
                TxtPitchVal.Text = $"{Math.Round(e.NewValue)}";
            }
        }

        private void SliderVolume_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (TxtVolumeVal != null)
            {
                TxtVolumeVal.Text = $"{Math.Round(e.NewValue)}%";
            }
        }

        private void WindowsTtsService_SpeakCompleted(object? sender, System.Speech.Synthesis.SpeakCompletedEventArgs e)
        {
            Dispatcher.Invoke(StopPlaybackAnimation);
        }

        private void AiTtsService_PlaybackStopped(object? sender, EventArgs e)
        {
            Dispatcher.Invoke(StopPlaybackAnimation);
        }

        private void SetupVisualizerTimer()
        {
            _visualizerTimer = new System.Windows.Threading.DispatcherTimer
            {
                Interval = TimeSpan.FromMilliseconds(120)
            };
            _visualizerTimer.Tick += (s, e) =>
            {
                Bar1.Height = _random.Next(8, 32);
                Bar2.Height = _random.Next(8, 36);
                Bar3.Height = _random.Next(8, 40);
                Bar4.Height = _random.Next(8, 30);
                Bar5.Height = _random.Next(8, 34);
            };
        }

        private void StartPlaybackAnimation()
        {
            _isSpeaking = true;
            _isPaused = false;
            _visualizerTimer?.Start();
        }

        private void StopPlaybackAnimation()
        {
            _isSpeaking = false;
            _isPaused = false;
            _visualizerTimer?.Stop();
            TxtPlaybackStatus.Text = "⏹ Sẵn sàng đọc văn bản";
            Bar1.Height = 12;
            Bar2.Height = 20;
            Bar3.Height = 28;
            Bar4.Height = 16;
            Bar5.Height = 24;
        }
    }
}