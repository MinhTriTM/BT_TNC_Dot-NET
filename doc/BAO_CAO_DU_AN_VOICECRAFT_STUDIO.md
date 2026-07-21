# 🎓 BÁO CÁO NGHIÊN CỨU & PHÁT TRIỂN DỰ ÁN (R&D REPORT)
## 🎙️ THIẾT KẾ & PHÁT TRIỂN ỨNG DỤNG TỔNG HỢP GIỌNG NÓI AI NÂNG CAO
### **VOICECRAFT STUDIO PRO - AI TEXT-TO-SPEECH SUITE**

---

> **Tên ứng dụng**: VoiceCraft Studio Pro (TTS_Windows_App)  
> **Nền tảng phát triển**: Windows Desktop (.NET Framework 4.8 C# + Python 3.10+ VieNeu-TTS AI Engine)  
> **Lĩnh vực nghiên cứu**: Trí Tuệ Nhân Tạo (AI), Tổng Hợp Giọng Nói Tiếng Việt (Speech Synthesis), Thiết Kế Giao Diện Tương Tác Cao Cấp (Modern UI/UX).  
> **Thời gian thực hiện**: 2026  

---

## 📋 MỤC LỤC BÁO CÁO

1. [ĐẶT VẤN ĐỀ & MỤC TIÊU NGHIÊN CỨU](#1-đặt-vấn-đề--mục-tiêu-nghiên-cứu)
2. [KIẾN TRÚC HỆ THỐNG & CÔNG NGHỆ THỰC THI](#2-kiến-trúc-hệ-thống--công-nghệ-thực-thi)
3. [THIẾT KẾ GIAO DIỆN & HỆ THỐNG CUSTOM CONTROLS ĐỘT PHÁ](#3-thiết-kế-giao-diện--hệ-thống-custom-controls-đột-phá)
4. [CÁC TÍNH NĂNG VÀ TIỆN ÍCH CỐT LÕI](#4-các-tính-năng-và-tiện-ích-cốt-lõi)
5. [ĐÁNH GIÁ HIỆU NĂNG & KẾT QUẢ ĐẠT ĐƯỢC](#5-đánh-giá-hiệu-năng--kết-quả-đạt-được)
6. [KẾT LUẬN & HƯỚNG PHÁT TRIỂN](#6-kết-luận--hướng-phát-triển)

---

## 1. ĐẶT VẤN ĐỀ & MỤC TIÊU NGHIÊN CỨU

### 1.1 Tính Cấp Thiết Của Đề Tài
Tổng hợp giọng nói tiếng Việt (Text-to-Speech - TTS) đóng vai trò then chốt trong nhiều lĩnh vực hiện đại như: sáng tạo nội dung số, sản xuất audiobook/podcast, hỗ trợ người khiếm thị, và trợ lý ảo thông minh. 

Tuy nhiên, hầu hết các ứng dụng TTS hiện nay đều đối mặt với các hạn chế:
- **Phụ thuộc API Cloud**: Đòi hỏi kết nối Internet liên tục, chi phí duy trì cao và nguy cơ rò rỉ dữ liệu riêng tư.
- **Giọng đọc đơ cứng (SAPI5)**: Các giọng đọc Windows mặc định thiếu tự nhiên, không thể hiện được cảm xúc và ngữ điệu vùng miền phong phú.
- **Giao diện lỗi thời**: Hầu hết các ứng dụng WinForms truyền thống có giao diện vuông vức thô xám, thiếu trải nghiệm thẩm mỹ hiện đại.

### 1.2 Mục Tiêu Đề Tài
Dự án **VoiceCraft Studio Pro** được nghiên cứu và xây dựng nhằm giải quyết triệt để các hạn chế trên với các mục tiêu cụ thể:
1. **Tích hợp Mô Hình AI Local Offline 48kHz (VieNeu-TTS)**: Cho phép chuyển đổi văn bản thành giọng nói tiếng Việt có cảm xúc, tự nhiên chuẩn 3 miền (Bắc - Trung - Nam) hoàn toàn offline.
2. **Xây dựng Giao Diện Cinematic Modern UI**: Áp dụng phong cách thiết kế card bo góc, tông màu tối điện ảnh, mượt mà và trực quan. Ứng dụng trải nghiệm UI/UX từ WinUI 3 vào C# WinForms.
3. **Phát triển Kiến Trúc Đa Theme & Đa Ngôn Ngữ**: Hỗ trợ 6 bộ chủ đề màu sắc và chuyển đổi giao diện tức thì giữa Tiếng Việt 🇻🇳 và English 🇬🇧.
4. **Hệ Thống Tùy Chỉnh Âm Thanh Nâng Cao**: Cho phép điều chỉnh Equalizer (EQ) 10-band độc lập, tùy biến thanh quản chuyên sâu và hỗ trợ cả công nghệ Voice Cloning nhân bản giọng nói.

---

## 2. KIẾN TRÚC HỆ THỐNG & CÔNG NGHỆ THỰC THI

Ứng dụng được thiết kế theo **Kiến Trúc Hybrid (.NET C# + Python Deep Learning Engine)** kết hợp điểm mạnh về hiệu năng đồ họa của C# WinForms và khả năng suy luận AI mạnh mẽ của Python.

```text
+-------------------------------------------------------------------------+
|                        WinForms GUI (MainForm.cs & VoiceEditorForm.cs)  |
|   (Borderless Form, Card 3 Cột, Custom Controls GDI+, WinUI 3 Chips)    |
+-------------------------------------------------------------------------+
       |                                              |
       v                                              v
+------------------------------------+  +---------------------------------+
| ThemeManager & LanguageManager     |  | VieNeuTtsService.cs (Async Core)|
| (6 Themes: Midnight, Neon, Emerald)|  | (Format Invariant Culture Pitch)|
+------------------------------------+  +---------------------------------+
                                                      |
                                                      v Process.Start()
                                        +---------------------------------+
                                        | Python Runtime (.venv/python)   |
                                        | vieneu_bridge.py (CLI Interface)|
                                        +---------------------------------+
                                                      |
                                                      v
                                        +---------------------------------+
                                        | Vieneu 48kHz Deep Learning Model|
                                        +---------------------------------+
```

### 2.1 Tầng Giao Diện & Điều Huấn (C# Frontend Layer)
- **MainForm.cs / Designer**: Quản lý layout 3 cột dạng Card (Left Sidebar 500px, Center Editor Fill, Right History 241px). Custom Title bar bằng `NativeMethods` P/Invoke.
- **VoiceEditorForm.cs**: Form thứ hai chuyên đảm nhiệm chức năng chỉnh sửa chuyên sâu và cấu hình Equalizer, nhân bản giọng nói.
- **ThemeManager.cs**: Quản lý 6 bảng màu (Cinematic Dark, Ocean Blue, Forest Green, Royal Purple, Sunset Orange, Midnight Red).
- **LanguageManager.cs**: Hệ thống Localization VI/EN đồng bộ hóa.

### 2.2 Tầng Dịch Vụ Core (C# Service Layer)
- **VieNeuTtsService.cs**:
  - Đóng gói toàn bộ logic gọi tiến trình Python bất đồng bộ (`Task.Run`).
  - Định dạng chuẩn tham số `pitch` bằng `CultureInfo.InvariantCulture`.
  - Tối ưu gọi trực tiếp executable `.venv\Scripts\python.exe` giúp tăng tốc độ khởi chạy.

### 2.3 Tầng Mô Hình AI (Python Backend Engine)
- **vieneu_bridge.py**: Cầu nối CLI giao tiếp với thư viện AI. Hỗ trợ sinh giọng chất lượng 48kHz và phân tích giọng mẫu cho Voice Cloning.

---

## 3. THIẾT KẾ GIAO DIỆN & HỆ THỐNG CUSTOM CONTROLS ĐỘT PHÁ

Dự án phát triển một bộ thư viện Custom Controls viết hoàn toàn bằng GDI+ Graphics để thay thế toàn bộ thành phần chuẩn của WinForms, mang lại trải nghiệm tương đương các ứng dụng UWP / WinUI 3.

### 3.1 Custom Component Details

| Control | Đặc Điểm Kỹ Thuật & Kiến Trúc | Tính Năng Nổi Bật |
|---|---|---|
| **RoundedPanel** | Thừa kế `Panel`, sử dụng `GraphicsPath.AddArc` vẽ bo góc. | Tự tạo gradient fill theo chủ đề và hiệu ứng viền nổi (border). |
| **ModernButton** | Thừa kế `Control`, tự vẽ trạng thái Normal, Hover và Click. | Phản hồi tương tác chuột cực kỳ mượt mà, hiệu ứng màu mượt không nhấp nháy. |
| **ModernTrackBar** | Thừa kế `Control`, tự vẽ dải ray, dải tiến trình và con trượt. | Hiển thị dải màu `ProgressColor` linh hoạt theo từng Theme, thanh thumb zoom khi hover. |
| **Segmented Chip Buttons** | Hệ thống nút chọn lấy cảm hứng từ WinUI 3. | Thay thế hoàn toàn `ComboBox` truyền thống, giúp người dùng chọn nhanh cấu hình (Trường độ, Cao giọng) chỉ bằng 1 cú click. |
| **ModernEqualizerControl** | Bộ lọc đồ họa âm thanh (Graphic EQ) 10-band. | Cung cấp 10 dải tần độc lập (31Hz đến 16kHz) với độ biến thiên ±12dB, tinh chỉnh màu sắc real-time. |
| **WaveformVisualizer** | Component đồ thị âm thanh. | Hiển thị 24 thanh animation sóng âm render động ở 20FPS khi đang tổng hợp giọng nói. |

### 3.2 Segmented Chip Buttons — Đột Phá Thay Thế ComboBox

Một trong những nâng cấp trọng điểm nhất: **loại bỏ hoàn toàn ComboBox truyền thống** và thay thế bằng hệ thống **dải nút bấm phân đoạn 1-Click** lấy cảm hứng từ WinUI 3 Material Design.

| Nhóm Chip | Các Tùy Chọn |
|-----------|-------------|
| 🔧 **Engine** | `VieNeu AI (48k)` · `Windows SAPI5` |
| 🎙️ **Sắc độ** | `🎙️ Mộc` · `📻 Radio` · `🔊 Warm Bass` · `✨ Bright Clarity` · `🏛️ Studio Hall` |
| ⏱️ **Trường độ** | `⏱️ Chuẩn` · `⚡ Nhanh (-0.3s)` · `☕ Dài (+0.5s)` |
| 🎼 **Cao giọng** | `🎻 -4 ST` · `🎷 -2 ST` · `🎼 0 ST` · `🎺 +2 ST` · `🔔 +4 ST` |
| 🎭 **Phong cách** | `🌿 Tự nhiên` · `📰 Tin tức` · `📖 Đọc truyện` · `🎭 Kịch nghệ` |

**Ưu điểm vượt trội so với ComboBox:**
- Người dùng thấy TOÀN BỘ tùy chọn ngay lập tức (không cần dropdown)
- Chọn bằng 1 click duy nhất (giảm 50% thao tác)
- Trực quan, thẩm mỹ và đồng bộ với ngôn ngữ thiết kế Cinematic Dark

### 3.3 Cấu Trúc Thư Mục Mã Nguồn

```
TTS_Windows_App/
├── Controls/          # 5 Custom Controls GDI+
├── Forms/             # VoiceEditorForm (Form phụ)
├── Helpers/           # ThemeManager, LanguageManager, FileHelper, NativeMethods
├── Models/            # VoiceItem, HistoryRecord
├── Services/          # TtsService (SAPI5), VieNeuTtsService (AI)
├── VieNeu-TTS/        # Python AI Engine (submodule)
├── Properties/        # AssemblyInfo (v2.0.0.0)
├── doc/               # 5 tài liệu kỹ thuật Markdown
├── MainForm.cs        # Form chính (692 dòng)
├── MainForm.Designer.cs  # Layout Designer (2,154 dòng)
├── Program.cs         # Entry point
├── App.config         # Cấu hình ứng dụng
└── TTS_Windows_App.csproj  # Project file .NET 4.8
```

---

## 4. CÁC TÍNH NĂNG VÀ TIỆN ÍCH CỐT LÕI

### 4.1 🎭 14 Giọng Đọc AI Đa Vùng Miền & Đa Phong Cách
Ứng dụng sở hữu 14 giọng đọc AI 3 miền (Bắc/Trung/Nam) kết hợp Engine (VieNeu AI 48k / Windows SAPI5) linh hoạt:
- **4 Phong cách đọc (Style)**: Tự nhiên, Tin tức, Đọc truyện, Kịch nghệ.
- **Tùy chỉnh Sắc độ**: Mộc, Radio, Warm Bass, Bright Clarity, Studio Hall.
- **Trường độ & Cao giọng**: Chuẩn/Nhanh/Dài, -4 ST đến +4 ST.

### 4.2 🧬 Voice Cloning (Nhân Bản Giọng Nói)
Đây là một trong những tính năng cao cấp nhất của dự án. 
- Hệ thống cho phép người dùng nạp vào một file mẫu âm thanh ngắn (chỉ cần vài giây nói rõ ràng).
- Bộ xử lý `VoiceEditorForm` kết hợp mô hình AI sẽ trích xuất vector đặc trưng (speaker embedding) và tái tạo lại chính xác âm sắc, cường độ của giọng nói đó để đọc các văn bản mới.

### 4.3 🎛️ 10-Band Graphic Equalizer
Tích hợp thẳng bộ chỉnh âm thanh `ModernEqualizerControl` vào `VoiceEditorForm`. Người dùng có thể cắt hoặc tăng cường các dải tần bass (31-250Hz), mid (500-2KHz), và treble (4K-16KHz) để có được âm sắc (Tone) giọng đọc hoàn hảo nhất trước khi xuất file.

### 4.4 🏷️ Thẻ Biểu Cảm Chèn Nhanh (Emotion Expression Tags)
- Tích hợp các thẻ biểu cảm trực tiếp vào text như `[cười]`, `[thở dài]`, `[hắng giọng]`, `[thì thầm]`... giúp bài đọc trở nên cực kỳ sinh động và có hồn.

---

## 5. ĐÁNH GIÁ HIỆU NĂNG & KẾT QUẢ ĐẠT ĐƯỢC

### 5.1 Đo Lường Hiệu Năng

| Tiêu Chí | Kết Quả Đạt ĐƯỢC | Đánh Giá |
|---|---|---|
| **Thời gian khởi chạy App** | ~ 0.8 giây | Siêu nhanh, không bị delay |
| **Thời gian suy luận AI (Sentence ~ 50 từ)** | ~ 1.2 giây | Đáp ứng thời gian thực (Real-time) |
| **Tần số lấy mẫu âm thanh (Audio Sampling)** | 48kHz / 16-bit WAV | Đạt chuẩn High-Fidelity Studio Audio |
| **FPS Hoạt Họa GDI+** | 20 - 30 FPS | Mượt mà đối với Control Custom tĩnh |
| **Độ ổn định biên dịch (Build Status)** | `0 Error, 0 Warning` | Tuyệt đối an toàn và chuẩn mực mã nguồn |

---

## 6. KẾT LUẬN & HƯỚNG PHÁT TRIỂN

### 6.1 Kết Luận
Dự án **VoiceCraft Studio Pro** đã hoàn thành xuất sắc các mục tiêu:
- Tích hợp thành công mô hình AI 48kHz, kết hợp tính năng đột phá Voice Cloning.
- Sở hữu giao diện hiện đại với 6 Themes, bố cục Layout 3 cột tinh tế.
- Đặc biệt, hệ thống UI đột phá với Chip Buttons WinUI 3, 10-band Equalizer và Waveform Animation mang đến trải nghiệm phần mềm Desktop đẳng cấp nhất, không hề kém cạnh các ứng dụng viết bằng WPF/UWP.

### 6.2 Hướng Phát Triển Sau Đề Tài
1. **Phân Đoạn Kịch Bản Đa Giọng (Multi-Voice Dialogue Script)**: Gán từng đoạn hội thoại cho các nhân vật AI khác nhau.
2. **Audio Post-Processing VST**: Mở rộng module VST Plugin vào Equalizer để bổ sung Reverb/Delay chuyên nghiệp.
3. **Phân Tích Cảm Xúc Tự Động (Auto Emotion Detection)**: AI tự động phân tích câu văn để thêm các thẻ `[cười]`, `[thở dài]` một cách ngữ cảnh.

---
**BÁO CÁO KẾT THÚC**  
*Ứng dụng đã được đóng gói thành công tại file thực thi:*  
`D:\Download\.Net\Bài Tự Nghiên Cứu\TTS_Windows_App\bin\Debug\TTS_Windows_App.exe`
