# 💻 HƯỚNG DẪN PHÁT TRIỂN — DEVELOPER GUIDE

> Tài liệu kỹ thuật dành cho lập trình viên muốn mở rộng, bảo trì hoặc đóng góp vào dự án VoiceCraft Studio Pro.

---

## 1. YÊU CẦU MÔI TRƯỜNG PHÁT TRIỂN

| Thành phần | Phiên bản | Ghi chú |
|-----------|----------|---------|
| Hệ điều hành | Windows 10/11 (64-bit) | Bắt buộc |
| IDE | Visual Studio 2022/2026 | Workload ".NET desktop development" |
| Framework | .NET Framework 4.8 | Kèm Developer Pack |
| Python | 3.10+ | Cho VieNeu-TTS engine |
| Git | 2.40+ | Quản lý mã nguồn |

---

## 2. HƯỚNG DẪN CÀI ĐẶT & BIÊN DỊCH

```powershell
# Clone repository
git clone https://github.com/MinhTriTM/BT_TNC_Dot-NET.git
cd "BT_TNC_Dot-NET/Bài Tự Nghiên Cứu/TTS_Windows_App"

# Biên dịch Debug
dotnet build TTS_Windows_App.csproj -c Debug

# Biên dịch Release
dotnet build TTS_Windows_App.csproj -c Release

# Chạy ứng dụng
.\bin\Debug\TTS_Windows_App.exe
```

**Cài đặt VieNeu-TTS (tùy chọn):**
```powershell
cd VieNeu-TTS
uv sync          # hoặc pip install -r requirements.txt
```

---

## 3. CẤU TRÚC THƯ MỤC DỰ ÁN

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
├── VieNeu-TTS/                   # AI Engine (Python)
├── doc/                          # Tài liệu kỹ thuật
├── MainForm.cs                   # Form chính (692 dòng)
├── MainForm.Designer.cs          # Layout (2,154 dòng)
├── Program.cs                    # Entry point
├── App.config                    # Cấu hình ứng dụng
└── TTS_Windows_App.csproj        # Project file .NET 4.8
```

---

## 4. TẠO CUSTOM CONTROL GDI+ MỚI

### 4.1. Bước cơ bản
```csharp
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace TTS_Windows_App.Controls
{
    // Kế thừa Control (hoặc UserControl, Panel, Button)
    public class MyNewControl : Control
    {
        public MyNewControl()
        {
            // Bật DoubleBuffered chống nhấp nháy
            SetStyle(ControlStyles.UserPaint |
                     ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.ResizeRedraw |
                     ControlStyles.SupportsTransparentBackColor, true);
            BackColor = Color.Transparent;
        }

        // Override OnPaint để vẽ tùy chỉnh
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            // Vẽ tại đây...
        }
    }
}
```

### 4.2. Đăng ký trong csproj
```xml
<Compile Include="Controls\MyNewControl.cs">
  <SubType>Component</SubType>
</Compile>
```

---

## 5. MỞ RỘNG EQUALIZER

Sự kiện `GainChanged` được kích hoạt khi người dùng kéo thanh gạt:

```csharp
// Trong MainForm.cs
graphicEqControl.GainChanged += (sender, args) =>
{
    float[] gains = graphicEqControl.Gains;
    // gains[0] = 31Hz, gains[1] = 63Hz, ... gains[9] = 16kHz
    // Giá trị từ -12.0f đến +12.0f (dB)
    
    // Ví dụ: áp dụng vào DSP pipeline
    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine($"Band {i}: {gains[i]:+0.0;-0.0} dB");
    }
};
```

---

## 6. QUY TẮC WINFORMS DESIGNER

> ⚠️ **CRITICAL RULE**: Class `MainForm` (kế thừa `Form`) **BẮT BUỘC** phải là class đầu tiên trong file `MainForm.cs`.

- Các helper class như `NativeMethods` phải khai báo dạng **Nested Class** bên trong `MainForm`, HOẶC tách ra file riêng trong `Helpers/`.
- Nếu vi phạm, Visual Studio Form Designer sẽ báo lỗi: *"The class MainForm can be designed, but is not the first class in the file"*.

---

## 7. THÊM THEME MỚI

Mở file `Helpers/ThemeManager.cs`, thêm `ThemePalette` mới:

```csharp
// Thêm theme vào danh sách trong GetAllThemes()
new ThemePalette
{
    Name = "Cherry Blossom",
    PrimaryColor = Color.FromArgb(236, 72, 153),
    SecondaryColor = Color.FromArgb(244, 114, 182),
    BackgroundColor = Color.FromArgb(25, 15, 20),
    SurfaceColor = Color.FromArgb(35, 25, 30),
    TextColor = Color.FromArgb(252, 231, 243),
    AccentColor = Color.FromArgb(249, 168, 212)
}
```

---

## 8. THÊM NGÔN NGỮ MỚI

Mở file `Helpers/LanguageManager.cs`, thêm dictionary ngôn ngữ mới:

```csharp
// Thêm vào phương thức GetLanguagePack()
case "ja": // Tiếng Nhật
    return new Dictionary<string, string>
    {
        { "btnPlayText", "📢 テキスト読み上げ" },
        { "lblStatusReady", "準備完了" },
        // ... thêm các key khác
    };
```

---

## 9. THÊM GIỌNG AI MỚI

Mở file `Services/VieNeuTtsService.cs`, bổ sung vào `GetPresetVoices()`:

```csharp
voices.Add(new VoiceItem
{
    Id = "vn-new-voice",
    Name = "🎤 Tên Giọng Mới",
    Culture = "vi-VN",
    Gender = "Female"  // hoặc "Male"
});
```

---

## 10. LỖI THƯỜNG GẶP

| Lỗi | Nguyên nhân | Giải pháp |
|-----|------------|-----------|
| CS0246: `Speech` not found | Thiếu Reference | Thêm `System.Speech` vào References |
| Designer không mở được | Class Form không đứng đầu file | Đưa `MainForm` lên đầu file `.cs` |
| `NativeMethods` not found | Thiếu trong csproj | Thêm `Compile Include` vào `.csproj` |
| File tiếng Việt bị rác | Encoding sai | Dùng `Encoding.UTF8` khi đọc file |
| VieNeu không phản hồi | Python chưa cài đặt | Chạy `uv sync` trong `VieNeu-TTS/` |
