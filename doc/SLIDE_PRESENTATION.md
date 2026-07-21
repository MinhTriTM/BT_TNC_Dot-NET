# 📊 SLIDE THUYẾT TRÌNH — VOICECRAFT STUDIO PRO

> Nội dung 15 slides phục vụ báo cáo thuyết trình dự án. Mỗi slide gồm tiêu đề, nội dung chính và ghi chú cho người trình bày.

---

## 🎬 SLIDE 1: TRANG TIÊU ĐỀ

**🎙️ VOICECRAFT STUDIO PRO**
*AI Text-To-Speech & Audio Engineering Matrix*

- **Môn học:** Bài Tự Nghiên Cứu — Tin Học Ứng Dụng
- **Nền tảng:** .NET Framework 4.8 | C# WinForms
- **Tác giả:** MinhTriTM
- **GitHub:** [BT_TNC_Dot-NET](https://github.com/MinhTriTM/BT_TNC_Dot-NET)

---

## 🎬 SLIDE 2: ĐẶT VẤN ĐỀ & MỤC TIÊU

### Vấn đề
- Các phần mềm TTS miễn phí: giọng đọc robot, không tự nhiên
- SAPI5 Windows: phản hồi nhanh nhưng chất lượng thấp
- Dịch vụ cloud (Google, Azure): cần internet, tốn phí

### Mục tiêu
- ✅ Xây dựng TTS chất lượng 48kHz **offline 100%**
- ✅ Giao diện **Cinematic Dark** hiện đại, chuyên nghiệp
- ✅ Kiến trúc **Hybrid** C# + Python Deep Learning
- ✅ **14 giọng đọc AI** đa vùng miền Bắc/Trung/Nam

---

## 🎬 SLIDE 3: KIẾN TRÚC HỆ THỐNG HYBRID

```
┌─────────────────────────────────────────────┐
│           C# WinForms (.NET 4.8)            │
│  ┌──────────┐ ┌──────────┐ ┌──────────────┐│
│  │MainForm  │ │ Controls │ │   Helpers    ││
│  │(3 cột)   │ │  (GDI+)  │ │(Theme/Lang)  ││
│  └────┬─────┘ └──────────┘ └──────────────┘│
│       │                                     │
│  ┌────▼─────┐        ┌─────────────────┐   │
│  │TtsService│        │VieNeuTtsService  │   │
│  │ (SAPI5)  │        │(Python Bridge)   │   │
│  └──────────┘        └───────┬─────────┘   │
└──────────────────────────────┼──────────────┘
                               │ ProcessStartInfo
                    ┌──────────▼──────────┐
                    │  VieNeu-TTS Engine   │
                    │  (Python 48kHz AI)   │
                    └─────────────────────┘
```

---

## 🎬 SLIDE 4: THIẾT KẾ GIAO DIỆN CINEMATIC DARK

- **Layout 3 cột**: Left Sidebar (500px) | Center Editor (Fill) | Right History (241px)
- **Form Borderless**: Custom title bar, kéo di chuyển qua P/Invoke Win32
- **Bảng màu**: RGB(20, 20, 24) nền chính, gradient panel, neon glow
- **Typography**: Segoe UI 11.5F cho vùng soạn thảo
- **Menu + Toolbar + StatusBar**: Đầy đủ chức năng chuyên nghiệp

---

## 🎬 SLIDE 5: CUSTOM CONTROLS GDI+ (5 CONTROLS)

| Control | Mô tả |
|---------|-------|
| 🔘 **ModernButton** | Nút bấm bo góc, đổi màu Hover/Click |
| 🎚️ **ModernTrackBar** | Thanh trượt với progress fill, thumb zoom |
| 📦 **RoundedPanel** | Panel bo góc 16px, gradient fill |
| 🎛️ **ModernEqualizerControl** | 10-Band Graphic EQ (31Hz-16kHz) |
| 🌊 **WaveformVisualizer** | Phổ sóng 24 thanh animation 20FPS |

- Tất cả sử dụng `System.Drawing.Drawing2D` (GDI+)
- `DoubleBuffered = true` chống nhấp nháy

---

## 🎬 SLIDE 6: SEGMENTED CHIP BUTTONS WinUI 3

Thay thế hoàn toàn ComboBox truyền thống bằng dải nút bấm 1-Click:

| Nhóm | Tùy chọn |
|------|----------|
| 🔧 **Engine** | VieNeu AI (48k) · Windows SAPI5 |
| 🎙️ **Sắc độ** | Mộc · Radio · Warm Bass · Bright Clarity · Studio Hall |
| ⏱️ **Trường độ** | Chuẩn · Nhanh (-0.3s) · Dài (+0.5s) |
| 🎼 **Cao giọng** | -4 ST · -2 ST · 0 ST · +2 ST · +4 ST |
| 🎭 **Phong cách** | Tự nhiên · Tin tức · Đọc truyện · Kịch nghệ |

---

## 🎬 SLIDE 7: DUAL ENGINE — SAPI5 + VieNeu AI

| Tiêu chí | Windows SAPI5 | VieNeu AI |
|----------|--------------|-----------|
| Chất lượng | Trung bình | Cao (48kHz) |
| Latency | ~0ms | ~1.2s |
| Offline | ✅ | ✅ |
| Tiếng Việt | Hạn chế | 14 giọng 3 miền |
| Phong cách | Không | 4 phong cách |
| Voice Cloning | Không | ✅ |

---

## 🎬 SLIDE 8: 14 GIỌNG AI 3 MIỀN + 4 PHONG CÁCH

- **Miền Bắc**: Hoài My, Nam Minh, Thanh Hà, Minh Đức, Lan Anh
- **Miền Trung**: Thảo Nguyên, Quốc Huy
- **Miền Nam**: Phương Linh, Trường An, Bích Ngọc, Hùng Vương
- **Đặc biệt**: MC Truyền hình, Giọng đọc sách, Phát thanh viên

**4 Phong cách đọc:**
🌿 Tự nhiên | 📰 Tin tức | 📖 Đọc truyện | 🎭 Kịch nghệ

---

## 🎬 SLIDE 9: 10-BAND GRAPHIC EQUALIZER

- **Dải tần**: 31Hz · 63Hz · 125Hz · 250Hz · 500Hz · 1kHz · 2kHz · 4kHz · 8kHz · 16kHz
- **Gain**: ±12dB mỗi dải
- **Giao diện**: Cần gạt kéo thả, hiển thị dB real-time
- **Màu sắc**: Xanh dương (gain dương) / Đỏ hồng (gain âm)
- **Sự kiện**: `GainChanged` cập nhật ngay lập tức

---

## 🎬 SLIDE 10: VOICE CLONING 🧬

- **Chức năng**: Nhân bản giọng đọc từ file âm thanh mẫu ngắn (~5-10 giây)
- **Định dạng hỗ trợ**: WAV, MP3
- **Workflow**: Tick checkbox → Chọn file mẫu → AI phân tích → Tổng hợp giọng mới
- **Ứng dụng**: Tạo giọng đọc cá nhân hóa

---

## 🎬 SLIDE 11: 6 THEMES + ĐA NGÔN NGỮ

**6 Bảng màu giao diện:**
🌑 Cinematic Dark | 🌊 Ocean Blue | 🌲 Forest Green | 👑 Royal Purple | 🌅 Sunset Orange | 🌙 Midnight Red

**Đa ngôn ngữ:**
- 🇻🇳 Tiếng Việt (mặc định)
- 🇬🇧 English

Chuyển đổi real-time, không cần khởi động lại ứng dụng.

---

## 🎬 SLIDE 12: EMOTION TAGS & DRAG-DROP

**Thẻ biểu cảm chèn nhanh:**
😄 [cười] | 😮‍💨 [thở dài] | 😤 [hắng giọng] | 🤫 [thì thầm]

**Kéo thả file:**
- Kéo file `.txt` → Tự động mở nội dung vào vùng soạn thảo
- Kéo file `.wav` / `.mp3` → Tự động gán làm mẫu Voice Cloning
- Hỗ trợ đa encoding: UTF-8, UTF-16, cp1258

---

## 🎬 SLIDE 13: XUẤT WAV & LỊCH SỬ ĐỌC

**Xuất file âm thanh:**
- Định dạng: WAV (48kHz/16-bit)
- Hỗ trợ cả 2 engine (SAPI5 + VieNeu)
- Lưu bằng SaveFileDialog tiêu chuẩn

**Lịch sử đọc:**
- Sidebar phải hiển thị danh sách lịch sử
- Thông tin: Văn bản, Giọng đọc, Thời gian, Số ký tự
- Nút xóa toàn bộ lịch sử

---

## 🎬 SLIDE 14: KẾT QUẢ ĐẠT ĐƯỢC

| Tiêu chí | Kết quả |
|----------|---------|
| Biên dịch | ✅ Build Succeeded (0 Error, 0 Warning) |
| Tổng dòng code C# | ~3,500+ dòng |
| Custom Controls | 5 controls GDI+ tùy chỉnh |
| Giọng AI | 14 giọng đa vùng miền |
| Themes | 6 bảng màu chuyên nghiệp |
| GitHub | ✅ Đã đẩy lên repository |

---

## 🎬 SLIDE 15: KẾT LUẬN & HƯỚNG PHÁT TRIỂN

### Kết luận
- Dự án minh chứng khả năng kết hợp **C# .NET** và **Python AI** trong phát triển phần mềm desktop
- Giao diện Cinematic Dark đạt chuẩn thương mại
- Kiến trúc Hybrid mở rộng tốt

### Hướng phát triển
- 🎵 Multi-voice dialogue (nhiều giọng đọc trong 1 đoạn văn)
- 📄 Hỗ trợ PDF/DOCX/OCR
- 🌐 Mở rộng thêm ngôn ngữ (Nhật, Hàn, Trung)
- 📱 Phiên bản .NET MAUI cross-platform

**CẢM ƠN! HỎI ĐÁP 💬**
