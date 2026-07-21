# 📊 SLIDE THUYẾT TRÌNH BÀI TẬP NGHIÊN CỨU & PHÁT TRIỂN
## MÔN HỌC: LẬP TRÌNH .NET (C# WINDOWS FORMS)
**CHỦ ĐỀ**: XÂY DỰNG ỨNG DỤNG AI TEXT-TO-SPEECH - VOICECRAFT STUDIO PRO  

---

### 🎬 SLIDE 1: TRANG TIÊU ĐỀ
- **Tên đề tài**: VoiceCraft Studio Pro - AI Text-to-Speech & Voice Cloning
- **Nền tảng**: C# WinForms (.NET 4.8) kết hợp Python Deep Learning
- **Nhóm thực hiện**: Nhóm Nghiên Cứu Tiện Ích
- **Giảng viên hướng dẫn**: [Tên Giảng Viên]

---

### 🎬 SLIDE 2: ĐẶT VẤN ĐỀ & MỤC TIÊU
- **Hạn chế của ứng dụng TTS hiện tại**:
  - Giao diện WinForms cổ điển thô xám, thiếu sức sống.
  - Phụ thuộc API Internet đắt đỏ hoặc sử dụng SAPI5 đơ cứng của Windows.
- **Mục tiêu dự án**:
  - Tích hợp mô hình AI VieNeu-TTS chạy Local hoàn toàn (48kHz audio).
  - Đập bỏ UI truyền thống, xây dựng Custom Controls GDI+ mô phỏng WinUI 3.
  - Bổ sung công cụ xử lý âm thanh chuyên nghiệp: Graphic EQ và Voice Cloning.

---

### 🎬 SLIDE 3: KIẾN THỨC NỀN TẢNG & CÔNG NGHỆ
- **Frontend**: C# WinForms, GDI+ Graphics (Tự vẽ control không cần thư viện ngoài).
- **Backend**: Python 3.10+, tiến trình bất đồng bộ (`Process.Start()`).
- **Xử lý đồ hoạ & Hệ thống**:
  - `System.Drawing.Drawing2D`: Dựng hiệu ứng Gradient, Anti-alias, Bo góc 16px.
  - `NativeMethods` (User32.dll): Làm Title bar tràn viền hiện đại.
  - Đa ngôn ngữ (VI/EN) và 6 Theme màu thời gian thực.

---

### 🎬 SLIDE 4: KIẾN TRÚC MÃ NGUỒN & HỆ THỐNG FORM
- Dự án áp dụng mô hình phân tầng chặt chẽ (Hybrid C# - Python):
  - **`Forms`**: `MainForm.cs` (Giao diện 3 cột) và `VoiceEditorForm.cs` (Form chỉnh sửa chuyên sâu, EQ, Voice Cloning).
  - **`Models & Services`**: `TtsService.cs` (SAPI5) và `VieNeuTtsService.cs` (Python AI).
  - **`Helpers`**: `ThemeManager`, `LanguageManager`, `CustomVoiceManager`.
  - **`Controls`**: Kho 6 controls GDI+ tự code hoàn toàn.

---

### 🎬 SLIDE 5: THIẾT KẾ GIAO DIỆN (UI/UX) - LAYOUT 3 CỘT
- Khai thác tối đa không gian màn hình với bố cục:
  - **Left Sidebar (500px)**: Chứa toàn bộ Controls tùy chỉnh Giọng đọc, Tốc độ, Engine...
  - **Center Editor (Fill)**: Vùng nhập liệu siêu lớn, tích hợp đếm từ/ký tự, Waveform Visualizer.
  - **Right History (241px)**: Danh sách lịch sử khởi tạo văn bản theo thời gian thực.
  - **Custom Titlebar**: Tràn viền (Borderless), có thể kéo thả cửa sổ trơn tru.

---

### 🎬 SLIDE 6: ĐỘT PHÁ UI/UX - WINUI 3 CHIP BUTTONS
- **Vấn đề**: ComboBox trong WinForms cần quá nhiều thao tác (click mở -> cuộn -> chọn).
- **Giải pháp**: Xây dựng thành phần `Segmented Chip Buttons`.
- **Tính năng**:
  - Nút bấm dẹt, dàn ngang, thao tác chỉ bằng 1 cú Click.
  - Hỗ trợ các trường chọn:
    - Engine: VieNeu AI / SAPI5.
    - Sắc độ: Mộc / Radio / Warm Bass / Bright / Studio.
    - Trường độ / Cao giọng / Phong cách (Tin tức, Kịch nghệ...).

---

### 🎬 SLIDE 7: HỆ THỐNG CUSTOM CONTROLS GDI+
- Không dùng thư viện Nuget của bên thứ 3, nhóm tự phát triển:
  - **`RoundedPanel`**: Đổ bóng gradient mượt mà, bo viền chuẩn 16px.
  - **`ModernButton`**: Trạng thái Hover/Click phát sáng (Accent Color).
  - **`ModernTrackBar`**: Thanh trượt Progress Fill có Thumb Zoom khi di chuột.
  - **`WaveformVisualizer`**: 24 thanh sóng âm 20FPS chạy hiệu ứng động khi đang render giọng nói.

---

### 🎬 SLIDE 8: CÔNG CỤ XỬ LÝ ÂM THANH - 10-BAND GRAPHIC EQ
- Tính năng chuyên biệt nằm trong `VoiceEditorForm`:
- **`ModernEqualizerControl`**:
  - Cung cấp 10 dải tần độc lập (Từ 31Hz đến 16kHz).
  - Có thể Tăng/Giảm (Gain) trong khoảng ±12dB.
  - Thiết kế dạng Mixer bàn DJ chân thực, cho phép tinh chỉnh màu giọng, độ vang và độ ấm trầm của AI trước khi xuất file.

---

### 🎬 SLIDE 9: TÍNH NĂNG NÂNG CAO - VOICE CLONING (NHÂN BẢN GIỌNG)
- Ứng dụng đột phá của trí tuệ nhân tạo:
  - **Đầu vào**: Một đoạn âm thanh mẫu (.wav) ngắn từ 3-5 giây.
  - **Quá trình**: Python Backend phân tích phổ, trích xuất Speaker Embedding.
  - **Đầu ra**: Văn bản mới được đọc hoàn toàn bằng âm sắc của giọng nói mẫu.
- Giúp cá nhân hóa ứng dụng hoặc khôi phục giọng nói kỹ thuật số.

---

### 🎬 SLIDE 10: QUẢN LÝ 14 GIỌNG ĐỌC & EMOTION TAGS
- **Kho dữ liệu 14 giọng 3 miền**: Trúc Ly, Phạm Tuyên, Minh Đức, Thái Sơn, Thùy Dung, Quang Sơn...
- **Emotion Tags**: Cho phép chèn nhanh các nhãn cảm xúc vào TextBox:
  - `[cười]` / `[thở dài]` / `[hắng giọng]` / `[thì thầm]`.
- Giúp đoạn văn bản bớt "máy móc" và có hồn hệt như con người.

---

### 🎬 SLIDE 11: 6 THEMES & ĐA NGÔN NGỮ ĐỒNG BỘ
- Quản lý đồng bộ bằng `ThemeManager` & `LanguageManager`:
  - 6 Chủ đề màu sắc (Cinematic Dark, Ocean Blue, Forest Green, Royal Purple, Sunset Orange, Midnight Red).
  - Các Component GDI+ tự động nhận sự kiện đổi Theme và vẽ lại (Invalidate) mượt mà, không giật lag.
  - Cập nhật ngôn ngữ (Việt/Anh) tức thì không cần khởi động lại.

---

### 🎬 SLIDE 12: ĐÁNH GIÁ HIỆU NĂNG & KẾT QUẢ ĐẠT ĐƯỢC
- Dự án compile hoàn toàn sạch: `0 Error, 0 Warning`.
- Khởi động < 1 giây, sinh giọng nói AI 50 từ trong ~1.2s.
- Mã nguồn OOP chặt chẽ, tối ưu First Class Form Rule cho WinForms Designer (không bị lỗi Designer kéo thả).

---

### 🎬 SLIDE 13: KẾT LUẬN & HƯỚNG PHÁT TRIỂN TIẾP THEO
- **Thành quả**: Một sản phẩm ứng dụng Desktop vượt qua giới hạn của WinForms cũ, mang đẳng cấp phần mềm thương mại.
- **Hướng phát triển**:
  - Hỗ trợ thêm Audio Plugin VST (Reverb, Echo).
  - Tạo luồng sinh Audio Real-time streaming không cần đợi tải toàn bộ văn bản.
- **Q&A**: Cảm ơn Thầy/Cô và các bạn đã lắng nghe. Hỏi và Đáp.
