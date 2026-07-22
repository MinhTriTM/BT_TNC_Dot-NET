# Câu hỏi
Lỗi khi phát âm thanh: Lỗi VieNeu-TTS AI Engine: ERROR: No module named 'vieneu'

# Suy nghĩ (Thinking)
- Người dùng báo lỗi khi ứng dụng C# phát âm thanh (gọi VieNeu-TTS AI Engine) gặp lỗi Python: `ModuleNotFoundError: No module named 'vieneu'`.
- Kiểm tra cấu trúc thư mục của `VieNeu-TTS` phát hiện module `vieneu` nằm trong thư mục `src/vieneu`.
- Trong file `pyproject.toml`, thư mục `src` được cấu hình là root của package. Khi ứng dụng C# khởi chạy script `vieneu_bridge.py` bằng `python.exe` từ môi trường ảo `.venv`, thư mục `src` này không được tự động thêm vào `sys.path`.
- Giải pháp: Chỉnh sửa file `vieneu_bridge.py` để tự động xác định đường dẫn thư mục `src` (nằm cùng cấp với file bridge) và chèn nó vào đầu danh sách `sys.path`.
- Sau khi chỉnh sửa, thực hiện chạy thử lệnh `.venv\Scripts\python.exe vieneu_bridge.py --list-voices` trong terminal để xác minh. Kết quả chạy thành công và trả về danh sách giọng nói dạng JSON mà không còn lỗi.

# Câu trả lời
Lỗi `ERROR: No module named 'vieneu'` xảy ra do Python không tìm thấy thư mục `src` (nơi chứa source code của module `vieneu`) trong đường dẫn tìm kiếm `sys.path` khi file `vieneu_bridge.py` được gọi từ ứng dụng C#.

Tôi đã khắc phục lỗi này bằng cách cập nhật file `vieneu_bridge.py` để tự động thêm thư mục `src` vào `sys.path` khi khởi chạy:
```diff
+ # Thêm thư mục 'src' vào sys.path để có thể import 'vieneu'
+ bridge_dir = os.path.dirname(os.path.abspath(__file__))
+ src_dir = os.path.join(bridge_dir, "src")
+ if os.path.exists(src_dir) and src_dir not in sys.path:
+     sys.path.insert(0, src_dir)
```
Đã kiểm tra thử nghiệm và bộ công cụ chạy ổn định. Bạn có thể khởi chạy lại ứng dụng C# WinForms và phát âm thanh bình thường.
