# 📖 HƯỚNG DẪN SỬ DỤNG VOICECRAFT STUDIO PRO

Welcome đến với phần mềm **VoiceCraft Studio Pro** — Ứng dụng chuyển đổi văn bản thành giọng nói AI (.NET 4.8) kết hợp bộ xử lý âm thanh phòng thu đỉnh cao.

---

## 1. HƯỚNG DẪN SOẠN THẢO VĂN BẢN & KÉO THẢ (DRAG & DROP)

- **Nhập trực tiếp**: Nhập văn bản cần đọc vào khung hình chữ nhật ở giữa màn hình.
- **Kéo - Thả File (`.txt`)**: Nắm kéo file văn bản `.txt` từ ngoài máy tính thả thẳng vào ô soạn thảo để nạp nội dung tự động.
- **Chèn cảm xúc bằng 1-Click**: Bấm vào các thẻ cảm xúc bên dưới khung soạn thảo như `+ [cười]`, `+ [thở dài]`, `+ [hắng giọng]`, `+ [thì thầm]` để thêm sắc thái biểu cảm vào câu đọc.

---

## 2. BỘ THẺ NÚT BẤM DẠNG CHIP (SEGMENTED CHIP BUTTONS)

Người dùng có thể tùy chỉnh các thuộc tính giọng nói dễ dàng qua các dải nút bấm **1-Click**:

| Tên Dải Nút | Các Thẻ Tùy Chọn (Chips) | Công Dụng |
| :--- | :--- | :--- |
| **⚙️ TTS Engine** | `🦜 VieNeu AI (48k)` \| `🔊 Windows SAPI5` | Chọn bộ máy đọc AI cao cấp hoặc chuẩn Windows |
| **🎙️ Sắc Độ & Âm Giọng** | `🎙️ Mộc` \| `📻 Radio` \| `🔊 Warm Bass` \| `✨ Bright Clarity` \| `🏛️ Studio Hall` | Thay đổi chất âm phòng thu (mộc, trầm ấm, sáng, vang studio) |
| **⏱️ Trường Độ & Ngắt Câu** | `⏱️ Chuẩn` \| `⚡ Nhanh (-0.3s)` \| `☕ Dài (+0.5s)` | Tùy chỉnh độ dài câu ngắt nghỉ tự nhiên |
| **🎼 Cao Giọng (Semitones)** | `🎻 -4 ST` \| `🎷 -2 ST` \| `🎼 0 ST` \| `🎺 +2 ST` \| `🔔 +4 ST` | Tăng/giảm tông giọng đọc (Nam trầm, Nữ cao, giọng em bé) |
| **🎭 Phong Cách Đọc** | `🌿 Tự nhiên` \| `📰 Tin tức` \| `📖 Đọc truyện` \| `🎭 Kịch nghệ` | Lựa chọn phong cách diễn cảm theo chủ đề văn bản |

---

## 3. BÀN NÂNG CẤP EQUALIZER 10 DẢI TẦN (GRAPHIC EQ SLIDERS)

Tích hợp bộ Graphic Equalizer 10 dải tần Hz chuẩn Studio Mixer:
- Các dải tần số: `31Hz`, `63Hz`, `125Hz`, `250Hz`, `500Hz`, `1kHz`, `2kHz`, `4kHz`, `8kHz`, `16kHz`.
- **Kéo lên (>0dB)**: Tăng biên độ dải tần tương ứng (Cyan Active).
- **Kéo xuống (<0dB)**: Giảm biên độ dải tần tương ứng (Red Active).

---

## 4. CHẾ ĐỘ NHÂN BẢN GIỌNG NÓI (VOICE CLONING)

1. Tích chọn checkbox **[x] Bật Chế Độ Clone Giọng Riêng**.
2. Bấm nút `🎙️ Nạp Mẫu Giọng (.wav / .mp3)` hoặc kéo thả file âm thanh ngắn (5s - 15s) từ máy tính vào ứng dụng.
3. Bấm `▶ ĐỌC VĂN BẢN (F5)` để bộ máy AI tổng hợp giọng mới theo đúng âm điệu file mẫu.

---

## 5. XUẤT TỆP ÂM THANH WAV (EXPORT AUDIO)

- Bấm nút `💾 Xuất File Âm Thanh (.wav)` ở cột công cụ trái hoặc bấm `Ctrl + S`.
- Chọn vị trí lưu file và tận hưởng âm thanh chất lượng cao 48kHz.
