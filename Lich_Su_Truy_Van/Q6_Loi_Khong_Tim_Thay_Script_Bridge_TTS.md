# Truy vấn 6: Lỗi Không Tìm Thấy Script Bridge VieNeu-TTS

## Câu hỏi của người dùng
Lỗi khi phát âm thanh: Không tìm thấy script bridge: D:\Download\.Net\Bài Tự Nghiên Cứu\TTS_Windows_App\VieNeu-TTS\vieneu_bridge.py

## Suy nghĩ (Thinking) của Agent
1. **Phân tích lỗi**:
   - Lỗi phát sinh từ `VieNeuTtsService.cs` khi kiểm tra sự tồn tại của file `vieneu_bridge.py` tại đường dẫn `_vieNeuDir`.
   - Đường dẫn bị báo lỗi là `D:\Download\.Net\Bài Tự Nghiên Cứu\TTS_Windows_App\VieNeu-TTS\vieneu_bridge.py`.
   - Tuy nhiên, dự án hiện tại đang nằm ở `D:\Download\.Net\Bài Tự Nghiên Cứu\BT_TNC_Dot-NET`. Thư mục `VieNeu-TTS` thực tế nằm ở `D:\Download\.Net\Bài Tự Nghiên Cứu\BT_TNC_Dot-NET\VieNeu-TTS`.

2. **Nguyên nhân**:
   - Trong `MainForm.cs` khởi tạo `VieNeuTtsService` bằng cách lấy `Application.StartupPath` kết hợp với `"VieNeu-TTS"`.
   - Khi chạy debug, file thực thi nằm trong thư mục `bin\Debug`, nên đường dẫn `Application.StartupPath\VieNeu-TTS` không tồn tại.
   - Code cũ thực hiện fallback bằng cách gán cứng (hardcode) đường dẫn tuyệt đối của máy cũ: `D:\Download\.Net\Bài Tự Nghiên Cứu\TTS_Windows_App\VieNeu-TTS`.
   - Do thư mục hiện tại của người dùng là `BT_TNC_Dot-NET` chứ không phải `TTS_Windows_App`, đường dẫn hardcode này bị sai và chương trình không tìm thấy file `vieneu_bridge.py`.

3. **Giải pháp**:
   - Thay thế việc gán cứng đường dẫn tuyệt đối bằng thuật toán tìm kiếm động ngược lên các thư mục cha từ thư mục khởi chạy (`Application.StartupPath`) để định vị thư mục `VieNeu-TTS` (thường nằm ở thư mục gốc của project khi phát triển).
   - Nếu vẫn không tìm thấy bằng thuật toán động, mới fallback về đường dẫn dự án hiện tại: `D:\Download\.Net\Bài Tự Nghiên Cứu\BT_TNC_Dot-NET\VieNeu-TTS`.

## Câu trả lời cuối cùng
Đã cập nhật mã nguồn trong `MainForm.cs` để tự động dò tìm thư mục `VieNeu-TTS` bằng cách quét ngược lên thư mục cha của ứng dụng thay vì sử dụng đường dẫn tuyệt đối cố định của máy cũ. Điều này giúp ứng dụng hoạt động chính xác trong cả môi trường Dev (chạy debug trong `bin\Debug`) lẫn môi trường Release/Production mà không bị lỗi thiếu file bridge.
