# Câu hỏi
Lỗi khi phát âm thanh: Lỗi VieNeu-TTS AI Engine: ERROR: Voice 'Trúc Ly (Nữ · Bắc · Tự nhiên)' not found. Available: ['Minh Đức', 'Phạm Tuyên', 'Thái Sơn', 'Xuân Vĩnh', 'Thanh Bình', 'Trúc Ly', 'Ngọc Linh', 'Đoan Trang', 'Mai Anh', 'Thục Đoan', 'Minh Triết', 'Thùy Dung', 'Quang Sơn', 'Ngọc Trân']

# Suy nghĩ (Thinking)
- Người dùng báo lỗi khi phát âm thanh do AI Engine không tìm thấy giọng nói có tên `'Trúc Ly (Nữ · Bắc · Tự nhiên)'`.
- Kiểm tra danh sách các giọng nói khả dụng của Python engine thì chỉ chứa các ID ngắn như `['Trúc Ly', 'Phạm Tuyên', 'Thái Sơn', ...]`.
- Nguyên nhân: Ứng dụng C# WinForms nạp ComboBox với tên hiển thị đầy đủ (Ví dụ: `Trúc Ly (Nữ · Bắc · Tự nhiên)`) và truyền nguyên văn chuỗi này qua tham số `--voice` khi gọi script Python.
- Giải pháp: Chỉnh sửa file `vieneu_bridge.py` để chuẩn hóa tham số `--voice` trước khi gọi `engine.infer`. Nếu chuỗi chứa ký tự mở ngoặc `(`, thực hiện cắt chuỗi lấy phần trước đó và `strip()` khoảng trắng dư thừa để thu được ID ngắn chính xác.
- Thực hiện chạy thử nghiệm: `.venv\Scripts\python.exe vieneu_bridge.py --text "Xin chào" --voice "Trúc Ly (Nữ · Bắc · Tự nhiên)" --output test.wav`. Lệnh chạy thành công và in ra `SUCCESS: test.wav`.

# Câu trả lời
Lỗi `'Voice not found'` xảy ra do ứng dụng WinForms truyền tên hiển thị đầy đủ của giọng nói (ví dụ: `Trúc Ly (Nữ · Bắc · Tự nhiên)`) qua tham số `--voice`, trong khi AI Engine phía Python chỉ nhận dạng các ID ngắn gọn (như `Trúc Ly`).

Tôi đã xử lý lỗi này một cách triệt để và an toàn tại file [vieneu_bridge.py](file:///D:/Download/.Net/Bài%20Tự%20Nghiên%20Cứu/BT_TNC_Dot-NET/VieNeu-TTS/vieneu_bridge.py):
```diff
             else:
-                audio = engine.infer(args.text, voice=args.voice, style=args.style)
+                voice_name = args.voice
+                if "(" in voice_name:
+                    voice_name = voice_name.split("(")[0].strip()
+                audio = engine.infer(args.text, voice=voice_name, style=args.style)
```
Sau khi chuẩn hóa, lệnh sinh âm thanh đã thực thi thành công tốt đẹp (`SUCCESS: test.wav`). Bây giờ ứng dụng C# WinForms đã có thể phát âm thanh bình thường mà không gặp lỗi không tìm thấy giọng nói.
