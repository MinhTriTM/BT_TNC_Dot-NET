# 🎙️ VOICECRAFT STUDIO PRO — AI Text-To-Speech & Audio Engineering

![.NET Framework](https://img.shields.io/badge/.NET_Framework-4.8-512BD4?style=for-the-badge&logo=dotnet)
![C#](https://img.shields.io/badge/C%23-WinForms-239120?style=for-the-badge&logo=csharp)
![Python](https://img.shields.io/badge/Python-VieNeu_TTS-3776AB?style=for-the-badge&logo=python)
![License](https://img.shields.io/badge/License-MIT-yellow?style=for-the-badge)

> **Phần mềm chuyển đổi văn bản thành giọng nói AI cao cấp** — Kiến trúc Hybrid C# WinForms + Python VieNeu-TTS Deep Learning Engine 48kHz local offline.

---

## ✨ TÍNH NĂNG NỔI BẬT

- 🎙️ **14 giọng đọc AI** đa vùng miền Bắc/Trung/Nam + 4 phong cách đọc
- 🔧 **Dual Engine**: Windows SAPI5 (0-latency) + VieNeu AI (48kHz chất lượng cao)
- 🎛️ **10-Band Graphic Equalizer**: 31Hz — 16kHz, gain ±12dB
- 🧬 **Voice Cloning**: Nhân bản giọng đọc từ file audio mẫu ngắn
- 🎨 **6 Themes**: Cinematic Dark, Ocean Blue, Forest Green, Royal Purple, Sunset Orange, Midnight Red
- 🌐 **Đa ngôn ngữ**: Tiếng Việt / English
- 📥 **Drag & Drop**: Kéo thả file .txt/.wav/.mp3
- 😄 **Emotion Tags**: [cười], [thở dài], [hắng giọng], [thì thầm]
- 💾 **Xuất WAV**: 48kHz/16-bit chất lượng phòng thu
- 🎹 **Segmented Chip Buttons**: WinUI 3 style — Engine, Sắc độ, Trường độ, Cao giọng, Phong cách

---

## 📁 CẤU TRÚC DỰ ÁN

```
TTS_Windows_App/
├── Controls/                     # 5 Custom Controls GDI+
│   ├── ModernButton.cs           #   Nút bấm bo góc 3 trạng thái
│   ├── ModernEqualizerControl.cs #   10-Band Graphic Equalizer
│   ├── ModernTrackBar.cs         #   Thanh trượt tiến trình
│   ├── RoundedPanel.cs           #   Panel bo góc gradient
│   └── WaveformVisualizer.cs     #   Phổ sóng animation 24 thanh
├── Forms/                        # Form phụ
│   └── VoiceEditorForm.cs        #   Chỉnh sửa giọng đọc
├── Helpers/                      # 5 lớp tiện ích
│   ├── ThemeManager.cs           #   6 bảng màu theme
│   ├── LanguageManager.cs        #   Đa ngôn ngữ VI/EN
│   ├── FileHelper.cs             #   Đọc/ghi file UTF-8
│   ├── CustomVoiceManager.cs     #   Quản lý giọng tùy chỉnh
│   └── NativeMethods.cs          #   P/Invoke Win32
├── Models/                       # Mô hình dữ liệu
│   └── VoiceItem.cs              #   VoiceItem + HistoryRecord
├── Services/                     # 2 dịch vụ TTS
│   ├── TtsService.cs             #   Windows SAPI5
│   └── VieNeuTtsService.cs       #   VieNeu AI 48kHz
├── VieNeu-TTS/                   # AI Engine (Python submodule)
├── doc/                          # Tài liệu kỹ thuật
│   ├── ARCHITECTURE.md           #   Kiến trúc hệ thống
│   ├── DEVELOPER_GUIDE.md        #   Hướng dẫn phát triển
│   ├── API_SPECIFICATION.md      #   Định ước API
│   ├── SLIDE_PRESENTATION.md     #   Slide thuyết trình
│   └── USER_GUIDE.md             #   Hướng dẫn người dùng
├── MainForm.cs                   # Form chính (692 dòng)
├── MainForm.Designer.cs          # Layout Designer (2,154 dòng)
├── Program.cs                    # Entry point
├── App.config                    # Cấu hình ứng dụng
└── TTS_Windows_App.csproj        # Project file .NET 4.8
```

---

## 🛠️ YÊU CẦU HỆ THỐNG

| Thành phần | Tối thiểu | Khuyến nghị |
|-----------|----------|-------------|
| HĐH | Windows 10 64-bit | Windows 11 |
| RAM | 4 GB | 8 GB+ |
| .NET | Framework 4.8 | Framework 4.8 |
| Python | 3.10+ (cho VieNeu AI) | 3.12 |
| GPU | — | NVIDIA GTX 1060+ (cho AI) |

---

## 🚀 HƯỚNG DẪN CÀI ĐẶT & CHẠY

### Cách 1: Mở bằng Visual Studio
```
1. Clone repository: git clone https://github.com/MinhTriTM/BT_TNC_Dot-NET.git
2. Mở file TTS_Windows_App.slnx bằng Visual Studio 2022/2026
3. Nhấn F5 để chạy
```

### Cách 2: Command Line
```powershell
git clone https://github.com/MinhTriTM/BT_TNC_Dot-NET.git
cd "BT_TNC_Dot-NET\Bài Tự Nghiên Cứu\TTS_Windows_App"
dotnet build TTS_Windows_App.csproj
.\bin\Debug\TTS_Windows_App.exe
```

### Cài đặt VieNeu-TTS (tùy chọn — cho engine AI)
```powershell
cd VieNeu-TTS
uv sync
```

---

## 🏗️ KIẾN TRÚC HỆ THỐNG

```
┌─────────────────────────────────────────────────┐
│              C# WinForms (.NET 4.8)              │
│                                                  │
│  ┌────────────┐  ┌───────────┐  ┌─────────────┐ │
│  │  MainForm  │  │ Controls  │  │   Helpers   │ │
│  │ (3-Column) │  │  (GDI+)   │  │(Theme/Lang) │ │
│  └──────┬─────┘  └───────────┘  └─────────────┘ │
│         │                                        │
│  ┌──────▼──────┐        ┌──────────────────────┐ │
│  │ TtsService  │        │  VieNeuTtsService     │ │
│  │  (SAPI5)    │        │  (Python Bridge)      │ │
│  └─────────────┘        └──────────┬───────────┘ │
└────────────────────────────────────┼─────────────┘
                                     │ ProcessStartInfo
                          ┌──────────▼──────────┐
                          │   VieNeu-TTS Engine  │
                          │  (Python 48kHz AI)   │
                          └─────────────────────┘
```

---

## 📊 KẾT QUẢ

| Tiêu chí | Giá trị |
|----------|---------|
| Biên dịch | ✅ Build Succeeded (0 Error, 0 Warning) |
| Tổng dòng code C# | ~3,500+ dòng |
| Custom Controls | 5 controls GDI+ |
| Giọng AI | 14 giọng đa vùng miền |
| Themes | 6 bảng màu chuyên nghiệp |
| Phiên bản | 2.0.0.0 |

---

## 📝 License

MIT License © 2026 MinhTriTM

---

## 🙏 Credits

- **VieNeu-TTS** — Deep Learning TTS Engine cho tiếng Việt
- **System.Speech** — Microsoft SAPI5 API
- **.NET Framework 4.8** — Nền tảng phát triển ứng dụng Windows
