# 📘 TÀI LIỆU HƯỚNG DẪN PHÁT TRIỂN (DEVELOPER GUIDE)
## DỰ ÁN: VOICECRAFT STUDIO PRO (AI TEXT-TO-SPEECH)
**NỀN TẢNG**: C# WINDOWS FORMS (.NET 4.8) & PYTHON BACKEND

---

## CHƯƠNG 1. GIỚI THIỆU TỔNG QUAN

### 1.1. Mục Tiêu Dự Án (VoiceCraft Studio Pro)
Hướng dẫn này dành cho các lập trình viên muốn tham gia duy trì, mở rộng mã nguồn dự án **VoiceCraft Studio Pro**. Dự án không chỉ là một ứng dụng Text-to-Speech thông thường, mà là sự kết hợp kiến trúc **Hybrid Frontend (C# WinForms)** và **Backend (Python AI)**.
Mục tiêu chính là thoát ly giao diện chuẩn thô cứng của Windows Forms bằng bộ thư viện GDI+ tự code, mang trải nghiệm hiện đại (WinUI 3, Cinematic UI) vào Desktop App đời cũ.

### 1.2. Các Tính Năng Hệ Thống Chính
1. Kiến trúc C# gọi Process ngầm Python `VieneuTtsService` xử lý mô hình Deep Learning 48kHz.
2. Form chính phân tách 3 khu vực Layout linh hoạt, hỗ trợ 6 bảng màu (Themes) và 2 Ngôn ngữ (VI/EN).
3. Hệ thống Custom Controls chuyên biệt: WinUI Chip Buttons, 10-band Graphic EQ, Waveform Animation.
4. Xử lý Voice Cloning (Nhân bản giọng nói) trong Sub-Form `VoiceEditorForm`.

---

## CHƯƠNG 2. KIẾN TRÚC MÃ NGUỒN VÀ QUY TẮC THIẾT KẾ (OOP)

### 2.1. Cấu Trúc Thư Mục
Dự án được cấu trúc rõ ràng:
- `Models/`: Chứa `VoiceItem` (lưu trữ metadata giọng đọc) và `HistoryRecord`.
- `Services/`: Chứa `TtsService` (cho Windows SAPI5) và `VieNeuTtsService` (Kết nối cầu nối Python async).
- `Helpers/`: Các lớp tiện ích hệ thống như tĩnh `ThemeManager`, `LanguageManager`, `FileHelper` và tĩnh đa nền `NativeMethods` (P/Invoke User32).
- `Forms/`: 
  - `MainForm` (Bảng điều khiển chính, borderless title bar).
  - `VoiceEditorForm` (Chuyên biệt cho Equalizer và tính năng Voice Cloning).
- `Controls/`: Bộ mã nguồn GDI+ tự họa của nhóm.

### 2.2. Quy Tắc WinForms Designer (First Class Form Rule)
**LƯU Ý ĐẶC BIỆT DÀNH CHO DEVELOPERS**:
Khi lập trình `Custom Controls`, phải luôn đảm bảo quy tắc:
- *Không khởi tạo dữ liệu cứng hoặc gọi API/Service trong hàm Constructor của Control*, vì Visual Studio Designer sẽ chạy hàm này khi bạn mở Tab Design. Điều này gây lỗi văng Designer.
- Luôn kiểm tra môi trường: `if (this.DesignMode) return;` trước khi gọi logic phức tạp trong OnPaint hoặc Load của Custom Controls.

---

## CHƯƠNG 3. TÍCH HỢP HỆ THỐNG CUSTOM CONTROLS GDI+

Điểm đắt giá nhất của UI/UX nằm ở bộ thư viện tự vẽ bằng Graphics (GDI+).

### 3.1 `ModernButton` & `RoundedPanel`
- Kế thừa lớp `Control` và `Panel`.
- Vô hiệu hóa nền mặc định: `SetStyle(ControlStyles.SupportsTransparentBackColor, true);`
- Dùng `GraphicsPath` kết hợp `Arc` để bo tròn góc chính xác 16 pixel.
- Gắn sự kiện `MouseEnter`, `MouseLeave`, `MouseDown` để thay đổi Invalidate đồ họa, tạo bóng gradient accent rực rỡ.

### 3.2 `ModernTrackBar`
- Thay thế hoàn toàn TrackBar cổ điển.
- Tự vẽ rãnh Track (màu xám tối), dải Progress (màu Accent theo Theme) và Thumb tròn trịa phát sáng khi tương tác.
- Lắng nghe event MouseMove tính toán tọa độ phần trăm để set thuộc tính `Value`.

### 3.3 `WaveformVisualizer`
- Một Component cực kỳ sinh động cho Center Editor. 
- Sử dụng `System.Windows.Forms.Timer` ở 20 FPS (Interval = 50ms).
- Sinh Random chiều cao của 24 thanh Rectangle dẹt (Bar) khi thuộc tính `IsPlaying = true`, và tự động giảm dần về 0 khi `IsPlaying = false`.

---

## CHƯƠNG 4. PHÁT TRIỂN WINUI 3 SEGMENTED CHIP BUTTONS

- Để thay thế `ComboBox`, dự án tạo ra component `SegmentedChipGroup`.
- Lớp này chứa nhiều `ChipButton` con xếp theo dạng hàng ngang (FlowLayoutPanel).
- Khi người dùng nhấp vào một Chip, thuật toán tự động bỏ trạng thái "Active" của các Chip khác và Highlight màu Accent cho Chip vừa nhấn.
- **Ứng dụng**: Rất phù hợp để chọn Sắc Độ (Mộc, Radio...), Trường Độ, Phong cách đọc.

---

## CHƯƠNG 5. MỞ RỘNG TÍNH NĂNG ÂM THANH (GRAPHIC EQUALIZER)

Trong `VoiceEditorForm`, có một lớp `ModernEqualizerControl`.
- **Thiết kế**: Bao gồm 10 Slider dọc (hoặc TrackBar dọc) ứng với dải tần chuẩn ISO (31Hz, 62Hz, 125Hz, 250Hz, 500Hz, 1kHz, 2kHz, 4kHz, 8kHz, 16kHz).
- **Phát triển Event `GainChanged`**:
  ```csharp
  public event EventHandler<EqualizerEventArgs> GainChanged;
  ```
- Khi một Slider bị kéo, Control sẽ bắn sự kiện chứa vị trí dải tần và chỉ số Gain (-12 đến +12).
- Tầng Service (`VieNeuTtsService`) sẽ nhận các thông số này để truyền sang Python (tham số `--eq`) nhằm xử lý tín hiệu DSP trước khi xuất file.

---

## CHƯƠNG 6. TÍCH HỢP BẰNG NATIVEMETHODS & SYSTEM HOOKS

Để vẽ cửa sổ ứng dụng phẳng hoàn toàn không có thanh viền truyền thống, nhưng vẫn cho phép kéo thả, ta cần sử dụng `NativeMethods.cs`:
- Dùng `P/Invoke` (DllImport) gọi thư viện `user32.dll`.
- Ghi đè hàm xử lý thông điệp Windows: `protected override void WndProc(ref Message m)` trong `MainForm`.
- Bắt thông điệp `WM_NCHITTEST` (0x84) để lừa Windows rằng người dùng đang bấm vào thanh tiêu đề, từ đó cho phép kéo Form đi.

---

## CHƯƠNG 7. TRIỂN KHAI VÀ XỬ LÝ LỖI (DEBUGGING)

### 7.1. Lỗi Mất Đồng Bộ Tiến Trình Python
- **Triệu chứng**: Giao diện treo 100% khi nhấn tạo giọng đọc dài.
- **Giải quyết**: Đảm bảo `Process.Start()` của Python được đặt bên trong khối lệnh `await Task.Run(() => { ... })` để giải phóng Main Thread của UI.

### 7.2. Lỗi Decimal/Float Locale Khác Biệt
- **Triệu chứng**: Khi truyền tham số Pitch = `1.5` qua CMD sang Python, một số máy bị lỗi thành `1,5` (dấu phẩy).
- **Giải quyết**: Ép kiểu chuỗi số tuyệt đối với `CultureInfo.InvariantCulture`.
  ```csharp
  string pitchParam = pitchValue.ToString("0.0", CultureInfo.InvariantCulture);
  ```

### 7.3. Đóng Gói Và Triển Khai
- Thư mục `.venv` của Python phải được mang theo cùng cấp với thư mục xuất bản `.exe`.
- Đảm bảo quyền truy cập đọc/ghi file trong cấu trúc đường dẫn thư mục lưu Output Audio không bị khoảng trắng hoặc Unicode hỏng. Hỗ trợ tốt ở Windows 10/11.

---
*(Tài liệu này được bảo trì cùng mã nguồn. Xin vui lòng tuân thủ quy tắc First Class Form Rule khi cập nhật các Component UI mới).*
