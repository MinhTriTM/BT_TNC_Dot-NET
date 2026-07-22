using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using BT_TNC_Dot_NET.Controls;

namespace BT_TNC_Dot_NET
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlHeaderCard = new BT_TNC_Dot_NET.Controls.RoundedPanel();
            this.cboThemeSelection = new System.Windows.Forms.ComboBox();
            this.cboLanguageSelection = new System.Windows.Forms.ComboBox();
            this.btnCloseApp = new System.Windows.Forms.Label();
            this.btnMaximizeApp = new System.Windows.Forms.Label();
            this.btnMinimizeApp = new System.Windows.Forms.Label();
            this.lblAppSubtitle = new System.Windows.Forms.Label();
            this.lblAppTitle = new System.Windows.Forms.Label();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileExport = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditClear = new System.Windows.Forms.ToolStripMenuItem();
            this.menuVoice = new System.Windows.Forms.ToolStripMenuItem();
            this.menuVoiceEngineVieNeu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuVoiceEngineSapi = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelpGuide = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelpReport = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.mainToolStrip = new System.Windows.Forms.ToolStrip();
            this.toolBtnOpen = new System.Windows.Forms.ToolStripButton();
            this.toolBtnExport = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolBtnPlay = new System.Windows.Forms.ToolStripButton();
            this.toolBtnPause = new System.Windows.Forms.ToolStripButton();
            this.toolBtnStop = new System.Windows.Forms.ToolStripButton();
            this.mainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.lblStatusReady = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblStatusEngine = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblStatusVoice = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblStatusStats = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctxCut = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxClear = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxSpeakSelected = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlLeftControlSidebar = new System.Windows.Forms.Panel();
            this.cardFileActions = new BT_TNC_Dot_NET.Controls.RoundedPanel();
            this.lblFileSectionTitle = new System.Windows.Forms.Label();
            this.btnExportAudioWav = new BT_TNC_Dot_NET.Controls.ModernButton();
            this.btnBrowseFile = new BT_TNC_Dot_NET.Controls.ModernButton();
            this.cardAudioSettings = new BT_TNC_Dot_NET.Controls.RoundedPanel();
            this.lblAudioSectionTitle = new System.Windows.Forms.Label();
            this.lblSpeedRateText = new System.Windows.Forms.Label();
            this.lblSpeedRateValue = new System.Windows.Forms.Label();
            this.trkSpeedRate = new BT_TNC_Dot_NET.Controls.ModernTrackBar();
            this.lblPitchRateText = new System.Windows.Forms.Label();
            this.lblPitchRateValue = new System.Windows.Forms.Label();
            this.trkPitchRate = new BT_TNC_Dot_NET.Controls.ModernTrackBar();
            this.lblVolumeLevelText = new System.Windows.Forms.Label();
            this.lblVolumeLevelValue = new System.Windows.Forms.Label();
            this.trkVolumeLevel = new BT_TNC_Dot_NET.Controls.ModernTrackBar();
            this.lblGraphicEqTitle = new System.Windows.Forms.Label();
            this.graphicEqControl = new BT_TNC_Dot_NET.Controls.ModernEqualizerControl();
            this.cardVoiceCloning = new BT_TNC_Dot_NET.Controls.RoundedPanel();
            this.lblCloneSectionTitle = new System.Windows.Forms.Label();
            this.chkEnableVoiceCloning = new System.Windows.Forms.CheckBox();
            this.btnSelectCloneAudio = new BT_TNC_Dot_NET.Controls.ModernButton();
            this.lblCloneAudioStatus = new System.Windows.Forms.Label();
            this.cardVoiceSelection = new BT_TNC_Dot_NET.Controls.RoundedPanel();
            this.lblEngineTitle = new System.Windows.Forms.Label();
            this.pnlEngineSegment = new System.Windows.Forms.FlowLayoutPanel();
            this.btnEngineVieNeu = new BT_TNC_Dot_NET.Controls.ModernButton();
            this.btnEngineSapi = new BT_TNC_Dot_NET.Controls.ModernButton();
            this.lblVoiceSectionTitle = new System.Windows.Forms.Label();
            this.cboVoiceSelection = new System.Windows.Forms.ComboBox();
            this.lblTimbreTitle = new System.Windows.Forms.Label();
            this.pnlTimbreSegment = new System.Windows.Forms.FlowLayoutPanel();
            this.btnTimbreStandard = new BT_TNC_Dot_NET.Controls.ModernButton();
            this.btnTimbreRadio = new BT_TNC_Dot_NET.Controls.ModernButton();
            this.btnTimbreWarm = new BT_TNC_Dot_NET.Controls.ModernButton();
            this.btnTimbreBright = new BT_TNC_Dot_NET.Controls.ModernButton();
            this.btnTimbreReverb = new BT_TNC_Dot_NET.Controls.ModernButton();
            this.lblDurationTitle = new System.Windows.Forms.Label();
            this.pnlDurationSegment = new System.Windows.Forms.FlowLayoutPanel();
            this.btnDurationStandard = new BT_TNC_Dot_NET.Controls.ModernButton();
            this.btnDurationShort = new BT_TNC_Dot_NET.Controls.ModernButton();
            this.btnDurationLong = new BT_TNC_Dot_NET.Controls.ModernButton();
            this.lblPitchTuningTitle = new System.Windows.Forms.Label();
            this.pnlPitchSegment = new System.Windows.Forms.FlowLayoutPanel();
            this.btnPitchDeep = new BT_TNC_Dot_NET.Controls.ModernButton();
            this.btnPitchLow = new BT_TNC_Dot_NET.Controls.ModernButton();
            this.btnPitchNormal = new BT_TNC_Dot_NET.Controls.ModernButton();
            this.btnPitchHigh = new BT_TNC_Dot_NET.Controls.ModernButton();
            this.btnPitchBright = new BT_TNC_Dot_NET.Controls.ModernButton();
            this.lblStyleSectionTitle = new System.Windows.Forms.Label();
            this.pnlStyleSegment = new System.Windows.Forms.FlowLayoutPanel();
            this.btnStyleNatural = new BT_TNC_Dot_NET.Controls.ModernButton();
            this.btnStyleNews = new BT_TNC_Dot_NET.Controls.ModernButton();
            this.btnStyleStory = new BT_TNC_Dot_NET.Controls.ModernButton();
            this.btnStyleDrama = new BT_TNC_Dot_NET.Controls.ModernButton();
            this.lblVoiceDetails = new System.Windows.Forms.Label();
            this.pnlCenterEditorContainer = new System.Windows.Forms.Panel();
            this.cardTextEditor = new BT_TNC_Dot_NET.Controls.RoundedPanel();
            this.txtInputContent = new System.Windows.Forms.TextBox();
            this.pnlTextEditorFooter = new System.Windows.Forms.Panel();
            this.lblEmotionTag1 = new System.Windows.Forms.Label();
            this.lblEmotionTag2 = new System.Windows.Forms.Label();
            this.lblEmotionTag3 = new System.Windows.Forms.Label();
            this.lblEmotionTag4 = new System.Windows.Forms.Label();
            this.lblCharAndWordCount = new System.Windows.Forms.Label();
            this.cardPlaybackStatus = new BT_TNC_Dot_NET.Controls.RoundedPanel();
            this.lblPlaybackStatusInfo = new System.Windows.Forms.Label();
            this.waveformVisualizer = new BT_TNC_Dot_NET.Controls.WaveformVisualizer();
            this.pnlActionButtonsContainer = new System.Windows.Forms.Panel();
            this.btnClearInputText = new BT_TNC_Dot_NET.Controls.ModernButton();
            this.btnStopAudio = new BT_TNC_Dot_NET.Controls.ModernButton();
            this.btnPauseAudio = new BT_TNC_Dot_NET.Controls.ModernButton();
            this.btnPlayText = new BT_TNC_Dot_NET.Controls.ModernButton();
            this.pnlRightHistorySidebar = new System.Windows.Forms.Panel();
            this.cardHistoryLogs = new BT_TNC_Dot_NET.Controls.RoundedPanel();
            this.lblHistorySectionTitle = new System.Windows.Forms.Label();
            this.lstHistoryLogs = new System.Windows.Forms.ListBox();
            this.btnClearHistoryRecords = new BT_TNC_Dot_NET.Controls.ModernButton();
            this.pnlHeaderCard.SuspendLayout();
            this.mainMenuStrip.SuspendLayout();
            this.mainToolStrip.SuspendLayout();
            this.mainStatusStrip.SuspendLayout();
            this.txtContextMenu.SuspendLayout();
            this.pnlLeftControlSidebar.SuspendLayout();
            this.cardFileActions.SuspendLayout();
            this.cardAudioSettings.SuspendLayout();
            this.cardVoiceCloning.SuspendLayout();
            this.cardVoiceSelection.SuspendLayout();
            this.pnlEngineSegment.SuspendLayout();
            this.pnlTimbreSegment.SuspendLayout();
            this.pnlDurationSegment.SuspendLayout();
            this.pnlPitchSegment.SuspendLayout();
            this.pnlStyleSegment.SuspendLayout();
            this.pnlCenterEditorContainer.SuspendLayout();
            this.cardTextEditor.SuspendLayout();
            this.pnlTextEditorFooter.SuspendLayout();
            this.cardPlaybackStatus.SuspendLayout();
            this.pnlActionButtonsContainer.SuspendLayout();
            this.pnlRightHistorySidebar.SuspendLayout();
            this.cardHistoryLogs.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeaderCard
            // 
            this.pnlHeaderCard.BackColor = System.Drawing.Color.Transparent;
            this.pnlHeaderCard.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.pnlHeaderCard.BorderRadius = 1;
            this.pnlHeaderCard.Controls.Add(this.cboThemeSelection);
            this.pnlHeaderCard.Controls.Add(this.cboLanguageSelection);
            this.pnlHeaderCard.Controls.Add(this.btnCloseApp);
            this.pnlHeaderCard.Controls.Add(this.btnMaximizeApp);
            this.pnlHeaderCard.Controls.Add(this.btnMinimizeApp);
            this.pnlHeaderCard.Controls.Add(this.lblAppSubtitle);
            this.pnlHeaderCard.Controls.Add(this.lblAppTitle);
            this.pnlHeaderCard.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeaderCard.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(24)))));
            this.pnlHeaderCard.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.pnlHeaderCard.Location = new System.Drawing.Point(0, 0);
            this.pnlHeaderCard.Name = "pnlHeaderCard";
            this.pnlHeaderCard.Padding = new System.Windows.Forms.Padding(16, 10, 16, 10);
            this.pnlHeaderCard.Size = new System.Drawing.Size(1150, 75);
            this.pnlHeaderCard.TabIndex = 0;
            this.pnlHeaderCard.DoubleClick += new System.EventHandler(this.Header_DoubleClick);
            this.pnlHeaderCard.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Header_MouseDown);
            // 
            // cboThemeSelection
            // 
            this.cboThemeSelection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboThemeSelection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(24)))));
            this.cboThemeSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboThemeSelection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboThemeSelection.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F);
            this.cboThemeSelection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.cboThemeSelection.FormattingEnabled = true;
            this.cboThemeSelection.Items.AddRange(new object[] {
            "🪟 WinUI 3 Fluent Mica",
            "🌌 Cinematic Midnight",
            "🌆 Cyberpunk Neon",
            "🌲 Emerald Studio",
            "❄️ Nordic Light",
            "🌅 Sunset Crimson"});
            this.cboThemeSelection.Location = new System.Drawing.Point(710, 22);
            this.cboThemeSelection.Name = "cboThemeSelection";
            this.cboThemeSelection.Size = new System.Drawing.Size(170, 21);
            this.cboThemeSelection.TabIndex = 5;
            this.cboThemeSelection.SelectedIndexChanged += new System.EventHandler(this.cboThemeSelection_SelectedIndexChanged);
            // 
            // cboLanguageSelection
            // 
            this.cboLanguageSelection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboLanguageSelection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(24)))));
            this.cboLanguageSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLanguageSelection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboLanguageSelection.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F);
            this.cboLanguageSelection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.cboLanguageSelection.FormattingEnabled = true;
            this.cboLanguageSelection.Items.AddRange(new object[] {
            "🇻🇳 Tiếng Việt",
            "🇬🇧 English"});
            this.cboLanguageSelection.Location = new System.Drawing.Point(888, 22);
            this.cboLanguageSelection.Name = "cboLanguageSelection";
            this.cboLanguageSelection.Size = new System.Drawing.Size(100, 21);
            this.cboLanguageSelection.TabIndex = 4;
            this.cboLanguageSelection.SelectedIndexChanged += new System.EventHandler(this.cboLanguageSelection_SelectedIndexChanged);
            // 
            // btnCloseApp
            // 
            this.btnCloseApp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseApp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseApp.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnCloseApp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.btnCloseApp.Location = new System.Drawing.Point(1105, 18);
            this.btnCloseApp.Name = "btnCloseApp";
            this.btnCloseApp.Size = new System.Drawing.Size(30, 30);
            this.btnCloseApp.TabIndex = 3;
            this.btnCloseApp.Text = "✕";
            this.btnCloseApp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCloseApp.Click += new System.EventHandler(this.btnCloseApp_Click);
            this.btnCloseApp.MouseEnter += new System.EventHandler(this.btnCloseApp_MouseEnter);
            this.btnCloseApp.MouseLeave += new System.EventHandler(this.btnCloseApp_MouseLeave);
            // 
            // btnMaximizeApp
            // 
            this.btnMaximizeApp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizeApp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximizeApp.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btnMaximizeApp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.btnMaximizeApp.Location = new System.Drawing.Point(1070, 18);
            this.btnMaximizeApp.Name = "btnMaximizeApp";
            this.btnMaximizeApp.Size = new System.Drawing.Size(30, 30);
            this.btnMaximizeApp.TabIndex = 2;
            this.btnMaximizeApp.Text = "❐";
            this.btnMaximizeApp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMaximizeApp.Click += new System.EventHandler(this.btnMaximizeApp_Click);
            this.btnMaximizeApp.MouseEnter += new System.EventHandler(this.btnMaximizeApp_MouseEnter);
            this.btnMaximizeApp.MouseLeave += new System.EventHandler(this.btnMaximizeApp_MouseLeave);
            // 
            // btnMinimizeApp
            // 
            this.btnMinimizeApp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizeApp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizeApp.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnMinimizeApp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.btnMinimizeApp.Location = new System.Drawing.Point(1035, 18);
            this.btnMinimizeApp.Name = "btnMinimizeApp";
            this.btnMinimizeApp.Size = new System.Drawing.Size(30, 30);
            this.btnMinimizeApp.TabIndex = 1;
            this.btnMinimizeApp.Text = "─";
            this.btnMinimizeApp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMinimizeApp.Click += new System.EventHandler(this.btnMinimizeApp_Click);
            this.btnMinimizeApp.MouseEnter += new System.EventHandler(this.btnMinimizeApp_MouseEnter);
            this.btnMinimizeApp.MouseLeave += new System.EventHandler(this.btnMinimizeApp_MouseLeave);
            // 
            // lblAppSubtitle
            // 
            this.lblAppSubtitle.AutoSize = true;
            this.lblAppSubtitle.BackColor = System.Drawing.Color.Transparent;
            this.lblAppSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblAppSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(185)))), ((int)(((byte)(200)))));
            this.lblAppSubtitle.Location = new System.Drawing.Point(20, 42);
            this.lblAppSubtitle.Name = "lblAppSubtitle";
            this.lblAppSubtitle.Size = new System.Drawing.Size(434, 15);
            this.lblAppSubtitle.TabIndex = 0;
            this.lblAppSubtitle.Text = "Phần mềm chuyển đổi văn bản thành giọng nói AI cao cấp (.NET Framework 4.8)";
            this.lblAppSubtitle.DoubleClick += new System.EventHandler(this.Header_DoubleClick);
            this.lblAppSubtitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Header_MouseDown);
            // 
            // lblAppTitle
            // 
            this.lblAppTitle.AutoSize = true;
            this.lblAppTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblAppTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblAppTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.lblAppTitle.Location = new System.Drawing.Point(16, 12);
            this.lblAppTitle.Name = "lblAppTitle";
            this.lblAppTitle.Size = new System.Drawing.Size(470, 28);
            this.lblAppTitle.TabIndex = 0;
            this.lblAppTitle.Text = "🎙️ VOICECRAFT STUDIO | AI Text-To-Speech Pro";
            this.lblAppTitle.DoubleClick += new System.EventHandler(this.Header_DoubleClick);
            this.lblAppTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Header_MouseDown);
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(34)))));
            this.mainMenuStrip.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mainMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuEdit,
            this.menuVoice,
            this.menuHelp});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 75);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.mainMenuStrip.Size = new System.Drawing.Size(1150, 24);
            this.mainMenuStrip.TabIndex = 4;
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFileOpen,
            this.menuFileExport,
            this.menuFileExit});
            this.menuFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(54, 22);
            this.menuFile.Text = "📁 Tệp";
            // 
            // menuFileOpen
            // 
            this.menuFileOpen.Name = "menuFileOpen";
            this.menuFileOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.menuFileOpen.Size = new System.Drawing.Size(225, 22);
            this.menuFileOpen.Text = "📄 Mở File Văn Bản...";
            this.menuFileOpen.Click += new System.EventHandler(this.btnBrowseFile_Click);
            // 
            // menuFileExport
            // 
            this.menuFileExport.Name = "menuFileExport";
            this.menuFileExport.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.menuFileExport.Size = new System.Drawing.Size(225, 22);
            this.menuFileExport.Text = "💾 Xuất File WAV...";
            this.menuFileExport.Click += new System.EventHandler(this.btnExportAudioWav_Click);
            // 
            // menuFileExit
            // 
            this.menuFileExit.Name = "menuFileExit";
            this.menuFileExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.menuFileExit.Size = new System.Drawing.Size(225, 22);
            this.menuFileExit.Text = "✕ Thoát";
            this.menuFileExit.Click += new System.EventHandler(this.btnCloseApp_Click);
            // 
            // menuEdit
            // 
            this.menuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuEditCopy,
            this.menuEditPaste,
            this.menuEditClear});
            this.menuEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.menuEdit.Name = "menuEdit";
            this.menuEdit.Size = new System.Drawing.Size(88, 22);
            this.menuEdit.Text = "✏️ Chỉnh Sửa";
            // 
            // menuEditCopy
            // 
            this.menuEditCopy.Name = "menuEditCopy";
            this.menuEditCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.menuEditCopy.Size = new System.Drawing.Size(196, 22);
            this.menuEditCopy.Text = "📋 Sao Chép";
            this.menuEditCopy.Click += new System.EventHandler(this.ctxCopy_Click);
            // 
            // menuEditPaste
            // 
            this.menuEditPaste.Name = "menuEditPaste";
            this.menuEditPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.menuEditPaste.Size = new System.Drawing.Size(196, 22);
            this.menuEditPaste.Text = "📌 Dán Văn Bản";
            this.menuEditPaste.Click += new System.EventHandler(this.ctxPaste_Click);
            // 
            // menuEditClear
            // 
            this.menuEditClear.Name = "menuEditClear";
            this.menuEditClear.Size = new System.Drawing.Size(196, 22);
            this.menuEditClear.Text = "🗑️ Xóa Toàn Bộ";
            this.menuEditClear.Click += new System.EventHandler(this.btnClearInputText_Click);
            // 
            // menuVoice
            // 
            this.menuVoice.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuVoiceEngineVieNeu,
            this.menuVoiceEngineSapi});
            this.menuVoice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.menuVoice.Name = "menuVoice";
            this.menuVoice.Size = new System.Drawing.Size(90, 22);
            this.menuVoice.Text = "🗣️ Giọng Đọc";
            // 
            // menuVoiceEngineVieNeu
            // 
            this.menuVoiceEngineVieNeu.Name = "menuVoiceEngineVieNeu";
            this.menuVoiceEngineVieNeu.Size = new System.Drawing.Size(216, 22);
            this.menuVoiceEngineVieNeu.Text = "🦜 VieNeu-TTS AI Engine";
            this.menuVoiceEngineVieNeu.Click += new System.EventHandler(this.menuVoiceEngineVieNeu_Click);
            // 
            // menuVoiceEngineSapi
            // 
            this.menuVoiceEngineSapi.Name = "menuVoiceEngineSapi";
            this.menuVoiceEngineSapi.Size = new System.Drawing.Size(216, 22);
            this.menuVoiceEngineSapi.Text = "🔊 Windows Native (SAPI5)";
            this.menuVoiceEngineSapi.Click += new System.EventHandler(this.menuVoiceEngineSapi_Click);
            // 
            // menuHelp
            // 
            this.menuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHelpGuide,
            this.menuHelpReport,
            this.menuHelpAbout});
            this.menuHelp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.menuHelp.Name = "menuHelp";
            this.menuHelp.Size = new System.Drawing.Size(79, 22);
            this.menuHelp.Text = "❓ Trợ Giúp";
            // 
            // menuHelpGuide
            // 
            this.menuHelpGuide.Name = "menuHelpGuide";
            this.menuHelpGuide.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.menuHelpGuide.Size = new System.Drawing.Size(217, 22);
            this.menuHelpGuide.Text = "📖 Hướng Dẫn Sử Dụng";
            this.menuHelpGuide.Click += new System.EventHandler(this.menuHelpGuide_Click);
            // 
            // menuHelpReport
            // 
            this.menuHelpReport.Name = "menuHelpReport";
            this.menuHelpReport.Size = new System.Drawing.Size(217, 22);
            this.menuHelpReport.Text = "📑 Báo Cáo R&D Dự Án";
            this.menuHelpReport.Click += new System.EventHandler(this.menuHelpReport_Click);
            // 
            // menuHelpAbout
            // 
            this.menuHelpAbout.Name = "menuHelpAbout";
            this.menuHelpAbout.Size = new System.Drawing.Size(217, 22);
            this.menuHelpAbout.Text = "ℹ️ Giới Thiệu";
            this.menuHelpAbout.Click += new System.EventHandler(this.menuHelpAbout_Click);
            // 
            // mainToolStrip
            // 
            this.mainToolStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(28)))));
            this.mainToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.mainToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBtnOpen,
            this.toolBtnExport,
            this.toolStripSeparator1,
            this.toolBtnPlay,
            this.toolBtnPause,
            this.toolBtnStop});
            this.mainToolStrip.Location = new System.Drawing.Point(0, 99);
            this.mainToolStrip.Name = "mainToolStrip";
            this.mainToolStrip.Padding = new System.Windows.Forms.Padding(12, 2, 12, 2);
            this.mainToolStrip.Size = new System.Drawing.Size(1150, 27);
            this.mainToolStrip.TabIndex = 5;
            // 
            // toolBtnOpen
            // 
            this.toolBtnOpen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.toolBtnOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnOpen.Name = "toolBtnOpen";
            this.toolBtnOpen.Size = new System.Drawing.Size(89, 20);
            this.toolBtnOpen.Text = "📄 Mở Văn Bản";
            this.toolBtnOpen.Click += new System.EventHandler(this.btnBrowseFile_Click);
            // 
            // toolBtnExport
            // 
            this.toolBtnExport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.toolBtnExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnExport.Name = "toolBtnExport";
            this.toolBtnExport.Size = new System.Drawing.Size(78, 20);
            this.toolBtnExport.Text = "💾 Xuất WAV";
            this.toolBtnExport.Click += new System.EventHandler(this.btnExportAudioWav_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 23);
            // 
            // toolBtnPlay
            // 
            this.toolBtnPlay.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.toolBtnPlay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(189)))), ((int)(((byte)(248)))));
            this.toolBtnPlay.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnPlay.Name = "toolBtnPlay";
            this.toolBtnPlay.Size = new System.Drawing.Size(74, 20);
            this.toolBtnPlay.Text = "▶  Đọc (F5)";
            this.toolBtnPlay.Click += new System.EventHandler(this.btnPlayText_Click);
            // 
            // toolBtnPause
            // 
            this.toolBtnPause.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(191)))), ((int)(((byte)(36)))));
            this.toolBtnPause.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnPause.Name = "toolBtnPause";
            this.toolBtnPause.Size = new System.Drawing.Size(82, 20);
            this.toolBtnPause.Text = "⏸ Tạm Dừng";
            this.toolBtnPause.Click += new System.EventHandler(this.btnPauseAudio_Click);
            // 
            // toolBtnStop
            // 
            this.toolBtnStop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.toolBtnStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnStop.Name = "toolBtnStop";
            this.toolBtnStop.Size = new System.Drawing.Size(55, 20);
            this.toolBtnStop.Text = "⏹ Dừng";
            this.toolBtnStop.Click += new System.EventHandler(this.btnStopAudio_Click);
            // 
            // mainStatusStrip
            // 
            this.mainStatusStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(34)))));
            this.mainStatusStrip.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.mainStatusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatusReady,
            this.lblStatusEngine,
            this.lblStatusVoice,
            this.lblStatusStats});
            this.mainStatusStrip.Location = new System.Drawing.Point(0, 685);
            this.mainStatusStrip.Name = "mainStatusStrip";
            this.mainStatusStrip.Size = new System.Drawing.Size(1150, 22);
            this.mainStatusStrip.TabIndex = 6;
            // 
            // lblStatusReady
            // 
            this.lblStatusReady.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.lblStatusReady.Name = "lblStatusReady";
            this.lblStatusReady.Size = new System.Drawing.Size(758, 17);
            this.lblStatusReady.Spring = true;
            this.lblStatusReady.Text = "⏹ Hệ thống sẵn sàng";
            this.lblStatusReady.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblStatusEngine
            // 
            this.lblStatusEngine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(189)))), ((int)(((byte)(248)))));
            this.lblStatusEngine.Name = "lblStatusEngine";
            this.lblStatusEngine.Size = new System.Drawing.Size(200, 17);
            this.lblStatusEngine.Text = "Engine: VieNeu-TTS AI (48kHz Local)";
            // 
            // lblStatusVoice
            // 
            this.lblStatusVoice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(180)))), ((int)(((byte)(254)))));
            this.lblStatusVoice.Name = "lblStatusVoice";
            this.lblStatusVoice.Size = new System.Drawing.Size(106, 17);
            this.lblStatusVoice.Text = "Giọng: vi_female_1";
            // 
            // lblStatusStats
            // 
            this.lblStatusStats.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblStatusStats.Name = "lblStatusStats";
            this.lblStatusStats.Size = new System.Drawing.Size(71, 17);
            this.lblStatusStats.Text = "0 ký tự | 0 từ";
            // 
            // txtContextMenu
            // 
            this.txtContextMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(34)))));
            this.txtContextMenu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtContextMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.txtContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxCut,
            this.ctxCopy,
            this.ctxPaste,
            this.ctxClear,
            this.ctxSpeakSelected});
            this.txtContextMenu.Name = "txtContextMenu";
            this.txtContextMenu.Size = new System.Drawing.Size(195, 114);
            // 
            // ctxCut
            // 
            this.ctxCut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.ctxCut.Name = "ctxCut";
            this.ctxCut.Size = new System.Drawing.Size(194, 22);
            this.ctxCut.Text = "✂️ Cắt (Cut)";
            this.ctxCut.Click += new System.EventHandler(this.ctxCut_Click);
            // 
            // ctxCopy
            // 
            this.ctxCopy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.ctxCopy.Name = "ctxCopy";
            this.ctxCopy.Size = new System.Drawing.Size(194, 22);
            this.ctxCopy.Text = "📋 Sao Chép (Copy)";
            this.ctxCopy.Click += new System.EventHandler(this.ctxCopy_Click);
            // 
            // ctxPaste
            // 
            this.ctxPaste.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.ctxPaste.Name = "ctxPaste";
            this.ctxPaste.Size = new System.Drawing.Size(194, 22);
            this.ctxPaste.Text = "📌 Dán (Paste)";
            this.ctxPaste.Click += new System.EventHandler(this.ctxPaste_Click);
            // 
            // ctxClear
            // 
            this.ctxClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.ctxClear.Name = "ctxClear";
            this.ctxClear.Size = new System.Drawing.Size(194, 22);
            this.ctxClear.Text = "🗑️ Xóa Toàn Bộ";
            this.ctxClear.Click += new System.EventHandler(this.btnClearInputText_Click);
            // 
            // ctxSpeakSelected
            // 
            this.ctxSpeakSelected.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.ctxSpeakSelected.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(189)))), ((int)(((byte)(248)))));
            this.ctxSpeakSelected.Name = "ctxSpeakSelected";
            this.ctxSpeakSelected.Size = new System.Drawing.Size(194, 22);
            this.ctxSpeakSelected.Text = "▶  Đọc Đoạn Đã Chọn";
            this.ctxSpeakSelected.Click += new System.EventHandler(this.ctxSpeakSelected_Click);
            // 
            // pnlLeftControlSidebar
            // 
            this.pnlLeftControlSidebar.AutoScroll = true;
            this.pnlLeftControlSidebar.Controls.Add(this.cardFileActions);
            this.pnlLeftControlSidebar.Controls.Add(this.cardAudioSettings);
            this.pnlLeftControlSidebar.Controls.Add(this.cardVoiceCloning);
            this.pnlLeftControlSidebar.Controls.Add(this.cardVoiceSelection);
            this.pnlLeftControlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeftControlSidebar.Location = new System.Drawing.Point(0, 126);
            this.pnlLeftControlSidebar.Name = "pnlLeftControlSidebar";
            this.pnlLeftControlSidebar.Padding = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.pnlLeftControlSidebar.Size = new System.Drawing.Size(333, 559);
            this.pnlLeftControlSidebar.TabIndex = 1;
            // 
            // cardFileActions
            // 
            this.cardFileActions.BackColor = System.Drawing.Color.Transparent;
            this.cardFileActions.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(72)))));
            this.cardFileActions.Controls.Add(this.lblFileSectionTitle);
            this.cardFileActions.Controls.Add(this.btnExportAudioWav);
            this.cardFileActions.Controls.Add(this.btnBrowseFile);
            this.cardFileActions.Dock = System.Windows.Forms.DockStyle.Top;
            this.cardFileActions.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(34)))));
            this.cardFileActions.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(44)))));
            this.cardFileActions.Location = new System.Drawing.Point(12, 877);
            this.cardFileActions.Name = "cardFileActions";
            this.cardFileActions.Padding = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.cardFileActions.Size = new System.Drawing.Size(292, 114);
            this.cardFileActions.TabIndex = 3;
            // 
            // lblFileSectionTitle
            // 
            this.lblFileSectionTitle.AutoSize = true;
            this.lblFileSectionTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblFileSectionTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.lblFileSectionTitle.Location = new System.Drawing.Point(10, 8);
            this.lblFileSectionTitle.Name = "lblFileSectionTitle";
            this.lblFileSectionTitle.Size = new System.Drawing.Size(119, 15);
            this.lblFileSectionTitle.TabIndex = 0;
            this.lblFileSectionTitle.Text = "📁 Công Cụ & Xuất File";
            this.lblFileSectionTitle.Click += new System.EventHandler(this.lblFileSectionTitle_Click);
            // 
            // btnExportAudioWav
            // 
            this.btnExportAudioWav.BackColor = System.Drawing.Color.Transparent;
            this.btnExportAudioWav.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(211)))), ((int)(((byte)(153)))));
            this.btnExportAudioWav.BorderRadius = 10;
            this.btnExportAudioWav.BorderSize = 1;
            this.btnExportAudioWav.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(120)))), ((int)(((byte)(87)))));
            this.btnExportAudioWav.ClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(95)))), ((int)(((byte)(70)))));
            this.btnExportAudioWav.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportAudioWav.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportAudioWav.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnExportAudioWav.ForeColor = System.Drawing.Color.White;
            this.btnExportAudioWav.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.btnExportAudioWav.Location = new System.Drawing.Point(10, 70);
            this.btnExportAudioWav.Name = "btnExportAudioWav";
            this.btnExportAudioWav.Size = new System.Drawing.Size(274, 36);
            this.btnExportAudioWav.TabIndex = 2;
            this.btnExportAudioWav.Text = "💾 Xuất File Âm Thanh (.wav)";
            this.btnExportAudioWav.UseVisualStyleBackColor = false;
            this.btnExportAudioWav.Click += new System.EventHandler(this.btnExportAudioWav_Click);
            // 
            // btnBrowseFile
            // 
            this.btnBrowseFile.BackColor = System.Drawing.Color.Transparent;
            this.btnBrowseFile.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(189)))), ((int)(((byte)(248)))));
            this.btnBrowseFile.BorderRadius = 10;
            this.btnBrowseFile.BorderSize = 1;
            this.btnBrowseFile.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(116)))), ((int)(((byte)(144)))));
            this.btnBrowseFile.ClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(94)))), ((int)(((byte)(117)))));
            this.btnBrowseFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrowseFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowseFile.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnBrowseFile.ForeColor = System.Drawing.Color.White;
            this.btnBrowseFile.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(182)))), ((int)(((byte)(212)))));
            this.btnBrowseFile.Location = new System.Drawing.Point(10, 28);
            this.btnBrowseFile.Name = "btnBrowseFile";
            this.btnBrowseFile.Size = new System.Drawing.Size(274, 36);
            this.btnBrowseFile.TabIndex = 1;
            this.btnBrowseFile.Text = "📄 Mở File Văn Bản (.txt)";
            this.btnBrowseFile.UseVisualStyleBackColor = false;
            this.btnBrowseFile.Click += new System.EventHandler(this.btnBrowseFile_Click);
            // 
            // cardAudioSettings
            // 
            this.cardAudioSettings.BackColor = System.Drawing.Color.Transparent;
            this.cardAudioSettings.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(72)))));
            this.cardAudioSettings.Controls.Add(this.lblAudioSectionTitle);
            this.cardAudioSettings.Controls.Add(this.lblSpeedRateText);
            this.cardAudioSettings.Controls.Add(this.lblSpeedRateValue);
            this.cardAudioSettings.Controls.Add(this.trkSpeedRate);
            this.cardAudioSettings.Controls.Add(this.lblPitchRateText);
            this.cardAudioSettings.Controls.Add(this.lblPitchRateValue);
            this.cardAudioSettings.Controls.Add(this.trkPitchRate);
            this.cardAudioSettings.Controls.Add(this.lblVolumeLevelText);
            this.cardAudioSettings.Controls.Add(this.lblVolumeLevelValue);
            this.cardAudioSettings.Controls.Add(this.trkVolumeLevel);
            this.cardAudioSettings.Controls.Add(this.lblGraphicEqTitle);
            this.cardAudioSettings.Controls.Add(this.graphicEqControl);
            this.cardAudioSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.cardAudioSettings.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(34)))));
            this.cardAudioSettings.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(44)))));
            this.cardAudioSettings.Location = new System.Drawing.Point(12, 542);
            this.cardAudioSettings.Name = "cardAudioSettings";
            this.cardAudioSettings.Padding = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.cardAudioSettings.Size = new System.Drawing.Size(292, 335);
            this.cardAudioSettings.TabIndex = 2;
            // 
            // lblAudioSectionTitle
            // 
            this.lblAudioSectionTitle.AutoSize = true;
            this.lblAudioSectionTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblAudioSectionTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.lblAudioSectionTitle.Location = new System.Drawing.Point(10, 8);
            this.lblAudioSectionTitle.Name = "lblAudioSectionTitle";
            this.lblAudioSectionTitle.Size = new System.Drawing.Size(207, 17);
            this.lblAudioSectionTitle.TabIndex = 0;
            this.lblAudioSectionTitle.Text = "🎛️ Tùy Chỉnh Âm Thanh Chi Tiết";
            // 
            // lblSpeedRateText
            // 
            this.lblSpeedRateText.AutoSize = true;
            this.lblSpeedRateText.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblSpeedRateText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.lblSpeedRateText.Location = new System.Drawing.Point(10, 30);
            this.lblSpeedRateText.Name = "lblSpeedRateText";
            this.lblSpeedRateText.Size = new System.Drawing.Size(105, 15);
            this.lblSpeedRateText.TabIndex = 1;
            this.lblSpeedRateText.Text = "⚡ Tốc độ (Speed):";
            // 
            // lblSpeedRateValue
            // 
            this.lblSpeedRateValue.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblSpeedRateValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.lblSpeedRateValue.Location = new System.Drawing.Point(210, 30);
            this.lblSpeedRateValue.Name = "lblSpeedRateValue";
            this.lblSpeedRateValue.Size = new System.Drawing.Size(70, 15);
            this.lblSpeedRateValue.TabIndex = 2;
            this.lblSpeedRateValue.Text = "+0.0";
            this.lblSpeedRateValue.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // trkSpeedRate
            // 
            this.trkSpeedRate.BackColor = System.Drawing.Color.Transparent;
            this.trkSpeedRate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trkSpeedRate.Location = new System.Drawing.Point(10, 48);
            this.trkSpeedRate.Name = "trkSpeedRate";
            this.trkSpeedRate.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.trkSpeedRate.Size = new System.Drawing.Size(274, 26);
            this.trkSpeedRate.TabIndex = 3;
            this.trkSpeedRate.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.trkSpeedRate.ThumbHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(243)))), ((int)(((byte)(252)))));
            this.trkSpeedRate.TrackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(24)))));
            this.trkSpeedRate.Scroll += new System.EventHandler(this.trkSpeedRate_Scroll);
            this.trkSpeedRate.Click += new System.EventHandler(this.trkSpeedRate_Click);
            // 
            // lblPitchRateText
            // 
            this.lblPitchRateText.AutoSize = true;
            this.lblPitchRateText.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblPitchRateText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.lblPitchRateText.Location = new System.Drawing.Point(10, 88);
            this.lblPitchRateText.Name = "lblPitchRateText";
            this.lblPitchRateText.Size = new System.Drawing.Size(101, 15);
            this.lblPitchRateText.TabIndex = 4;
            this.lblPitchRateText.Text = "🎵 Cao độ (Pitch):";
            // 
            // lblPitchRateValue
            // 
            this.lblPitchRateValue.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblPitchRateValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            this.lblPitchRateValue.Location = new System.Drawing.Point(210, 88);
            this.lblPitchRateValue.Name = "lblPitchRateValue";
            this.lblPitchRateValue.Size = new System.Drawing.Size(70, 15);
            this.lblPitchRateValue.TabIndex = 5;
            this.lblPitchRateValue.Text = "0.0";
            this.lblPitchRateValue.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // trkPitchRate
            // 
            this.trkPitchRate.BackColor = System.Drawing.Color.Transparent;
            this.trkPitchRate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trkPitchRate.Location = new System.Drawing.Point(10, 106);
            this.trkPitchRate.Name = "trkPitchRate";
            this.trkPitchRate.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            this.trkPitchRate.Size = new System.Drawing.Size(274, 26);
            this.trkPitchRate.TabIndex = 6;
            this.trkPitchRate.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.trkPitchRate.ThumbHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(207)))), ((int)(((byte)(232)))));
            this.trkPitchRate.TrackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(24)))));
            this.trkPitchRate.Scroll += new System.EventHandler(this.trkPitchRate_Scroll);
            this.trkPitchRate.Click += new System.EventHandler(this.trkPitchRate_Click);
            // 
            // lblVolumeLevelText
            // 
            this.lblVolumeLevelText.AutoSize = true;
            this.lblVolumeLevelText.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblVolumeLevelText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.lblVolumeLevelText.Location = new System.Drawing.Point(10, 146);
            this.lblVolumeLevelText.Name = "lblVolumeLevelText";
            this.lblVolumeLevelText.Size = new System.Drawing.Size(129, 15);
            this.lblVolumeLevelText.TabIndex = 7;
            this.lblVolumeLevelText.Text = "🔊 Âm lượng (Volume):";
            // 
            // lblVolumeLevelValue
            // 
            this.lblVolumeLevelValue.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblVolumeLevelValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.lblVolumeLevelValue.Location = new System.Drawing.Point(210, 146);
            this.lblVolumeLevelValue.Name = "lblVolumeLevelValue";
            this.lblVolumeLevelValue.Size = new System.Drawing.Size(70, 15);
            this.lblVolumeLevelValue.TabIndex = 8;
            this.lblVolumeLevelValue.Text = "100%";
            this.lblVolumeLevelValue.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // trkVolumeLevel
            // 
            this.trkVolumeLevel.BackColor = System.Drawing.Color.Transparent;
            this.trkVolumeLevel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trkVolumeLevel.LargeChange = 10;
            this.trkVolumeLevel.Location = new System.Drawing.Point(10, 164);
            this.trkVolumeLevel.Maximum = 100;
            this.trkVolumeLevel.Minimum = 0;
            this.trkVolumeLevel.Name = "trkVolumeLevel";
            this.trkVolumeLevel.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.trkVolumeLevel.Size = new System.Drawing.Size(274, 26);
            this.trkVolumeLevel.TabIndex = 9;
            this.trkVolumeLevel.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.trkVolumeLevel.ThumbHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(210)))), ((int)(((byte)(254)))));
            this.trkVolumeLevel.TrackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(24)))));
            this.trkVolumeLevel.Value = 100;
            this.trkVolumeLevel.Scroll += new System.EventHandler(this.trkVolumeLevel_Scroll);
            // 
            // lblGraphicEqTitle
            // 
            this.lblGraphicEqTitle.AutoSize = true;
            this.lblGraphicEqTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblGraphicEqTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(189)))), ((int)(((byte)(248)))));
            this.lblGraphicEqTitle.Location = new System.Drawing.Point(10, 196);
            this.lblGraphicEqTitle.Name = "lblGraphicEqTitle";
            this.lblGraphicEqTitle.Size = new System.Drawing.Size(244, 15);
            this.lblGraphicEqTitle.TabIndex = 10;
            this.lblGraphicEqTitle.Text = "🎛️ 10-Band Graphic Equalizer (31Hz - 16kHz)";
            // 
            // graphicEqControl
            // 
            this.graphicEqControl.BackColor = System.Drawing.Color.Transparent;
            this.graphicEqControl.Location = new System.Drawing.Point(10, 214);
            this.graphicEqControl.Name = "graphicEqControl";
            this.graphicEqControl.Size = new System.Drawing.Size(274, 115);
            this.graphicEqControl.TabIndex = 11;
            this.graphicEqControl.Load += new System.EventHandler(this.graphicEqControl_Load);
            // 
            // cardVoiceCloning
            // 
            this.cardVoiceCloning.BackColor = System.Drawing.Color.Transparent;
            this.cardVoiceCloning.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            this.cardVoiceCloning.Controls.Add(this.lblCloneSectionTitle);
            this.cardVoiceCloning.Controls.Add(this.chkEnableVoiceCloning);
            this.cardVoiceCloning.Controls.Add(this.btnSelectCloneAudio);
            this.cardVoiceCloning.Controls.Add(this.lblCloneAudioStatus);
            this.cardVoiceCloning.Dock = System.Windows.Forms.DockStyle.Top;
            this.cardVoiceCloning.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(34)))));
            this.cardVoiceCloning.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(44)))));
            this.cardVoiceCloning.Location = new System.Drawing.Point(12, 432);
            this.cardVoiceCloning.Name = "cardVoiceCloning";
            this.cardVoiceCloning.Padding = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.cardVoiceCloning.Size = new System.Drawing.Size(292, 110);
            this.cardVoiceCloning.TabIndex = 1;
            // 
            // lblCloneSectionTitle
            // 
            this.lblCloneSectionTitle.AutoSize = true;
            this.lblCloneSectionTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblCloneSectionTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(180)))), ((int)(((byte)(254)))));
            this.lblCloneSectionTitle.Location = new System.Drawing.Point(10, 8);
            this.lblCloneSectionTitle.Name = "lblCloneSectionTitle";
            this.lblCloneSectionTitle.Size = new System.Drawing.Size(159, 15);
            this.lblCloneSectionTitle.TabIndex = 0;
            this.lblCloneSectionTitle.Text = "🧬 Voice Cloning (Nhân Bản)";
            // 
            // chkEnableVoiceCloning
            // 
            this.chkEnableVoiceCloning.AutoSize = true;
            this.chkEnableVoiceCloning.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F);
            this.chkEnableVoiceCloning.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.chkEnableVoiceCloning.Location = new System.Drawing.Point(10, 28);
            this.chkEnableVoiceCloning.Name = "chkEnableVoiceCloning";
            this.chkEnableVoiceCloning.Size = new System.Drawing.Size(186, 19);
            this.chkEnableVoiceCloning.TabIndex = 1;
            this.chkEnableVoiceCloning.Text = "Bật Chế Độ Clone Giọng Riêng";
            this.chkEnableVoiceCloning.UseVisualStyleBackColor = true;
            this.chkEnableVoiceCloning.CheckedChanged += new System.EventHandler(this.chkEnableVoiceCloning_CheckedChanged);
            // 
            // btnSelectCloneAudio
            // 
            this.btnSelectCloneAudio.BackColor = System.Drawing.Color.Transparent;
            this.btnSelectCloneAudio.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(132)))), ((int)(((byte)(252)))));
            this.btnSelectCloneAudio.BorderRadius = 10;
            this.btnSelectCloneAudio.BorderSize = 1;
            this.btnSelectCloneAudio.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(34)))), ((int)(((byte)(206)))));
            this.btnSelectCloneAudio.ClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(28)))), ((int)(((byte)(135)))));
            this.btnSelectCloneAudio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelectCloneAudio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectCloneAudio.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnSelectCloneAudio.ForeColor = System.Drawing.Color.White;
            this.btnSelectCloneAudio.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(51)))), ((int)(((byte)(234)))));
            this.btnSelectCloneAudio.Location = new System.Drawing.Point(10, 50);
            this.btnSelectCloneAudio.Name = "btnSelectCloneAudio";
            this.btnSelectCloneAudio.Size = new System.Drawing.Size(274, 32);
            this.btnSelectCloneAudio.TabIndex = 2;
            this.btnSelectCloneAudio.Text = "🎙️ Nạp Mẫu Giọng (.wav / .mp3)";
            this.btnSelectCloneAudio.UseVisualStyleBackColor = false;
            this.btnSelectCloneAudio.Click += new System.EventHandler(this.btnSelectCloneAudio_Click);
            // 
            // lblCloneAudioStatus
            // 
            this.lblCloneAudioStatus.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.lblCloneAudioStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(180)))), ((int)(((byte)(254)))));
            this.lblCloneAudioStatus.Location = new System.Drawing.Point(10, 86);
            this.lblCloneAudioStatus.Name = "lblCloneAudioStatus";
            this.lblCloneAudioStatus.Size = new System.Drawing.Size(274, 18);
            this.lblCloneAudioStatus.TabIndex = 3;
            this.lblCloneAudioStatus.Text = "Chưa chọn file mẫu giọng";
            // 
            // cardVoiceSelection
            // 
            this.cardVoiceSelection.BackColor = System.Drawing.Color.Transparent;
            this.cardVoiceSelection.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(72)))));
            this.cardVoiceSelection.Controls.Add(this.lblEngineTitle);
            this.cardVoiceSelection.Controls.Add(this.pnlEngineSegment);
            this.cardVoiceSelection.Controls.Add(this.lblVoiceSectionTitle);
            this.cardVoiceSelection.Controls.Add(this.cboVoiceSelection);
            this.cardVoiceSelection.Controls.Add(this.lblTimbreTitle);
            this.cardVoiceSelection.Controls.Add(this.pnlTimbreSegment);
            this.cardVoiceSelection.Controls.Add(this.lblDurationTitle);
            this.cardVoiceSelection.Controls.Add(this.pnlDurationSegment);
            this.cardVoiceSelection.Controls.Add(this.lblPitchTuningTitle);
            this.cardVoiceSelection.Controls.Add(this.pnlPitchSegment);
            this.cardVoiceSelection.Controls.Add(this.lblStyleSectionTitle);
            this.cardVoiceSelection.Controls.Add(this.pnlStyleSegment);
            this.cardVoiceSelection.Controls.Add(this.lblVoiceDetails);
            this.cardVoiceSelection.Dock = System.Windows.Forms.DockStyle.Top;
            this.cardVoiceSelection.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(34)))));
            this.cardVoiceSelection.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(44)))));
            this.cardVoiceSelection.Location = new System.Drawing.Point(12, 12);
            this.cardVoiceSelection.Name = "cardVoiceSelection";
            this.cardVoiceSelection.Padding = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.cardVoiceSelection.Size = new System.Drawing.Size(292, 420);
            this.cardVoiceSelection.TabIndex = 0;
            // 
            // lblEngineTitle
            // 
            this.lblEngineTitle.AutoSize = true;
            this.lblEngineTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblEngineTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(185)))), ((int)(((byte)(200)))));
            this.lblEngineTitle.Location = new System.Drawing.Point(10, 8);
            this.lblEngineTitle.Name = "lblEngineTitle";
            this.lblEngineTitle.Size = new System.Drawing.Size(117, 15);
            this.lblEngineTitle.TabIndex = 0;
            this.lblEngineTitle.Text = "⚙️ Chọn TTS Engine:";
            // 
            // pnlEngineSegment
            // 
            this.pnlEngineSegment.Controls.Add(this.btnEngineVieNeu);
            this.pnlEngineSegment.Controls.Add(this.btnEngineSapi);
            this.pnlEngineSegment.Location = new System.Drawing.Point(10, 24);
            this.pnlEngineSegment.Name = "pnlEngineSegment";
            this.pnlEngineSegment.Size = new System.Drawing.Size(274, 28);
            this.pnlEngineSegment.TabIndex = 1;
            this.pnlEngineSegment.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlEngineSegment_Paint);
            // 
            // btnEngineVieNeu
            // 
            this.btnEngineVieNeu.BackColor = System.Drawing.Color.Transparent;
            this.btnEngineVieNeu.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(189)))), ((int)(((byte)(248)))));
            this.btnEngineVieNeu.BorderRadius = 8;
            this.btnEngineVieNeu.BorderSize = 1;
            this.btnEngineVieNeu.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(116)))), ((int)(((byte)(144)))));
            this.btnEngineVieNeu.ClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(56)))), ((int)(((byte)(202)))));
            this.btnEngineVieNeu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEngineVieNeu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEngineVieNeu.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.btnEngineVieNeu.ForeColor = System.Drawing.Color.White;
            this.btnEngineVieNeu.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(182)))), ((int)(((byte)(212)))));
            this.btnEngineVieNeu.Location = new System.Drawing.Point(0, 0);
            this.btnEngineVieNeu.Margin = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.btnEngineVieNeu.Name = "btnEngineVieNeu";
            this.btnEngineVieNeu.Size = new System.Drawing.Size(132, 26);
            this.btnEngineVieNeu.TabIndex = 0;
            this.btnEngineVieNeu.Text = "🦜 VieNeu AI (48k)";
            this.btnEngineVieNeu.UseVisualStyleBackColor = false;
            this.btnEngineVieNeu.Click += new System.EventHandler(this.btnEngineVieNeu_Click);
            // 
            // btnEngineSapi
            // 
            this.btnEngineSapi.BackColor = System.Drawing.Color.Transparent;
            this.btnEngineSapi.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.btnEngineSapi.BorderRadius = 8;
            this.btnEngineSapi.BorderSize = 1;
            this.btnEngineSapi.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.btnEngineSapi.ClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(56)))), ((int)(((byte)(202)))));
            this.btnEngineSapi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEngineSapi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEngineSapi.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.btnEngineSapi.ForeColor = System.Drawing.Color.White;
            this.btnEngineSapi.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.btnEngineSapi.Location = new System.Drawing.Point(136, 0);
            this.btnEngineSapi.Margin = new System.Windows.Forms.Padding(0);
            this.btnEngineSapi.Name = "btnEngineSapi";
            this.btnEngineSapi.Size = new System.Drawing.Size(132, 26);
            this.btnEngineSapi.TabIndex = 1;
            this.btnEngineSapi.Text = "🔊 Windows SAPI5";
            this.btnEngineSapi.UseVisualStyleBackColor = false;
            this.btnEngineSapi.Click += new System.EventHandler(this.btnEngineSapi_Click);
            // 
            // lblVoiceSectionTitle
            // 
            this.lblVoiceSectionTitle.AutoSize = true;
            this.lblVoiceSectionTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblVoiceSectionTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.lblVoiceSectionTitle.Location = new System.Drawing.Point(10, 56);
            this.lblVoiceSectionTitle.Name = "lblVoiceSectionTitle";
            this.lblVoiceSectionTitle.Size = new System.Drawing.Size(114, 15);
            this.lblVoiceSectionTitle.TabIndex = 2;
            this.lblVoiceSectionTitle.Text = "🗣️ Chọn Giọng Đọc:";
            // 
            // cboVoiceSelection
            // 
            this.cboVoiceSelection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(24)))));
            this.cboVoiceSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVoiceSelection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboVoiceSelection.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.cboVoiceSelection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.cboVoiceSelection.FormattingEnabled = true;
            this.cboVoiceSelection.Location = new System.Drawing.Point(10, 72);
            this.cboVoiceSelection.Name = "cboVoiceSelection";
            this.cboVoiceSelection.Size = new System.Drawing.Size(274, 21);
            this.cboVoiceSelection.TabIndex = 3;
            this.cboVoiceSelection.SelectedIndexChanged += new System.EventHandler(this.cboVoiceSelection_SelectedIndexChanged);
            // 
            // lblTimbreTitle
            // 
            this.lblTimbreTitle.AutoSize = true;
            this.lblTimbreTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 8F);
            this.lblTimbreTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.lblTimbreTitle.Location = new System.Drawing.Point(10, 96);
            this.lblTimbreTitle.Name = "lblTimbreTitle";
            this.lblTimbreTitle.Size = new System.Drawing.Size(117, 13);
            this.lblTimbreTitle.TabIndex = 4;
            this.lblTimbreTitle.Text = "🎙️ Sắc Độ & Âm Giọng:";
            // 
            // pnlTimbreSegment
            // 
            this.pnlTimbreSegment.Controls.Add(this.btnTimbreStandard);
            this.pnlTimbreSegment.Controls.Add(this.btnTimbreRadio);
            this.pnlTimbreSegment.Controls.Add(this.btnTimbreWarm);
            this.pnlTimbreSegment.Controls.Add(this.btnTimbreBright);
            this.pnlTimbreSegment.Controls.Add(this.btnTimbreReverb);
            this.pnlTimbreSegment.Location = new System.Drawing.Point(10, 111);
            this.pnlTimbreSegment.Name = "pnlTimbreSegment";
            this.pnlTimbreSegment.Size = new System.Drawing.Size(274, 52);
            this.pnlTimbreSegment.TabIndex = 5;
            // 
            // btnTimbreStandard
            // 
            this.btnTimbreStandard.BackColor = System.Drawing.Color.Transparent;
            this.btnTimbreStandard.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(189)))), ((int)(((byte)(248)))));
            this.btnTimbreStandard.BorderRadius = 6;
            this.btnTimbreStandard.BorderSize = 1;
            this.btnTimbreStandard.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(116)))), ((int)(((byte)(144)))));
            this.btnTimbreStandard.ClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(56)))), ((int)(((byte)(202)))));
            this.btnTimbreStandard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimbreStandard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimbreStandard.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.btnTimbreStandard.ForeColor = System.Drawing.Color.White;
            this.btnTimbreStandard.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.btnTimbreStandard.Location = new System.Drawing.Point(0, 0);
            this.btnTimbreStandard.Margin = new System.Windows.Forms.Padding(0, 0, 4, 4);
            this.btnTimbreStandard.Name = "btnTimbreStandard";
            this.btnTimbreStandard.Size = new System.Drawing.Size(86, 22);
            this.btnTimbreStandard.TabIndex = 0;
            this.btnTimbreStandard.Text = "🎙️ Mộc";
            this.btnTimbreStandard.UseVisualStyleBackColor = false;
            this.btnTimbreStandard.Click += new System.EventHandler(this.ChipTimbre_Click);
            // 
            // btnTimbreRadio
            // 
            this.btnTimbreRadio.BackColor = System.Drawing.Color.Transparent;
            this.btnTimbreRadio.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.btnTimbreRadio.BorderRadius = 6;
            this.btnTimbreRadio.BorderSize = 1;
            this.btnTimbreRadio.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.btnTimbreRadio.ClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(56)))), ((int)(((byte)(202)))));
            this.btnTimbreRadio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimbreRadio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimbreRadio.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.btnTimbreRadio.ForeColor = System.Drawing.Color.White;
            this.btnTimbreRadio.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.btnTimbreRadio.Location = new System.Drawing.Point(90, 0);
            this.btnTimbreRadio.Margin = new System.Windows.Forms.Padding(0, 0, 4, 4);
            this.btnTimbreRadio.Name = "btnTimbreRadio";
            this.btnTimbreRadio.Size = new System.Drawing.Size(86, 22);
            this.btnTimbreRadio.TabIndex = 1;
            this.btnTimbreRadio.Text = "📻 Radio";
            this.btnTimbreRadio.UseVisualStyleBackColor = false;
            this.btnTimbreRadio.Click += new System.EventHandler(this.ChipTimbre_Click);
            // 
            // btnTimbreWarm
            // 
            this.btnTimbreWarm.BackColor = System.Drawing.Color.Transparent;
            this.btnTimbreWarm.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.btnTimbreWarm.BorderRadius = 6;
            this.btnTimbreWarm.BorderSize = 1;
            this.btnTimbreWarm.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.btnTimbreWarm.ClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(56)))), ((int)(((byte)(202)))));
            this.btnTimbreWarm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimbreWarm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimbreWarm.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.btnTimbreWarm.ForeColor = System.Drawing.Color.White;
            this.btnTimbreWarm.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.btnTimbreWarm.Location = new System.Drawing.Point(180, 0);
            this.btnTimbreWarm.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.btnTimbreWarm.Name = "btnTimbreWarm";
            this.btnTimbreWarm.Size = new System.Drawing.Size(90, 22);
            this.btnTimbreWarm.TabIndex = 2;
            this.btnTimbreWarm.Text = "🔊 Warm Bass";
            this.btnTimbreWarm.UseVisualStyleBackColor = false;
            this.btnTimbreWarm.Click += new System.EventHandler(this.ChipTimbre_Click);
            // 
            // btnTimbreBright
            // 
            this.btnTimbreBright.BackColor = System.Drawing.Color.Transparent;
            this.btnTimbreBright.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.btnTimbreBright.BorderRadius = 6;
            this.btnTimbreBright.BorderSize = 1;
            this.btnTimbreBright.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.btnTimbreBright.ClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(56)))), ((int)(((byte)(202)))));
            this.btnTimbreBright.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimbreBright.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimbreBright.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.btnTimbreBright.ForeColor = System.Drawing.Color.White;
            this.btnTimbreBright.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.btnTimbreBright.Location = new System.Drawing.Point(0, 26);
            this.btnTimbreBright.Margin = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.btnTimbreBright.Name = "btnTimbreBright";
            this.btnTimbreBright.Size = new System.Drawing.Size(132, 22);
            this.btnTimbreBright.TabIndex = 3;
            this.btnTimbreBright.Text = "✨ Bright Clarity";
            this.btnTimbreBright.UseVisualStyleBackColor = false;
            this.btnTimbreBright.Click += new System.EventHandler(this.ChipTimbre_Click);
            // 
            // btnTimbreReverb
            // 
            this.btnTimbreReverb.BackColor = System.Drawing.Color.Transparent;
            this.btnTimbreReverb.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.btnTimbreReverb.BorderRadius = 6;
            this.btnTimbreReverb.BorderSize = 1;
            this.btnTimbreReverb.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.btnTimbreReverb.ClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(56)))), ((int)(((byte)(202)))));
            this.btnTimbreReverb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimbreReverb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimbreReverb.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.btnTimbreReverb.ForeColor = System.Drawing.Color.White;
            this.btnTimbreReverb.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.btnTimbreReverb.Location = new System.Drawing.Point(136, 26);
            this.btnTimbreReverb.Margin = new System.Windows.Forms.Padding(0);
            this.btnTimbreReverb.Name = "btnTimbreReverb";
            this.btnTimbreReverb.Size = new System.Drawing.Size(134, 22);
            this.btnTimbreReverb.TabIndex = 4;
            this.btnTimbreReverb.Text = "🏛️ Studio Hall";
            this.btnTimbreReverb.UseVisualStyleBackColor = false;
            this.btnTimbreReverb.Click += new System.EventHandler(this.ChipTimbre_Click);
            // 
            // lblDurationTitle
            // 
            this.lblDurationTitle.AutoSize = true;
            this.lblDurationTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 8F);
            this.lblDurationTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.lblDurationTitle.Location = new System.Drawing.Point(10, 168);
            this.lblDurationTitle.Name = "lblDurationTitle";
            this.lblDurationTitle.Size = new System.Drawing.Size(159, 13);
            this.lblDurationTitle.TabIndex = 6;
            this.lblDurationTitle.Text = "⏱️ Trường Độ & Nhịp Ngắt Câu:";
            // 
            // pnlDurationSegment
            // 
            this.pnlDurationSegment.Controls.Add(this.btnDurationStandard);
            this.pnlDurationSegment.Controls.Add(this.btnDurationShort);
            this.pnlDurationSegment.Controls.Add(this.btnDurationLong);
            this.pnlDurationSegment.Location = new System.Drawing.Point(10, 183);
            this.pnlDurationSegment.Name = "pnlDurationSegment";
            this.pnlDurationSegment.Size = new System.Drawing.Size(274, 26);
            this.pnlDurationSegment.TabIndex = 7;
            // 
            // btnDurationStandard
            // 
            this.btnDurationStandard.BackColor = System.Drawing.Color.Transparent;
            this.btnDurationStandard.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(189)))), ((int)(((byte)(248)))));
            this.btnDurationStandard.BorderRadius = 6;
            this.btnDurationStandard.BorderSize = 1;
            this.btnDurationStandard.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(116)))), ((int)(((byte)(144)))));
            this.btnDurationStandard.ClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(56)))), ((int)(((byte)(202)))));
            this.btnDurationStandard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDurationStandard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDurationStandard.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.btnDurationStandard.ForeColor = System.Drawing.Color.White;
            this.btnDurationStandard.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.btnDurationStandard.Location = new System.Drawing.Point(0, 0);
            this.btnDurationStandard.Margin = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.btnDurationStandard.Name = "btnDurationStandard";
            this.btnDurationStandard.Size = new System.Drawing.Size(86, 22);
            this.btnDurationStandard.TabIndex = 0;
            this.btnDurationStandard.Text = "⏱️ Chuẩn";
            this.btnDurationStandard.UseVisualStyleBackColor = false;
            this.btnDurationStandard.Click += new System.EventHandler(this.ChipDuration_Click);
            // 
            // btnDurationShort
            // 
            this.btnDurationShort.BackColor = System.Drawing.Color.Transparent;
            this.btnDurationShort.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.btnDurationShort.BorderRadius = 6;
            this.btnDurationShort.BorderSize = 1;
            this.btnDurationShort.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.btnDurationShort.ClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(56)))), ((int)(((byte)(202)))));
            this.btnDurationShort.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDurationShort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDurationShort.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.btnDurationShort.ForeColor = System.Drawing.Color.White;
            this.btnDurationShort.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.btnDurationShort.Location = new System.Drawing.Point(90, 0);
            this.btnDurationShort.Margin = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.btnDurationShort.Name = "btnDurationShort";
            this.btnDurationShort.Size = new System.Drawing.Size(86, 22);
            this.btnDurationShort.TabIndex = 1;
            this.btnDurationShort.Text = "⚡ Nhanh (-0.3s)";
            this.btnDurationShort.UseVisualStyleBackColor = false;
            this.btnDurationShort.Click += new System.EventHandler(this.ChipDuration_Click);
            // 
            // btnDurationLong
            // 
            this.btnDurationLong.BackColor = System.Drawing.Color.Transparent;
            this.btnDurationLong.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.btnDurationLong.BorderRadius = 6;
            this.btnDurationLong.BorderSize = 1;
            this.btnDurationLong.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.btnDurationLong.ClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(56)))), ((int)(((byte)(202)))));
            this.btnDurationLong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDurationLong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDurationLong.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.btnDurationLong.ForeColor = System.Drawing.Color.White;
            this.btnDurationLong.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.btnDurationLong.Location = new System.Drawing.Point(180, 0);
            this.btnDurationLong.Margin = new System.Windows.Forms.Padding(0);
            this.btnDurationLong.Name = "btnDurationLong";
            this.btnDurationLong.Size = new System.Drawing.Size(90, 22);
            this.btnDurationLong.TabIndex = 2;
            this.btnDurationLong.Text = "☕ Dài (+0.5s)";
            this.btnDurationLong.UseVisualStyleBackColor = false;
            this.btnDurationLong.Click += new System.EventHandler(this.ChipDuration_Click);
            // 
            // lblPitchTuningTitle
            // 
            this.lblPitchTuningTitle.AutoSize = true;
            this.lblPitchTuningTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 8F);
            this.lblPitchTuningTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.lblPitchTuningTitle.Location = new System.Drawing.Point(10, 214);
            this.lblPitchTuningTitle.Name = "lblPitchTuningTitle";
            this.lblPitchTuningTitle.Size = new System.Drawing.Size(167, 13);
            this.lblPitchTuningTitle.TabIndex = 8;
            this.lblPitchTuningTitle.Text = "🎼 Cao Giọng (Semitones / Hz):";
            // 
            // pnlPitchSegment
            // 
            this.pnlPitchSegment.Controls.Add(this.btnPitchDeep);
            this.pnlPitchSegment.Controls.Add(this.btnPitchLow);
            this.pnlPitchSegment.Controls.Add(this.btnPitchNormal);
            this.pnlPitchSegment.Controls.Add(this.btnPitchHigh);
            this.pnlPitchSegment.Controls.Add(this.btnPitchBright);
            this.pnlPitchSegment.Location = new System.Drawing.Point(10, 229);
            this.pnlPitchSegment.Name = "pnlPitchSegment";
            this.pnlPitchSegment.Size = new System.Drawing.Size(274, 52);
            this.pnlPitchSegment.TabIndex = 9;
            // 
            // btnPitchDeep
            // 
            this.btnPitchDeep.BackColor = System.Drawing.Color.Transparent;
            this.btnPitchDeep.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.btnPitchDeep.BorderRadius = 6;
            this.btnPitchDeep.BorderSize = 1;
            this.btnPitchDeep.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.btnPitchDeep.ClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(56)))), ((int)(((byte)(202)))));
            this.btnPitchDeep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPitchDeep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPitchDeep.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.btnPitchDeep.ForeColor = System.Drawing.Color.White;
            this.btnPitchDeep.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.btnPitchDeep.Location = new System.Drawing.Point(0, 0);
            this.btnPitchDeep.Margin = new System.Windows.Forms.Padding(0, 0, 4, 4);
            this.btnPitchDeep.Name = "btnPitchDeep";
            this.btnPitchDeep.Size = new System.Drawing.Size(86, 22);
            this.btnPitchDeep.TabIndex = 0;
            this.btnPitchDeep.Text = "🎻 -4 ST";
            this.btnPitchDeep.UseVisualStyleBackColor = false;
            this.btnPitchDeep.Click += new System.EventHandler(this.ChipPitch_Click);
            // 
            // btnPitchLow
            // 
            this.btnPitchLow.BackColor = System.Drawing.Color.Transparent;
            this.btnPitchLow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.btnPitchLow.BorderRadius = 6;
            this.btnPitchLow.BorderSize = 1;
            this.btnPitchLow.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.btnPitchLow.ClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(56)))), ((int)(((byte)(202)))));
            this.btnPitchLow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPitchLow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPitchLow.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.btnPitchLow.ForeColor = System.Drawing.Color.White;
            this.btnPitchLow.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.btnPitchLow.Location = new System.Drawing.Point(90, 0);
            this.btnPitchLow.Margin = new System.Windows.Forms.Padding(0, 0, 4, 4);
            this.btnPitchLow.Name = "btnPitchLow";
            this.btnPitchLow.Size = new System.Drawing.Size(86, 22);
            this.btnPitchLow.TabIndex = 1;
            this.btnPitchLow.Text = "🎷 -2 ST";
            this.btnPitchLow.UseVisualStyleBackColor = false;
            this.btnPitchLow.Click += new System.EventHandler(this.ChipPitch_Click);
            // 
            // btnPitchNormal
            // 
            this.btnPitchNormal.BackColor = System.Drawing.Color.Transparent;
            this.btnPitchNormal.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(189)))), ((int)(((byte)(248)))));
            this.btnPitchNormal.BorderRadius = 6;
            this.btnPitchNormal.BorderSize = 1;
            this.btnPitchNormal.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(116)))), ((int)(((byte)(144)))));
            this.btnPitchNormal.ClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(56)))), ((int)(((byte)(202)))));
            this.btnPitchNormal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPitchNormal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPitchNormal.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.btnPitchNormal.ForeColor = System.Drawing.Color.White;
            this.btnPitchNormal.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.btnPitchNormal.Location = new System.Drawing.Point(180, 0);
            this.btnPitchNormal.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.btnPitchNormal.Name = "btnPitchNormal";
            this.btnPitchNormal.Size = new System.Drawing.Size(90, 22);
            this.btnPitchNormal.TabIndex = 2;
            this.btnPitchNormal.Text = "🎼 0 ST";
            this.btnPitchNormal.UseVisualStyleBackColor = false;
            this.btnPitchNormal.Click += new System.EventHandler(this.ChipPitch_Click);
            // 
            // btnPitchHigh
            // 
            this.btnPitchHigh.BackColor = System.Drawing.Color.Transparent;
            this.btnPitchHigh.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.btnPitchHigh.BorderRadius = 6;
            this.btnPitchHigh.BorderSize = 1;
            this.btnPitchHigh.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.btnPitchHigh.ClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(56)))), ((int)(((byte)(202)))));
            this.btnPitchHigh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPitchHigh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPitchHigh.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.btnPitchHigh.ForeColor = System.Drawing.Color.White;
            this.btnPitchHigh.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.btnPitchHigh.Location = new System.Drawing.Point(0, 26);
            this.btnPitchHigh.Margin = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.btnPitchHigh.Name = "btnPitchHigh";
            this.btnPitchHigh.Size = new System.Drawing.Size(132, 22);
            this.btnPitchHigh.TabIndex = 3;
            this.btnPitchHigh.Text = "🎺 +2 ST (Nữ cao)";
            this.btnPitchHigh.UseVisualStyleBackColor = false;
            this.btnPitchHigh.Click += new System.EventHandler(this.ChipPitch_Click);
            // 
            // btnPitchBright
            // 
            this.btnPitchBright.BackColor = System.Drawing.Color.Transparent;
            this.btnPitchBright.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.btnPitchBright.BorderRadius = 6;
            this.btnPitchBright.BorderSize = 1;
            this.btnPitchBright.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.btnPitchBright.ClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(56)))), ((int)(((byte)(202)))));
            this.btnPitchBright.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPitchBright.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPitchBright.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.btnPitchBright.ForeColor = System.Drawing.Color.White;
            this.btnPitchBright.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.btnPitchBright.Location = new System.Drawing.Point(136, 26);
            this.btnPitchBright.Margin = new System.Windows.Forms.Padding(0);
            this.btnPitchBright.Name = "btnPitchBright";
            this.btnPitchBright.Size = new System.Drawing.Size(134, 22);
            this.btnPitchBright.TabIndex = 4;
            this.btnPitchBright.Text = "🔔 +4 ST (Thanh)";
            this.btnPitchBright.UseVisualStyleBackColor = false;
            this.btnPitchBright.Click += new System.EventHandler(this.ChipPitch_Click);
            // 
            // lblStyleSectionTitle
            // 
            this.lblStyleSectionTitle.AutoSize = true;
            this.lblStyleSectionTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblStyleSectionTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.lblStyleSectionTitle.Location = new System.Drawing.Point(10, 286);
            this.lblStyleSectionTitle.Name = "lblStyleSectionTitle";
            this.lblStyleSectionTitle.Size = new System.Drawing.Size(152, 15);
            this.lblStyleSectionTitle.TabIndex = 10;
            this.lblStyleSectionTitle.Text = "🎭 Phong Cách Đọc (Style):";
            // 
            // pnlStyleSegment
            // 
            this.pnlStyleSegment.Controls.Add(this.btnStyleNatural);
            this.pnlStyleSegment.Controls.Add(this.btnStyleNews);
            this.pnlStyleSegment.Controls.Add(this.btnStyleStory);
            this.pnlStyleSegment.Controls.Add(this.btnStyleDrama);
            this.pnlStyleSegment.Location = new System.Drawing.Point(10, 302);
            this.pnlStyleSegment.Name = "pnlStyleSegment";
            this.pnlStyleSegment.Size = new System.Drawing.Size(274, 52);
            this.pnlStyleSegment.TabIndex = 11;
            // 
            // btnStyleNatural
            // 
            this.btnStyleNatural.BackColor = System.Drawing.Color.Transparent;
            this.btnStyleNatural.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(189)))), ((int)(((byte)(248)))));
            this.btnStyleNatural.BorderRadius = 6;
            this.btnStyleNatural.BorderSize = 1;
            this.btnStyleNatural.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(116)))), ((int)(((byte)(144)))));
            this.btnStyleNatural.ClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(56)))), ((int)(((byte)(202)))));
            this.btnStyleNatural.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStyleNatural.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStyleNatural.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.btnStyleNatural.ForeColor = System.Drawing.Color.White;
            this.btnStyleNatural.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.btnStyleNatural.Location = new System.Drawing.Point(0, 0);
            this.btnStyleNatural.Margin = new System.Windows.Forms.Padding(0, 0, 4, 4);
            this.btnStyleNatural.Name = "btnStyleNatural";
            this.btnStyleNatural.Size = new System.Drawing.Size(132, 22);
            this.btnStyleNatural.TabIndex = 0;
            this.btnStyleNatural.Text = "🌿 Tự nhiên";
            this.btnStyleNatural.UseVisualStyleBackColor = false;
            this.btnStyleNatural.Click += new System.EventHandler(this.ChipStyle_Click);
            // 
            // btnStyleNews
            // 
            this.btnStyleNews.BackColor = System.Drawing.Color.Transparent;
            this.btnStyleNews.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.btnStyleNews.BorderRadius = 6;
            this.btnStyleNews.BorderSize = 1;
            this.btnStyleNews.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.btnStyleNews.ClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(56)))), ((int)(((byte)(202)))));
            this.btnStyleNews.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStyleNews.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStyleNews.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.btnStyleNews.ForeColor = System.Drawing.Color.White;
            this.btnStyleNews.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.btnStyleNews.Location = new System.Drawing.Point(136, 0);
            this.btnStyleNews.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.btnStyleNews.Name = "btnStyleNews";
            this.btnStyleNews.Size = new System.Drawing.Size(134, 22);
            this.btnStyleNews.TabIndex = 1;
            this.btnStyleNews.Text = "📰 Tin tức";
            this.btnStyleNews.UseVisualStyleBackColor = false;
            this.btnStyleNews.Click += new System.EventHandler(this.ChipStyle_Click);
            // 
            // btnStyleStory
            // 
            this.btnStyleStory.BackColor = System.Drawing.Color.Transparent;
            this.btnStyleStory.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.btnStyleStory.BorderRadius = 6;
            this.btnStyleStory.BorderSize = 1;
            this.btnStyleStory.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.btnStyleStory.ClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(56)))), ((int)(((byte)(202)))));
            this.btnStyleStory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStyleStory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStyleStory.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.btnStyleStory.ForeColor = System.Drawing.Color.White;
            this.btnStyleStory.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.btnStyleStory.Location = new System.Drawing.Point(0, 26);
            this.btnStyleStory.Margin = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.btnStyleStory.Name = "btnStyleStory";
            this.btnStyleStory.Size = new System.Drawing.Size(132, 22);
            this.btnStyleStory.TabIndex = 2;
            this.btnStyleStory.Text = "📖 Đọc truyện";
            this.btnStyleStory.UseVisualStyleBackColor = false;
            this.btnStyleStory.Click += new System.EventHandler(this.ChipStyle_Click);
            // 
            // btnStyleDrama
            // 
            this.btnStyleDrama.BackColor = System.Drawing.Color.Transparent;
            this.btnStyleDrama.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.btnStyleDrama.BorderRadius = 6;
            this.btnStyleDrama.BorderSize = 1;
            this.btnStyleDrama.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.btnStyleDrama.ClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(56)))), ((int)(((byte)(202)))));
            this.btnStyleDrama.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStyleDrama.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStyleDrama.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.btnStyleDrama.ForeColor = System.Drawing.Color.White;
            this.btnStyleDrama.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.btnStyleDrama.Location = new System.Drawing.Point(136, 26);
            this.btnStyleDrama.Margin = new System.Windows.Forms.Padding(0);
            this.btnStyleDrama.Name = "btnStyleDrama";
            this.btnStyleDrama.Size = new System.Drawing.Size(134, 22);
            this.btnStyleDrama.TabIndex = 3;
            this.btnStyleDrama.Text = "🎭 Kịch nghệ";
            this.btnStyleDrama.UseVisualStyleBackColor = false;
            this.btnStyleDrama.Click += new System.EventHandler(this.ChipStyle_Click);
            // 
            // lblVoiceDetails
            // 
            this.lblVoiceDetails.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblVoiceDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblVoiceDetails.Location = new System.Drawing.Point(10, 360);
            this.lblVoiceDetails.Name = "lblVoiceDetails";
            this.lblVoiceDetails.Size = new System.Drawing.Size(274, 50);
            this.lblVoiceDetails.TabIndex = 12;
            this.lblVoiceDetails.Text = "Ngôn ngữ: Tiếng Việt (VieNeu-TTS)\nChế độ: AI Local Offline 48kHz Chip Selected";
            this.lblVoiceDetails.Click += new System.EventHandler(this.lblVoiceDetails_Click);
            // 
            // pnlCenterEditorContainer
            // 
            this.pnlCenterEditorContainer.Controls.Add(this.cardTextEditor);
            this.pnlCenterEditorContainer.Controls.Add(this.cardPlaybackStatus);
            this.pnlCenterEditorContainer.Controls.Add(this.pnlActionButtonsContainer);
            this.pnlCenterEditorContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCenterEditorContainer.Location = new System.Drawing.Point(333, 126);
            this.pnlCenterEditorContainer.Name = "pnlCenterEditorContainer";
            this.pnlCenterEditorContainer.Padding = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.pnlCenterEditorContainer.Size = new System.Drawing.Size(656, 559);
            this.pnlCenterEditorContainer.TabIndex = 2;
            this.pnlCenterEditorContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCenterEditorContainer_Paint);
            // 
            // cardTextEditor
            // 
            this.cardTextEditor.BackColor = System.Drawing.Color.Transparent;
            this.cardTextEditor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(72)))));
            this.cardTextEditor.Controls.Add(this.txtInputContent);
            this.cardTextEditor.Controls.Add(this.pnlTextEditorFooter);
            this.cardTextEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardTextEditor.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(34)))));
            this.cardTextEditor.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(44)))));
            this.cardTextEditor.Location = new System.Drawing.Point(12, 12);
            this.cardTextEditor.Name = "cardTextEditor";
            this.cardTextEditor.Padding = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.cardTextEditor.Size = new System.Drawing.Size(632, 376);
            this.cardTextEditor.TabIndex = 0;
            // 
            // txtInputContent
            // 
            this.txtInputContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(24)))));
            this.txtInputContent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInputContent.ContextMenuStrip = this.txtContextMenu;
            this.txtInputContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtInputContent.Font = new System.Drawing.Font("Segoe UI", 11.5F);
            this.txtInputContent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.txtInputContent.Location = new System.Drawing.Point(12, 12);
            this.txtInputContent.Multiline = true;
            this.txtInputContent.Name = "txtInputContent";
            this.txtInputContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInputContent.Size = new System.Drawing.Size(608, 324);
            this.txtInputContent.TabIndex = 0;
            this.txtInputContent.TextChanged += new System.EventHandler(this.txtInputContent_TextChanged);
            // 
            // pnlTextEditorFooter
            // 
            this.pnlTextEditorFooter.BackColor = System.Drawing.Color.Transparent;
            this.pnlTextEditorFooter.Controls.Add(this.lblEmotionTag1);
            this.pnlTextEditorFooter.Controls.Add(this.lblEmotionTag2);
            this.pnlTextEditorFooter.Controls.Add(this.lblEmotionTag3);
            this.pnlTextEditorFooter.Controls.Add(this.lblEmotionTag4);
            this.pnlTextEditorFooter.Controls.Add(this.lblCharAndWordCount);
            this.pnlTextEditorFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlTextEditorFooter.Location = new System.Drawing.Point(12, 336);
            this.pnlTextEditorFooter.Name = "pnlTextEditorFooter";
            this.pnlTextEditorFooter.Size = new System.Drawing.Size(608, 28);
            this.pnlTextEditorFooter.TabIndex = 1;
            this.pnlTextEditorFooter.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTextEditorFooter_Paint);
            // 
            // lblEmotionTag1
            // 
            this.lblEmotionTag1.AutoSize = true;
            this.lblEmotionTag1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblEmotionTag1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblEmotionTag1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(185)))), ((int)(((byte)(200)))));
            this.lblEmotionTag1.Location = new System.Drawing.Point(4, 6);
            this.lblEmotionTag1.Name = "lblEmotionTag1";
            this.lblEmotionTag1.Size = new System.Drawing.Size(49, 15);
            this.lblEmotionTag1.TabIndex = 0;
            this.lblEmotionTag1.Text = "+ [cười]";
            this.lblEmotionTag1.Click += new System.EventHandler(this.lblEmotionTag_Click);
            // 
            // lblEmotionTag2
            // 
            this.lblEmotionTag2.AutoSize = true;
            this.lblEmotionTag2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblEmotionTag2.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblEmotionTag2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(185)))), ((int)(((byte)(200)))));
            this.lblEmotionTag2.Location = new System.Drawing.Point(52, 6);
            this.lblEmotionTag2.Name = "lblEmotionTag2";
            this.lblEmotionTag2.Size = new System.Drawing.Size(63, 15);
            this.lblEmotionTag2.TabIndex = 1;
            this.lblEmotionTag2.Text = "+ [thở dài]";
            this.lblEmotionTag2.Click += new System.EventHandler(this.lblEmotionTag_Click);
            // 
            // lblEmotionTag3
            // 
            this.lblEmotionTag3.AutoSize = true;
            this.lblEmotionTag3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblEmotionTag3.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblEmotionTag3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(185)))), ((int)(((byte)(200)))));
            this.lblEmotionTag3.Location = new System.Drawing.Point(112, 6);
            this.lblEmotionTag3.Name = "lblEmotionTag3";
            this.lblEmotionTag3.Size = new System.Drawing.Size(87, 15);
            this.lblEmotionTag3.TabIndex = 2;
            this.lblEmotionTag3.Text = "+ [hắng giọng]";
            this.lblEmotionTag3.Click += new System.EventHandler(this.lblEmotionTag_Click);
            // 
            // lblEmotionTag4
            // 
            this.lblEmotionTag4.AutoSize = true;
            this.lblEmotionTag4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblEmotionTag4.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblEmotionTag4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(185)))), ((int)(((byte)(200)))));
            this.lblEmotionTag4.Location = new System.Drawing.Point(188, 6);
            this.lblEmotionTag4.Name = "lblEmotionTag4";
            this.lblEmotionTag4.Size = new System.Drawing.Size(71, 15);
            this.lblEmotionTag4.TabIndex = 3;
            this.lblEmotionTag4.Text = "+ [thì thầm]";
            this.lblEmotionTag4.Click += new System.EventHandler(this.lblEmotionTag_Click);
            // 
            // lblCharAndWordCount
            // 
            this.lblCharAndWordCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCharAndWordCount.AutoSize = true;
            this.lblCharAndWordCount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCharAndWordCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblCharAndWordCount.Location = new System.Drawing.Point(481, 6);
            this.lblCharAndWordCount.Name = "lblCharAndWordCount";
            this.lblCharAndWordCount.Size = new System.Drawing.Size(71, 15);
            this.lblCharAndWordCount.TabIndex = 4;
            this.lblCharAndWordCount.Text = "0 ký tự | 0 từ";
            // 
            // cardPlaybackStatus
            // 
            this.cardPlaybackStatus.BackColor = System.Drawing.Color.Transparent;
            this.cardPlaybackStatus.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(72)))));
            this.cardPlaybackStatus.BorderRadius = 12;
            this.cardPlaybackStatus.Controls.Add(this.lblPlaybackStatusInfo);
            this.cardPlaybackStatus.Controls.Add(this.waveformVisualizer);
            this.cardPlaybackStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cardPlaybackStatus.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(34)))));
            this.cardPlaybackStatus.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(44)))));
            this.cardPlaybackStatus.Location = new System.Drawing.Point(12, 388);
            this.cardPlaybackStatus.Name = "cardPlaybackStatus";
            this.cardPlaybackStatus.Padding = new System.Windows.Forms.Padding(12, 6, 12, 6);
            this.cardPlaybackStatus.Size = new System.Drawing.Size(632, 49);
            this.cardPlaybackStatus.TabIndex = 1;
            // 
            // lblPlaybackStatusInfo
            // 
            this.lblPlaybackStatusInfo.AutoSize = true;
            this.lblPlaybackStatusInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblPlaybackStatusInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblPlaybackStatusInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.lblPlaybackStatusInfo.Location = new System.Drawing.Point(12, 8);
            this.lblPlaybackStatusInfo.Name = "lblPlaybackStatusInfo";
            this.lblPlaybackStatusInfo.Size = new System.Drawing.Size(139, 15);
            this.lblPlaybackStatusInfo.TabIndex = 0;
            this.lblPlaybackStatusInfo.Text = "⏹ Sẵn sàng đọc văn bản";
            // 
            // waveformVisualizer
            // 
            this.waveformVisualizer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.waveformVisualizer.BackColor = System.Drawing.Color.Transparent;
            this.waveformVisualizer.BarColorEnd = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            this.waveformVisualizer.BarColorStart = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.waveformVisualizer.IsPlaying = false;
            this.waveformVisualizer.Location = new System.Drawing.Point(12, 20);
            this.waveformVisualizer.Name = "waveformVisualizer";
            this.waveformVisualizer.Size = new System.Drawing.Size(608, 24);
            this.waveformVisualizer.TabIndex = 1;
            // 
            // pnlActionButtonsContainer
            // 
            this.pnlActionButtonsContainer.Controls.Add(this.btnClearInputText);
            this.pnlActionButtonsContainer.Controls.Add(this.btnStopAudio);
            this.pnlActionButtonsContainer.Controls.Add(this.btnPauseAudio);
            this.pnlActionButtonsContainer.Controls.Add(this.btnPlayText);
            this.pnlActionButtonsContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlActionButtonsContainer.Location = new System.Drawing.Point(12, 437);
            this.pnlActionButtonsContainer.Name = "pnlActionButtonsContainer";
            this.pnlActionButtonsContainer.Size = new System.Drawing.Size(632, 110);
            this.pnlActionButtonsContainer.TabIndex = 2;
            // 
            // btnClearInputText
            // 
            this.btnClearInputText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearInputText.BackColor = System.Drawing.Color.Transparent;
            this.btnClearInputText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.btnClearInputText.BorderRadius = 10;
            this.btnClearInputText.BorderSize = 1;
            this.btnClearInputText.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.btnClearInputText.ClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.btnClearInputText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearInputText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearInputText.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnClearInputText.ForeColor = System.Drawing.Color.White;
            this.btnClearInputText.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.btnClearInputText.Location = new System.Drawing.Point(7, 68);
            this.btnClearInputText.Name = "btnClearInputText";
            this.btnClearInputText.Size = new System.Drawing.Size(621, 34);
            this.btnClearInputText.TabIndex = 3;
            this.btnClearInputText.Text = "🗑️ Xóa Nội Dung Văn Bản";
            this.btnClearInputText.UseVisualStyleBackColor = false;
            this.btnClearInputText.Click += new System.EventHandler(this.btnClearInputText_Click);
            // 
            // btnStopAudio
            // 
            this.btnStopAudio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStopAudio.BackColor = System.Drawing.Color.Transparent;
            this.btnStopAudio.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(113)))), ((int)(((byte)(133)))));
            this.btnStopAudio.BorderSize = 1;
            this.btnStopAudio.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(29)))), ((int)(((byte)(72)))));
            this.btnStopAudio.ClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(18)))), ((int)(((byte)(60)))));
            this.btnStopAudio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStopAudio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStopAudio.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnStopAudio.ForeColor = System.Drawing.Color.White;
            this.btnStopAudio.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(63)))), ((int)(((byte)(94)))));
            this.btnStopAudio.Location = new System.Drawing.Point(483, 12);
            this.btnStopAudio.Name = "btnStopAudio";
            this.btnStopAudio.Size = new System.Drawing.Size(144, 48);
            this.btnStopAudio.TabIndex = 2;
            this.btnStopAudio.Text = "⏹ Dừng";
            this.btnStopAudio.UseVisualStyleBackColor = false;
            this.btnStopAudio.Click += new System.EventHandler(this.btnStopAudio_Click);
            // 
            // btnPauseAudio
            // 
            this.btnPauseAudio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPauseAudio.BackColor = System.Drawing.Color.Transparent;
            this.btnPauseAudio.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(191)))), ((int)(((byte)(36)))));
            this.btnPauseAudio.BorderSize = 1;
            this.btnPauseAudio.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(119)))), ((int)(((byte)(6)))));
            this.btnPauseAudio.ClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(83)))), ((int)(((byte)(9)))));
            this.btnPauseAudio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPauseAudio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPauseAudio.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnPauseAudio.ForeColor = System.Drawing.Color.White;
            this.btnPauseAudio.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(11)))));
            this.btnPauseAudio.Location = new System.Drawing.Point(338, 12);
            this.btnPauseAudio.Name = "btnPauseAudio";
            this.btnPauseAudio.Size = new System.Drawing.Size(140, 48);
            this.btnPauseAudio.TabIndex = 1;
            this.btnPauseAudio.Text = "⏸ Tạm Dừng";
            this.btnPauseAudio.UseVisualStyleBackColor = false;
            this.btnPauseAudio.Click += new System.EventHandler(this.btnPauseAudio_Click);
            // 
            // btnPlayText
            // 
            this.btnPlayText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPlayText.BackColor = System.Drawing.Color.Transparent;
            this.btnPlayText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.btnPlayText.BorderRadius = 14;
            this.btnPlayText.BorderSize = 1;
            this.btnPlayText.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.btnPlayText.ClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(170)))));
            this.btnPlayText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlayText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnPlayText.ForeColor = System.Drawing.Color.White;
            this.btnPlayText.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(140)))), ((int)(((byte)(230)))));
            this.btnPlayText.Location = new System.Drawing.Point(7, 12);
            this.btnPlayText.Name = "btnPlayText";
            this.btnPlayText.Size = new System.Drawing.Size(326, 48);
            this.btnPlayText.TabIndex = 0;
            this.btnPlayText.Text = "▶  ĐỌC VĂN BẢN (F5)";
            this.btnPlayText.UseVisualStyleBackColor = false;
            this.btnPlayText.Click += new System.EventHandler(this.btnPlayText_Click);
            // 
            // pnlRightHistorySidebar
            // 
            this.pnlRightHistorySidebar.Controls.Add(this.cardHistoryLogs);
            this.pnlRightHistorySidebar.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRightHistorySidebar.Location = new System.Drawing.Point(989, 126);
            this.pnlRightHistorySidebar.Name = "pnlRightHistorySidebar";
            this.pnlRightHistorySidebar.Padding = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.pnlRightHistorySidebar.Size = new System.Drawing.Size(161, 559);
            this.pnlRightHistorySidebar.TabIndex = 3;
            this.pnlRightHistorySidebar.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlRightHistorySidebar_Paint);
            // 
            // cardHistoryLogs
            // 
            this.cardHistoryLogs.BackColor = System.Drawing.Color.Transparent;
            this.cardHistoryLogs.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(72)))));
            this.cardHistoryLogs.Controls.Add(this.lblHistorySectionTitle);
            this.cardHistoryLogs.Controls.Add(this.lstHistoryLogs);
            this.cardHistoryLogs.Controls.Add(this.btnClearHistoryRecords);
            this.cardHistoryLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardHistoryLogs.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(34)))));
            this.cardHistoryLogs.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(44)))));
            this.cardHistoryLogs.Location = new System.Drawing.Point(12, 12);
            this.cardHistoryLogs.Name = "cardHistoryLogs";
            this.cardHistoryLogs.Padding = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.cardHistoryLogs.Size = new System.Drawing.Size(137, 535);
            this.cardHistoryLogs.TabIndex = 0;
            // 
            // lblHistorySectionTitle
            // 
            this.lblHistorySectionTitle.AutoSize = true;
            this.lblHistorySectionTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblHistorySectionTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.lblHistorySectionTitle.Location = new System.Drawing.Point(10, 8);
            this.lblHistorySectionTitle.Name = "lblHistorySectionTitle";
            this.lblHistorySectionTitle.Size = new System.Drawing.Size(109, 19);
            this.lblHistorySectionTitle.TabIndex = 0;
            this.lblHistorySectionTitle.Text = "📜 Lịch Sử Đọc";
            // 
            // lstHistoryLogs
            // 
            this.lstHistoryLogs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstHistoryLogs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(24)))));
            this.lstHistoryLogs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstHistoryLogs.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lstHistoryLogs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.lstHistoryLogs.FormattingEnabled = true;
            this.lstHistoryLogs.ItemHeight = 15;
            this.lstHistoryLogs.Location = new System.Drawing.Point(10, 34);
            this.lstHistoryLogs.Name = "lstHistoryLogs";
            this.lstHistoryLogs.Size = new System.Drawing.Size(117, 405);
            this.lstHistoryLogs.TabIndex = 1;
            this.lstHistoryLogs.SelectedIndexChanged += new System.EventHandler(this.lstHistoryLogs_SelectedIndexChanged);
            // 
            // btnClearHistoryRecords
            // 
            this.btnClearHistoryRecords.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearHistoryRecords.BackColor = System.Drawing.Color.Transparent;
            this.btnClearHistoryRecords.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.btnClearHistoryRecords.BorderRadius = 10;
            this.btnClearHistoryRecords.BorderSize = 1;
            this.btnClearHistoryRecords.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btnClearHistoryRecords.ClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.btnClearHistoryRecords.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearHistoryRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearHistoryRecords.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnClearHistoryRecords.ForeColor = System.Drawing.Color.White;
            this.btnClearHistoryRecords.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnClearHistoryRecords.Location = new System.Drawing.Point(10, 489);
            this.btnClearHistoryRecords.Name = "btnClearHistoryRecords";
            this.btnClearHistoryRecords.Size = new System.Drawing.Size(117, 36);
            this.btnClearHistoryRecords.TabIndex = 2;
            this.btnClearHistoryRecords.Text = "🗑️ Xóa Lịch Sử";
            this.btnClearHistoryRecords.UseVisualStyleBackColor = false;
            this.btnClearHistoryRecords.Click += new System.EventHandler(this.btnClearHistoryRecords_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(1150, 707);
            this.Controls.Add(this.pnlCenterEditorContainer);
            this.Controls.Add(this.pnlRightHistorySidebar);
            this.Controls.Add(this.pnlLeftControlSidebar);
            this.Controls.Add(this.mainToolStrip);
            this.Controls.Add(this.mainMenuStrip);
            this.Controls.Add(this.mainStatusStrip);
            this.Controls.Add(this.pnlHeaderCard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.mainMenuStrip;
            this.MinimumSize = new System.Drawing.Size(1000, 660);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VoiceCraft Studio Pro";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.pnlHeaderCard.ResumeLayout(false);
            this.pnlHeaderCard.PerformLayout();
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.mainToolStrip.ResumeLayout(false);
            this.mainToolStrip.PerformLayout();
            this.mainStatusStrip.ResumeLayout(false);
            this.mainStatusStrip.PerformLayout();
            this.txtContextMenu.ResumeLayout(false);
            this.pnlLeftControlSidebar.ResumeLayout(false);
            this.cardFileActions.ResumeLayout(false);
            this.cardFileActions.PerformLayout();
            this.cardAudioSettings.ResumeLayout(false);
            this.cardAudioSettings.PerformLayout();
            this.cardVoiceCloning.ResumeLayout(false);
            this.cardVoiceCloning.PerformLayout();
            this.cardVoiceSelection.ResumeLayout(false);
            this.cardVoiceSelection.PerformLayout();
            this.pnlEngineSegment.ResumeLayout(false);
            this.pnlTimbreSegment.ResumeLayout(false);
            this.pnlDurationSegment.ResumeLayout(false);
            this.pnlPitchSegment.ResumeLayout(false);
            this.pnlStyleSegment.ResumeLayout(false);
            this.pnlCenterEditorContainer.ResumeLayout(false);
            this.cardTextEditor.ResumeLayout(false);
            this.cardTextEditor.PerformLayout();
            this.pnlTextEditorFooter.ResumeLayout(false);
            this.pnlTextEditorFooter.PerformLayout();
            this.cardPlaybackStatus.ResumeLayout(false);
            this.cardPlaybackStatus.PerformLayout();
            this.pnlActionButtonsContainer.ResumeLayout(false);
            this.pnlRightHistorySidebar.ResumeLayout(false);
            this.cardHistoryLogs.ResumeLayout(false);
            this.cardHistoryLogs.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BT_TNC_Dot_NET.Controls.RoundedPanel pnlHeaderCard;
        private System.Windows.Forms.Label lblAppTitle;
        private System.Windows.Forms.Label lblAppSubtitle;
        private System.Windows.Forms.Label btnCloseApp;
        private System.Windows.Forms.Label btnMaximizeApp;
        private System.Windows.Forms.Label btnMinimizeApp;
        private System.Windows.Forms.ComboBox cboThemeSelection;
        private System.Windows.Forms.ComboBox cboLanguageSelection;

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuFileOpen;
        private System.Windows.Forms.ToolStripMenuItem menuFileExport;
        private System.Windows.Forms.ToolStripMenuItem menuFileExit;

        private System.Windows.Forms.ToolStripMenuItem menuEdit;
        private System.Windows.Forms.ToolStripMenuItem menuEditCopy;
        private System.Windows.Forms.ToolStripMenuItem menuEditPaste;
        private System.Windows.Forms.ToolStripMenuItem menuEditClear;

        private System.Windows.Forms.ToolStripMenuItem menuVoice;
        private System.Windows.Forms.ToolStripMenuItem menuVoiceEngineVieNeu;
        private System.Windows.Forms.ToolStripMenuItem menuVoiceEngineSapi;

        private System.Windows.Forms.ToolStripMenuItem menuHelp;
        private System.Windows.Forms.ToolStripMenuItem menuHelpGuide;
        private System.Windows.Forms.ToolStripMenuItem menuHelpReport;
        private System.Windows.Forms.ToolStripMenuItem menuHelpAbout;

        private System.Windows.Forms.ToolStrip mainToolStrip;
        private System.Windows.Forms.ToolStripButton toolBtnOpen;
        private System.Windows.Forms.ToolStripButton toolBtnExport;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolBtnPlay;
        private System.Windows.Forms.ToolStripButton toolBtnPause;
        private System.Windows.Forms.ToolStripButton toolBtnStop;

        private System.Windows.Forms.StatusStrip mainStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusReady;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusEngine;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusVoice;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusStats;

        private System.Windows.Forms.ContextMenuStrip txtContextMenu;
        private System.Windows.Forms.ToolStripMenuItem ctxCut;
        private System.Windows.Forms.ToolStripMenuItem ctxCopy;
        private System.Windows.Forms.ToolStripMenuItem ctxPaste;
        private System.Windows.Forms.ToolStripMenuItem ctxClear;
        private System.Windows.Forms.ToolStripMenuItem ctxSpeakSelected;

        private System.Windows.Forms.Panel pnlLeftControlSidebar;
        private BT_TNC_Dot_NET.Controls.RoundedPanel cardVoiceSelection;
        private System.Windows.Forms.Label lblEngineTitle;
        private System.Windows.Forms.FlowLayoutPanel pnlEngineSegment;
        private BT_TNC_Dot_NET.Controls.ModernButton btnEngineVieNeu;
        private BT_TNC_Dot_NET.Controls.ModernButton btnEngineSapi;

        private System.Windows.Forms.Label lblVoiceSectionTitle;
        private System.Windows.Forms.ComboBox cboVoiceSelection;

        private System.Windows.Forms.Label lblTimbreTitle;
        private System.Windows.Forms.FlowLayoutPanel pnlTimbreSegment;
        private BT_TNC_Dot_NET.Controls.ModernButton btnTimbreStandard;
        private BT_TNC_Dot_NET.Controls.ModernButton btnTimbreRadio;
        private BT_TNC_Dot_NET.Controls.ModernButton btnTimbreWarm;
        private BT_TNC_Dot_NET.Controls.ModernButton btnTimbreBright;
        private BT_TNC_Dot_NET.Controls.ModernButton btnTimbreReverb;

        private System.Windows.Forms.Label lblDurationTitle;
        private System.Windows.Forms.FlowLayoutPanel pnlDurationSegment;
        private BT_TNC_Dot_NET.Controls.ModernButton btnDurationStandard;
        private BT_TNC_Dot_NET.Controls.ModernButton btnDurationShort;
        private BT_TNC_Dot_NET.Controls.ModernButton btnDurationLong;

        private System.Windows.Forms.Label lblPitchTuningTitle;
        private System.Windows.Forms.FlowLayoutPanel pnlPitchSegment;
        private BT_TNC_Dot_NET.Controls.ModernButton btnPitchDeep;
        private BT_TNC_Dot_NET.Controls.ModernButton btnPitchLow;
        private BT_TNC_Dot_NET.Controls.ModernButton btnPitchNormal;
        private BT_TNC_Dot_NET.Controls.ModernButton btnPitchHigh;
        private BT_TNC_Dot_NET.Controls.ModernButton btnPitchBright;

        private System.Windows.Forms.Label lblStyleSectionTitle;
        private System.Windows.Forms.FlowLayoutPanel pnlStyleSegment;
        private BT_TNC_Dot_NET.Controls.ModernButton btnStyleNatural;
        private BT_TNC_Dot_NET.Controls.ModernButton btnStyleNews;
        private BT_TNC_Dot_NET.Controls.ModernButton btnStyleStory;
        private BT_TNC_Dot_NET.Controls.ModernButton btnStyleDrama;

        private System.Windows.Forms.Label lblVoiceDetails;

        private BT_TNC_Dot_NET.Controls.RoundedPanel cardVoiceCloning;
        private System.Windows.Forms.Label lblCloneSectionTitle;
        private System.Windows.Forms.CheckBox chkEnableVoiceCloning;
        private BT_TNC_Dot_NET.Controls.ModernButton btnSelectCloneAudio;
        private BT_TNC_Dot_NET.Controls.ModernButton btnBrowseFile;
        private BT_TNC_Dot_NET.Controls.ModernButton btnExportAudioWav;
        private System.Windows.Forms.Label lblCloneAudioStatus;

        private BT_TNC_Dot_NET.Controls.RoundedPanel cardAudioSettings;
        private System.Windows.Forms.Label lblAudioSectionTitle;
        private System.Windows.Forms.Label lblSpeedRateText;
        private System.Windows.Forms.Label lblSpeedRateValue;
        private BT_TNC_Dot_NET.Controls.ModernTrackBar trkSpeedRate;
        private System.Windows.Forms.Label lblPitchRateText;
        private System.Windows.Forms.Label lblPitchRateValue;
        private BT_TNC_Dot_NET.Controls.ModernTrackBar trkPitchRate;
        private System.Windows.Forms.Label lblVolumeLevelText;
        private System.Windows.Forms.Label lblVolumeLevelValue;
        private BT_TNC_Dot_NET.Controls.ModernTrackBar trkVolumeLevel;
        private System.Windows.Forms.Label lblGraphicEqTitle;
        private BT_TNC_Dot_NET.Controls.ModernEqualizerControl graphicEqControl;

        private BT_TNC_Dot_NET.Controls.RoundedPanel cardFileActions;
        private System.Windows.Forms.Label lblFileSectionTitle;

        private System.Windows.Forms.Panel pnlCenterEditorContainer;
        private BT_TNC_Dot_NET.Controls.RoundedPanel cardTextEditor;
        private System.Windows.Forms.TextBox txtInputContent;
        private System.Windows.Forms.Panel pnlTextEditorFooter;
        private System.Windows.Forms.Label lblEmotionTag1;
        private System.Windows.Forms.Label lblEmotionTag2;
        private System.Windows.Forms.Label lblEmotionTag3;
        private System.Windows.Forms.Label lblEmotionTag4;
        private System.Windows.Forms.Label lblCharAndWordCount;

        private BT_TNC_Dot_NET.Controls.RoundedPanel cardPlaybackStatus;
        private System.Windows.Forms.Label lblPlaybackStatusInfo;
        private BT_TNC_Dot_NET.Controls.WaveformVisualizer waveformVisualizer;

        private System.Windows.Forms.Panel pnlActionButtonsContainer;
        private BT_TNC_Dot_NET.Controls.ModernButton btnPlayText;
        private BT_TNC_Dot_NET.Controls.ModernButton btnPauseAudio;
        private BT_TNC_Dot_NET.Controls.ModernButton btnStopAudio;
        private BT_TNC_Dot_NET.Controls.ModernButton btnClearInputText;

        private System.Windows.Forms.Panel pnlRightHistorySidebar;
        private BT_TNC_Dot_NET.Controls.RoundedPanel cardHistoryLogs;
        private System.Windows.Forms.Label lblHistorySectionTitle;
        private System.Windows.Forms.ListBox lstHistoryLogs;
        private BT_TNC_Dot_NET.Controls.ModernButton btnClearHistoryRecords;
    }
}
