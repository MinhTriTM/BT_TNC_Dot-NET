# 🔌 TÀI LIỆU API & DỊCH VỤ — API SPECIFICATION

> Mô tả chi tiết toàn bộ giao diện lập trình công khai (public API) của dự án VoiceCraft Studio Pro.

---

## 1. NAMESPACE `TTS_Windows_App.Services`

### 1.1. CLASS `TtsService` — Dịch Vụ SAPI5

Bọc thư viện `System.Speech.Synthesis` để điều khiển giọng đọc Windows native.

#### Phương thức

| Phương thức | Tham số | Kiểu trả về | Mô tả |
|------------|---------|-------------|-------|
| `GetInstalledVoices()` | — | `List<VoiceItem>` | Lấy danh sách giọng đọc SAPI5 đã cài trên Windows |
| `Speak(...)` | `string text`, `string voiceName`, `int rate = 0`, `int volume = 100` | `void` | Phát giọng đọc bất đồng bộ qua `SpeechSynthesizer.SpeakAsync()` |
| `Pause()` | — | `void` | Tạm dừng phát âm thanh |
| `Resume()` | — | `void` | Tiếp tục phát sau khi tạm dừng |
| `Stop()` | — | `void` | Dừng phát hoàn toàn, hủy tất cả utterance |
| `ExportToWavAsync(...)` | `string text`, `string voiceName`, `string outputFilePath`, `int rate = 0`, `int volume = 100` | `Task` | Xuất file âm thanh WAV bằng `SetOutputToWaveFile()` |

#### Sự kiện

| Sự kiện | EventArgs | Mô tả |
|---------|-----------|-------|
| `SpeakProgress` | `SpeakProgressEventArgs` | Kích hoạt mỗi từ/ký tự đang phát — dùng để highlight vị trí văn bản |
| `SpeakCompleted` | `SpeakCompletedEventArgs` | Kích hoạt khi hoàn tất đọc toàn bộ đoạn văn |

---

### 1.2. CLASS `VieNeuTtsService` — Dịch Vụ AI VieNeu 48kHz

Cầu nối C# → Python thông qua `System.Diagnostics.Process`, gọi script `vieneu_bridge.py`.

#### Phương thức

| Phương thức | Tham số | Kiểu trả về | Mô tả |
|------------|---------|-------------|-------|
| `GetPresetVoices()` | — | `List<VoiceItem>` | Trả về 14 giọng AI preset 3 miền Bắc/Trung/Nam |
| `SpeakAsync(...)` | `string text`, `string voice`, `string style`, `double pitch`, `Action<string> statusCallback`, `string cloneAudioPath = ""` | `Task` | Tổng hợp và phát giọng AI trực tiếp. `statusCallback` nhận thông báo tiến trình |
| `GenerateAudioWavAsync(...)` | `string text`, `string voice`, `string style`, `double pitch`, `string outputPath`, `string cloneAudioPath = ""` | `Task<string>` | Tổng hợp và lưu file WAV 48kHz. Trả về đường dẫn file đã tạo |
| `Stop()` | — | `void` | Ngắt tiến trình Python đang chạy, dừng phát âm thanh |

#### Tham số `style` hợp lệ
| Giá trị | Ý nghĩa |
|---------|---------|
| `"natural"` | 🌿 Tự nhiên — giọng đọc bình thường |
| `"news"` | 📰 Tin tức — giọng phát thanh viên |
| `"story"` | 📖 Đọc truyện — nhấn nhá cảm xúc |
| `"drama"` | 🎭 Kịch nghệ — diễn cảm mạnh |

#### Tham số `pitch`
- Kiểu: `double`
- Phạm vi: `-10.0` đến `+10.0` (đơn vị: semitones)
- Mặc định: `0.0` (không dịch chuyển)

---

## 2. NAMESPACE `TTS_Windows_App.Models`

### 2.1. CLASS `VoiceItem`

Đại diện cho một giọng đọc trong hệ thống (cả SAPI5 lẫn VieNeu AI).

| Thuộc tính | Kiểu | Mô tả |
|-----------|------|-------|
| `Id` | `string` | Mã định danh duy nhất |
| `Name` | `string` | Tên hiển thị (VD: "🎤 Hoài My") |
| `Culture` | `string` | Mã văn hóa (VD: "vi-VN", "en-US") |
| `Gender` | `string` | Giới tính: "Male" / "Female" |

**Override**: `ToString()` → `"{Name} ({Culture})"`

### 2.2. CLASS `HistoryRecord`

Lưu trữ một mục lịch sử đọc văn bản.

| Thuộc tính | Kiểu | Mặc định | Mô tả |
|-----------|------|----------|-------|
| `Id` | `string` | `Guid.NewGuid().ToString()` | Mã duy nhất |
| `Text` | `string` | — | Nội dung văn bản đã đọc |
| `VoiceName` | `string` | — | Tên giọng đọc sử dụng |
| `Timestamp` | `DateTime` | `DateTime.Now` | Thời điểm đọc |
| `CharCount` | `int` | Computed | `Text?.Length ?? 0` (thuộc tính tính toán) |

---

## 3. NAMESPACE `TTS_Windows_App.Helpers`

### 3.1. CLASS `ThemeManager`

Quản lý 6 bảng màu giao diện. Áp dụng theme đồng bộ lên tất cả controls.

#### Struct `ThemePalette`

| Trường | Kiểu | Mô tả |
|--------|------|-------|
| `Name` | `string` | Tên theme hiển thị |
| `PrimaryColor` | `Color` | Màu chính (nút bấm, accent) |
| `SecondaryColor` | `Color` | Màu phụ (hover, border) |
| `BackgroundColor` | `Color` | Màu nền chính |
| `SurfaceColor` | `Color` | Màu nền panel/card |
| `TextColor` | `Color` | Màu chữ |
| `AccentColor` | `Color` | Màu nhấn mạnh |

#### 6 Theme có sẵn

| Index | Tên | Màu chính |
|-------|-----|-----------|
| 0 | 🌑 Cinematic Dark | Indigo `#4F46E5` |
| 1 | 🌊 Ocean Blue | Cyan `#06B6D4` |
| 2 | 🌲 Forest Green | Emerald `#10B981` |
| 3 | 👑 Royal Purple | Violet `#8B5CF6` |
| 4 | 🌅 Sunset Orange | Amber `#F59E0B` |
| 5 | 🌙 Midnight Red | Rose `#F43F5E` |

### 3.2. CLASS `LanguageManager`

Chuyển đổi ngôn ngữ giao diện VI/EN bằng dictionary key-value.

| Phương thức | Tham số | Mô tả |
|------------|---------|-------|
| `ApplyLanguage(...)` | `Form form`, `string langCode` | Áp dụng ngôn ngữ cho form |

**Ngôn ngữ hỗ trợ**: `"vi"` (Tiếng Việt), `"en"` (English)

### 3.3. CLASS `FileHelper`

| Phương thức | Mô tả |
|------------|-------|
| `ReadTextFile(string path)` | Đọc file văn bản UTF-8 |
| `SaveTextFile(string path, string content)` | Ghi file văn bản UTF-8 |

### 3.4. CLASS `CustomVoiceManager`

Quản lý danh sách giọng đọc tùy chỉnh do người dùng tạo.

### 3.5. CLASS `NativeMethods`

P/Invoke Win32 API cho kéo di chuyển Form borderless.

```csharp
[DllImport("user32.dll")] 
static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

[DllImport("user32.dll")]
static extern bool ReleaseCapture();
```

**Hằng số**: `WM_NCLBUTTONDOWN = 0xA1`, `HT_CAPTION = 0x2`

---

## 4. NAMESPACE `TTS_Windows_App.Controls`

### 4.1. CLASS `ModernButton : Button`

| Thuộc tính | Kiểu | Mặc định | Mô tả |
|-----------|------|----------|-------|
| `BorderRadius` | `int` | `12` | Bán kính bo góc (pixel) |
| `ButtonColor` | `Color` | `#4F46E5` | Màu nền bình thường |
| `HoverColor` | `Color` | `#6366F1` | Màu khi hover |
| `ClickColor` | `Color` | `#4338CA` | Màu khi nhấn |
| `BorderColor` | `Color` | `#818CF8` | Màu viền |
| `BorderSize` | `int` | `0` | Độ dày viền |

### 4.2. CLASS `ModernEqualizerControl : UserControl`

| Thuộc tính / Sự kiện | Kiểu | Mô tả |
|----------------------|------|-------|
| `Gains` | `float[]` (10 phần tử) | Mảng gain 10 dải: -12.0f đến +12.0f dB |
| `GainChanged` | `event EventHandler` | Kích hoạt khi người dùng kéo bất kỳ cần gạt nào |

**10 dải tần số**: 31, 63, 125, 250, 500, 1000, 2000, 4000, 8000, 16000 Hz

### 4.3. CLASS `ModernTrackBar : Control`

| Thuộc tính | Kiểu | Mặc định | Mô tả |
|-----------|------|----------|-------|
| `Minimum` | `int` | `-10` | Giá trị tối thiểu |
| `Maximum` | `int` | `10` | Giá trị tối đa |
| `Value` | `int` | `0` | Giá trị hiện tại |
| `LargeChange` | `int` | `2` | Bước nhảy lớn |
| `TrackColor` | `Color` | `#1E293B` | Màu ray nền |
| `ProgressColor` | `Color` | `#06B6D4` | Màu dải tiến trình |
| `ThumbColor` | `Color` | `#F8FAFC` | Màu cần gạt |
| `ThumbHoverColor` | `Color` | `#A5F3FC` | Màu cần gạt khi hover |

**Sự kiện**: `ValueChanged`, `Scroll`

### 4.4. CLASS `RoundedPanel : Panel`

| Thuộc tính | Kiểu | Mặc định | Mô tả |
|-----------|------|----------|-------|
| `BorderRadius` | `int` | `16` | Bán kính bo góc |
| `BorderColor` | `Color` | `#2D3748` | Màu viền |
| `BorderWidth` | `int` | `1` | Độ dày viền |
| `GradientTopColor` | `Color` | `#161E2E` | Màu gradient trên |
| `GradientBottomColor` | `Color` | `#161E2E` | Màu gradient dưới |
| `GradientAngle` | `float` | `90F` | Góc gradient (độ) |

### 4.5. CLASS `WaveformVisualizer : Control`

| Thuộc tính | Kiểu | Mặc định | Mô tả |
|-----------|------|----------|-------|
| `IsPlaying` | `bool` | `false` | Bật/tắt animation sóng âm |
| `BarColorStart` | `Color` | `#06B6D4` | Màu gradient đầu |
| `BarColorEnd` | `Color` | `#A855F7` | Màu gradient cuối |

**Cấu hình nội bộ**: 24 thanh sóng, Timer 50ms (20 FPS), smooth interpolation 0.4f
