using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using BT_TNC_Dot_NET.Controls;
using BT_TNC_Dot_NET.Helpers;
using BT_TNC_Dot_NET.Models;
using BT_TNC_Dot_NET.Services;

namespace BT_TNC_Dot_NET
{
    public partial class MainForm : Form
    {
        private static class NativeMethods
        {
            public const int WM_NCLBUTTONDOWN = 0xA1;
            public const int HT_CAPTION = 0x2;

            [DllImport("user32.dll")]
            public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

            [DllImport("user32.dll")]
            public static extern bool ReleaseCapture();
        }

        private readonly TtsService _ttsService;
        private readonly VieNeuTtsService _vieNeuService;
        
        private string _cloneAudioPath = string.Empty;
        private bool _isVieNeuEngine = true;

        public MainForm()
        {
            InitializeComponent();

            _ttsService = new TtsService();
            
            string vieneuDir = Path.Combine(Application.StartupPath, "VieNeu-TTS");
            if (!Directory.Exists(vieneuDir))
            {
                // Thử tìm ngược lên các thư mục cha để định vị thư mục VieNeu-TTS (cho môi trường phát triển)
                string currentDir = Application.StartupPath;
                bool found = false;
                for (int i = 0; i < 4; i++) // Quét ngược lên tối đa 4 cấp thư mục cha
                {
                    string checkPath = Path.Combine(currentDir, "VieNeu-TTS");
                    if (Directory.Exists(checkPath))
                    {
                        vieneuDir = Path.GetFullPath(checkPath);
                        found = true;
                        break;
                    }
                    string parent = Directory.GetParent(currentDir)?.FullName;
                    if (string.IsNullOrEmpty(parent) || parent == currentDir) break;
                    currentDir = parent;
                }

                if (!found)
                {
                    // Fallback về đường dẫn dự án hiện tại nếu không tự tìm thấy
                    vieneuDir = @"D:\Download\.Net\Bài Tự Nghiên Cứu\BT_TNC_Dot-NET\VieNeu-TTS";
                }
            }
            _vieNeuService = new VieNeuTtsService(vieneuDir);

            InitializeServicesEvents();
        }

        private void InitializeServicesEvents()
        {
            _ttsService.SpeakProgress += (s, e) =>
            {
                if (InvokeRequired)
                {
                    Invoke(new Action(() => UpdatePlaybackStatus(e.CharacterPosition, e.CharacterCount, e.Text)));
                }
                else
                {
                    UpdatePlaybackStatus(e.CharacterPosition, e.CharacterCount, e.Text);
                }
            };

            _ttsService.SpeakCompleted += (s, e) =>
            {
                if (InvokeRequired)
                {
                    Invoke(new Action(() => UpdatePlaybackStateUI(false)));
                }
                else
                {
                    UpdatePlaybackStateUI(false);
                }
            };
        }

        private void UpdatePlaybackStatus(int pos, int count, string text)
        {
            lblPlaybackStatusInfo.Text = $"▶ Đang đọc: \"{text}\" ({pos}/{count})";
            lblStatusReady.Text = $"▶ Đang đọc vị trí {pos}...";
        }

        private void UpdatePlaybackStateUI(bool isSpeaking)
        {
            if (isSpeaking)
            {
                lblPlaybackStatusInfo.Text = "▶ Đang phát âm thanh...";
                lblStatusReady.Text = "▶ Đang phát giọng đọc...";
                waveformVisualizer.IsPlaying = true;
                btnPlayText.Enabled = false;
                btnPauseAudio.Enabled = true;
                btnStopAudio.Enabled = true;
            }
            else
            {
                lblPlaybackStatusInfo.Text = "⏹ Đã dừng phát";
                lblStatusReady.Text = "⏹ Hệ thống sẵn sàng.";
                waveformVisualizer.IsPlaying = false;
                btnPlayText.Enabled = true;
                btnPauseAudio.Enabled = false;
                btnStopAudio.Enabled = false;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            txtInputContent.AllowDrop = true;
            txtInputContent.DragEnter += TxtInputContent_DragEnter;
            txtInputContent.DragDrop += TxtInputContent_DragDrop;

            this.AllowDrop = true;
            this.DragEnter += TxtInputContent_DragEnter;
            this.DragDrop += TxtInputContent_DragDrop;

            cboLanguageSelection.SelectedIndex = 0;
            cboThemeSelection.SelectedIndex = 0;

            LoadVoicesList();
            UpdateCharAndWordCount();

            txtInputContent.Text = "Xin chào! Đây là phần mềm VoiceCraft Studio Pro với giao diện Chip Buttons hiện đại 1-Click chọn nhanh sắc độ, trường độ và cao giọng.";
        }

        private void TxtInputContent_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void TxtInputContent_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                if (files != null && files.Length > 0)
                {
                    string filePath = files[0];
                    string ext = Path.GetExtension(filePath).ToLower();

                    if (ext == ".txt")
                    {
                        txtInputContent.Text = File.ReadAllText(filePath);
                        lblStatusReady.Text = $"📄 Đã tải file: {Path.GetFileName(filePath)}";
                    }
                    else if (ext == ".wav" || ext == ".mp3")
                    {
                        _cloneAudioPath = filePath;
                        chkEnableVoiceCloning.Checked = true;
                        lblCloneAudioStatus.Text = $"🎵 File mẫu: {Path.GetFileName(filePath)}";
                        lblStatusReady.Text = $"🧬 Đã chọn file mẫu giọng: {Path.GetFileName(filePath)}";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi kéo thả file: {ex.Message}", "Lỗi Drag & Drop", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadVoicesList()
        {
            cboVoiceSelection.Items.Clear();

            if (_isVieNeuEngine)
            {
                var vieNeuVoices = _vieNeuService.GetPresetVoices();
                foreach (var voice in vieNeuVoices)
                {
                    cboVoiceSelection.Items.Add(voice);
                }

                btnEngineVieNeu.ButtonColor = Color.FromArgb(14, 116, 144);
                btnEngineVieNeu.BorderColor = Color.FromArgb(56, 189, 248);

                btnEngineSapi.ButtonColor = Color.FromArgb(30, 41, 59);
                btnEngineSapi.BorderColor = Color.FromArgb(100, 116, 139);

                lblStatusEngine.Text = "Engine: VieNeu-TTS AI (48kHz Local)";
            }
            else
            {
                var sapiVoices = _ttsService.GetInstalledVoices();
                foreach (var voice in sapiVoices)
                {
                    cboVoiceSelection.Items.Add(voice);
                }

                btnEngineSapi.ButtonColor = Color.FromArgb(14, 116, 144);
                btnEngineSapi.BorderColor = Color.FromArgb(56, 189, 248);

                btnEngineVieNeu.ButtonColor = Color.FromArgb(30, 41, 59);
                btnEngineVieNeu.BorderColor = Color.FromArgb(100, 116, 139);

                lblStatusEngine.Text = "Engine: Windows Native SAPI5";
            }

            if (cboVoiceSelection.Items.Count > 0)
            {
                cboVoiceSelection.SelectedIndex = 0;
            }
        }

        private void UpdateChipSegmentState(FlowLayoutPanel panel, ModernButton activeBtn)
        {
            if (panel == null || activeBtn == null) return;
            foreach (Control ctrl in panel.Controls)
            {
                if (ctrl is ModernButton btn)
                {
                    if (btn == activeBtn)
                    {
                        btn.ButtonColor = Color.FromArgb(14, 116, 144);
                        btn.BorderColor = Color.FromArgb(56, 189, 248);
                    }
                    else
                    {
                        btn.ButtonColor = Color.FromArgb(30, 41, 59);
                        btn.BorderColor = Color.FromArgb(100, 116, 139);
                    }
                }
            }
        }

        private void ChipTimbre_Click(object sender, EventArgs e)
        {
            if (sender is ModernButton btn)
            {
                UpdateChipSegmentState(pnlTimbreSegment, btn);
                lblStatusStats.Text = $"Sắc độ: {btn.Text.Trim()}";
            }
        }

        private void ChipDuration_Click(object sender, EventArgs e)
        {
            if (sender is ModernButton btn)
            {
                UpdateChipSegmentState(pnlDurationSegment, btn);
                lblStatusStats.Text = $"Trường độ: {btn.Text.Trim()}";
            }
        }

        private void ChipPitch_Click(object sender, EventArgs e)
        {
            if (sender is ModernButton btn)
            {
                UpdateChipSegmentState(pnlPitchSegment, btn);
                lblStatusStats.Text = $"Cao giọng: {btn.Text.Trim()}";
            }
        }

        private void ChipStyle_Click(object sender, EventArgs e)
        {
            if (sender is ModernButton btn)
            {
                UpdateChipSegmentState(pnlStyleSegment, btn);
                lblStatusStats.Text = $"Phong cách: {btn.Text.Trim()}";
            }
        }

        private void btnEngineVieNeu_Click(object sender, EventArgs e)
        {
            _isVieNeuEngine = true;
            LoadVoicesList();
        }

        private void btnEngineSapi_Click(object sender, EventArgs e)
        {
            _isVieNeuEngine = false;
            LoadVoicesList();
        }

        private void menuVoiceEngineVieNeu_Click(object sender, EventArgs e) => btnEngineVieNeu_Click(sender, e);
        private void menuVoiceEngineSapi_Click(object sender, EventArgs e) => btnEngineSapi_Click(sender, e);

        private void cboVoiceSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboVoiceSelection.SelectedItem != null)
            {
                string selectedVoiceName = cboVoiceSelection.SelectedItem.ToString();
                lblVoiceDetails.Text = $"Giọng đã chọn: {selectedVoiceName}\nEngine: {(_isVieNeuEngine ? "VieNeu AI 48kHz" : "SAPI5 Native")}";
                lblStatusVoice.Text = $"Giọng: {selectedVoiceName}";
            }
        }

        private void chkEnableVoiceCloning_CheckedChanged(object sender, EventArgs e)
        {
            btnSelectCloneAudio.Enabled = chkEnableVoiceCloning.Checked;
            if (chkEnableVoiceCloning.Checked && string.IsNullOrEmpty(_cloneAudioPath))
            {
                btnSelectCloneAudio_Click(sender, e);
            }
        }

        private void btnSelectCloneAudio_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openDlg = new OpenFileDialog())
            {
                openDlg.Filter = "File Âm Thanh (*.wav;*.mp3)|*.wav;*.mp3|Tất cả tệp (*.*)|*.*";
                openDlg.Title = "Chọn file mẫu giọng đọc (5s - 15s)";

                if (openDlg.ShowDialog() == DialogResult.OK)
                {
                    _cloneAudioPath = openDlg.FileName;
                    chkEnableVoiceCloning.Checked = true;
                    lblCloneAudioStatus.Text = $"🎵 File mẫu: {Path.GetFileName(_cloneAudioPath)}";
                    lblStatusReady.Text = $"🧬 Đã chọn mẫu giọng: {Path.GetFileName(_cloneAudioPath)}";
                }
            }
        }

        private async void btnPlayText_Click(object sender, EventArgs e)
        {
            string content = txtInputContent.Text.Trim();
            if (string.IsNullOrEmpty(content))
            {
                MessageBox.Show("Vui lòng nhập nội dung văn bản cần đọc!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int speed = trkSpeedRate.Value;
                int pitch = trkPitchRate.Value;
                int volume = trkVolumeLevel.Value;

                if (_isVieNeuEngine)
                {
                    lblPlaybackStatusInfo.Text = "▶ VieNeu AI đang đọc văn bản...";
                    waveformVisualizer.IsPlaying = true;
                    btnPlayText.Enabled = false;
                    btnPauseAudio.Enabled = false;
                    btnStopAudio.Enabled = true;

                    string voiceName = cboVoiceSelection.SelectedItem != null ? cboVoiceSelection.SelectedItem.ToString() : "Trúc Ly";
                    string cloneAudio = chkEnableVoiceCloning.Checked ? _cloneAudioPath : "";

                    await _vieNeuService.SpeakAsync(content, voiceName, "tu_nhien", pitch / 2.0, (statusMsg) =>
                    {
                        if (InvokeRequired)
                        {
                            Invoke(new Action(() => lblStatusReady.Text = statusMsg));
                        }
                        else
                        {
                            lblStatusReady.Text = statusMsg;
                        }
                    }, cloneAudio);

                    UpdatePlaybackStateUI(false);
                }
                else
                {
                    UpdatePlaybackStateUI(true);
                    string voiceName = "";
                    if (cboVoiceSelection.SelectedItem is VoiceItem voiceItem)
                    {
                        voiceName = voiceItem.Name;
                    }
                    else if (cboVoiceSelection.SelectedItem != null)
                    {
                        voiceName = cboVoiceSelection.SelectedItem.ToString();
                    }

                    _ttsService.Speak(content, voiceName, speed, volume);
                }

                AddHistoryRecord(content);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi phát âm thanh: {ex.Message}", "Lỗi TTS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                UpdatePlaybackStateUI(false);
            }
        }

        private void btnPauseAudio_Click(object sender, EventArgs e)
        {
            if (_isVieNeuEngine)
            {
                _vieNeuService.Stop();
                UpdatePlaybackStateUI(false);
            }
            else
            {
                if (_ttsService.IsSpeaking && !_ttsService.IsPaused)
                {
                    _ttsService.Pause();
                    waveformVisualizer.IsPlaying = false;
                    lblPlaybackStatusInfo.Text = "⏸ Tạm dừng phát";
                }
                else if (_ttsService.IsSpeaking && _ttsService.IsPaused)
                {
                    _ttsService.Resume();
                    waveformVisualizer.IsPlaying = true;
                    lblPlaybackStatusInfo.Text = "▶ Đang phát âm thanh...";
                }
            }
        }

        private void btnStopAudio_Click(object sender, EventArgs e)
        {
            if (_isVieNeuEngine)
            {
                _vieNeuService.Stop();
            }
            else
            {
                _ttsService.Stop();
            }
            UpdatePlaybackStateUI(false);
        }

        private void btnClearInputText_Click(object sender, EventArgs e)
        {
            txtInputContent.Clear();
            UpdateCharAndWordCount();
        }

        private void btnBrowseFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openDlg = new OpenFileDialog())
            {
                openDlg.Filter = "File Văn Bản (*.txt)|*.txt|Tất cả tệp (*.*)|*.*";
                openDlg.Title = "Chọn file văn bản để nạp";

                if (openDlg.ShowDialog() == DialogResult.OK)
                {
                    txtInputContent.Text = File.ReadAllText(openDlg.FileName);
                    lblStatusReady.Text = $"📄 Đã nạp file: {Path.GetFileName(openDlg.FileName)}";
                }
            }
        }

        private async void btnExportAudioWav_Click(object sender, EventArgs e)
        {
            string content = txtInputContent.Text.Trim();
            if (string.IsNullOrEmpty(content))
            {
                MessageBox.Show("Vui lòng nhập nội dung văn bản cần xuất file!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SaveFileDialog saveDlg = new SaveFileDialog())
            {
                saveDlg.Filter = "File Âm Thanh WAV (*.wav)|*.wav";
                saveDlg.Title = "Lưu file âm thanh WAV";
                saveDlg.FileName = $"VoiceCraft_Export_{DateTime.Now:yyyyMMdd_HHmmss}.wav";

                if (saveDlg.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        if (_isVieNeuEngine)
                        {
                            string voiceName = cboVoiceSelection.SelectedItem != null ? cboVoiceSelection.SelectedItem.ToString() : "Trúc Ly";
                            string cloneAudio = chkEnableVoiceCloning.Checked ? _cloneAudioPath : "";
                            await _vieNeuService.GenerateAudioWavAsync(content, voiceName, "tu_nhien", trkPitchRate.Value / 2.0, saveDlg.FileName, cloneAudio);
                        }
                        else
                        {
                            string voiceName = cboVoiceSelection.SelectedItem != null ? cboVoiceSelection.SelectedItem.ToString() : "";
                            await _ttsService.ExportToWavAsync(content, voiceName, saveDlg.FileName, trkSpeedRate.Value, trkVolumeLevel.Value);
                        }

                        MessageBox.Show($"Xuất file âm thanh thành công!\nĐường dẫn: {saveDlg.FileName}", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi xuất file âm thanh: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void txtInputContent_TextChanged(object sender, EventArgs e)
        {
            UpdateCharAndWordCount();
        }

        private void UpdateCharAndWordCount()
        {
            string text = txtInputContent.Text;
            int charCount = text.Length;
            int wordCount = string.IsNullOrWhiteSpace(text) ? 0 : text.Split(new[] { ' ', '\r', '\n', '\t' }, StringSplitOptions.RemoveEmptyEntries).Length;

            lblCharAndWordCount.Text = $"{charCount} ký tự | {wordCount} từ";
            lblStatusStats.Text = $"{charCount} ký tự | {wordCount} từ";
        }

        private void lblEmotionTag_Click(object sender, EventArgs e)
        {
            if (sender is Label lbl)
            {
                string tag = lbl.Text.Replace("+ ", "").Trim();
                int selStart = txtInputContent.SelectionStart;
                txtInputContent.Text = txtInputContent.Text.Insert(selStart, tag + " ");
                txtInputContent.SelectionStart = selStart + tag.Length + 1;
                txtInputContent.Focus();
            }
        }

        private void trkSpeedRate_Scroll(object sender, EventArgs e)
        {
            lblSpeedRateValue.Text = $"{(trkSpeedRate.Value >= 0 ? "+" : "")}{trkSpeedRate.Value / 2.0:F1}";
        }

        private void trkPitchRate_Scroll(object sender, EventArgs e)
        {
            lblPitchRateValue.Text = $"{(trkPitchRate.Value >= 0 ? "+" : "")}{trkPitchRate.Value / 2.0:F1}";
        }

        private void trkVolumeLevel_Scroll(object sender, EventArgs e)
        {
            lblVolumeLevelValue.Text = $"{trkVolumeLevel.Value}%";
        }

        private void AddHistoryRecord(string text)
        {
            string snippet = text.Length > 25 ? text.Substring(0, 25) + "..." : text;
            string logItem = $"[{DateTime.Now:HH:mm:ss}] {snippet}";
            lstHistoryLogs.Items.Insert(0, logItem);
        }

        private void lstHistoryLogs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstHistoryLogs.SelectedItem != null)
            {
                lblStatusReady.Text = $"📜 Lịch sử: {lstHistoryLogs.SelectedItem}";
            }
        }

        private void btnClearHistoryRecords_Click(object sender, EventArgs e)
        {
            lstHistoryLogs.Items.Clear();
        }

        private void cboThemeSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboThemeSelection.SelectedIndex >= 0)
            {
                var palette = ThemeManager.GetPalette((AppThemeMode)cboThemeSelection.SelectedIndex);
                if (palette != null)
                {
                    this.BackColor = palette.FormBg;
                    pnlHeaderCard.GradientTopColor = palette.HeaderTop;
                    pnlHeaderCard.GradientBottomColor = palette.HeaderBottom;
                    pnlHeaderCard.BorderColor = palette.HeaderBorder;
                    btnPlayText.ButtonColor = palette.PlayBtnBg;
                    btnPlayText.HoverColor = palette.PlayBtnHover;
                    btnPlayText.BorderColor = palette.PlayBtnBorder;
                }
            }
        }

        private void cboLanguageSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLanguageSelection.SelectedIndex >= 0)
            {
                lblStatusReady.Text = cboLanguageSelection.SelectedIndex == 0 ? "🇻🇳 Ngôn ngữ: Tiếng Việt" : "🇬🇧 Language: English";
            }
        }

        private void btnCloseApp_Click(object sender, EventArgs e) => Application.Exit();

        private void btnMaximizeApp_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
                pnlHeaderCard.BorderRadius = 0;
            }
            else
            {
                WindowState = FormWindowState.Normal;
                pnlHeaderCard.BorderRadius = 0;
            }
        }

        private void btnMinimizeApp_Click(object sender, EventArgs e) => WindowState = FormWindowState.Minimized;

        private void btnCloseApp_MouseEnter(object sender, EventArgs e) => btnCloseApp.ForeColor = Color.Red;
        private void btnCloseApp_MouseLeave(object sender, EventArgs e) => btnCloseApp.ForeColor = Color.FromArgb(148, 163, 184);

        private void btnMaximizeApp_MouseEnter(object sender, EventArgs e) => btnMaximizeApp.ForeColor = Color.Cyan;
        private void btnMaximizeApp_MouseLeave(object sender, EventArgs e) => btnMaximizeApp.ForeColor = Color.FromArgb(148, 163, 184);

        private void btnMinimizeApp_MouseEnter(object sender, EventArgs e) => btnMinimizeApp.ForeColor = Color.Yellow;
        private void btnMinimizeApp_MouseLeave(object sender, EventArgs e) => btnMinimizeApp.ForeColor = Color.FromArgb(148, 163, 184);

        private void Header_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                NativeMethods.ReleaseCapture();
                NativeMethods.SendMessage(Handle, NativeMethods.WM_NCLBUTTONDOWN, NativeMethods.HT_CAPTION, 0);
            }
        }

        private void Header_DoubleClick(object sender, EventArgs e) => btnMaximizeApp_Click(sender, e);

        private void ctxCut_Click(object sender, EventArgs e) => txtInputContent.Cut();
        private void ctxCopy_Click(object sender, EventArgs e) => txtInputContent.Copy();
        private void ctxPaste_Click(object sender, EventArgs e) => txtInputContent.Paste();

        private async void ctxSpeakSelected_Click(object sender, EventArgs e)
        {
            string selectedText = txtInputContent.SelectedText;
            if (!string.IsNullOrEmpty(selectedText))
            {
                if (_isVieNeuEngine)
                {
                    string voiceName = cboVoiceSelection.SelectedItem != null ? cboVoiceSelection.SelectedItem.ToString() : "Trúc Ly";
                    await _vieNeuService.SpeakAsync(selectedText, voiceName, "tu_nhien", trkPitchRate.Value / 2.0, null, _cloneAudioPath);
                }
                else
                {
                    _ttsService.Speak(selectedText, "");
                }
            }
        }

        private void menuHelpGuide_Click(object sender, EventArgs e)
        {
            MessageBox.Show("HƯỚNG DẪN SỬ DỤNG VOICECRAFT STUDIO:\n1. Nhập văn bản hoặc kéo thả file .txt vào ô giữa.\n2. Chọn Chip Engine, Chip Sắc Độ, Trường Độ và Cao Giọng bằng 1-Click.\n3. Bấm [▶ ĐỌC VĂN BẢN (F5)] để phát hoặc [💾 Xuất WAV] để xuất tệp âm thanh.", "Hướng Dẫn", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void menuHelpReport_Click(object sender, EventArgs e)
        {
            MessageBox.Show("BÁO CÁO NGHIÊN CỨU DỰ ÁN:\n- Kiến trúc Model VieNeu-TTS local offline 48kHz.\n- Hệ thống Graphic Equalizer 10 dải tần Hz.\n- Chip Buttons segmented control WinUI 3.", "Báo Cáo Nghiên Cứu", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void menuHelpAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("VoiceCraft Studio Pro v3.5\nPhát triển bởi Giám Đốc B (Gemini 3.1 Pro) trên nền .NET Framework 4.8.", "Giới Thiệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MainForm_Resize(object sender, EventArgs e) { }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) { }

        private void pnlRightHistorySidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlCenterEditorContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblVoiceDetails_Click(object sender, EventArgs e)
        {

        }

        private void pnlTextEditorFooter_Paint(object sender, PaintEventArgs e)
        {

        }

        private void graphicEqControl_Load(object sender, EventArgs e)
        {

        }

        private void lblFileSectionTitle_Click(object sender, EventArgs e)
        {

        }

        private void trkSpeedRate_Click(object sender, EventArgs e)
        {

        }

        private void trkPitchRate_Click(object sender, EventArgs e)
        {

        }

        private void pnlEngineSegment_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
