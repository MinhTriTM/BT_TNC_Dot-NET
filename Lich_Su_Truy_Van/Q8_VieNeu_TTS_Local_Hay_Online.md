# Câu hỏi
"D:\Download\.Net\Bài Tự Nghiên Cứu\BT_TNC_Dot-NET\VieNeu-TTS" là local hay online vậy, sao tôi tắt mạng thì BT_TNC_Dot-NET không chạy

# Suy nghĩ (Thinking)
- **Kiểm tra bản chất của VieNeu-TTS**: Khi đọc `README.vi.md`, đây là một thư viện Text-to-Speech (TTS) hỗ trợ clone giọng nói và chạy hoàn toàn offline (local) trên thiết bị của người dùng (on-device).
- **Phân tích mã nguồn Python của VieNeu-TTS**:
  - Trong `v3turbo.py` and `onnx_runtime_lite.py` (nằm trong thư mục `src/vieneu/_v3_turbo_engine`), chương trình sử dụng thư viện `huggingface_hub` (hàm `hf_hub_download`) để tự động tải các file đồ thị mô hình ONNX (`vieneu_prefill.onnx`, `vieneu_decode_step.onnx`, v.v.) từ repository trực tuyến `pnnbao-ump/VieNeu-TTS-v3-Turbo` và các file codec từ `OpenMOSS-Team/MOSS-Audio-Tokenizer-Nano-ONNX`.
- **Nguyên nhân khi tắt mạng ứng dụng BT_TNC_Dot-NET không chạy được**:
  1. **Lần đầu khởi chạy**: Nếu người dùng chưa bao giờ chạy ứng dụng khi có mạng, các file mô hình ONNX và codec chưa được tải về bộ nhớ cache cục bộ (thường lưu ở thư mục `C:\Users\<User>\.cache\huggingface\hub`). Khi tắt mạng, thư viện Python không thể tải file và sẽ crash, trả về mã lỗi (Exit Code != 0) khiến C# báo lỗi AI Engine.
  2. **Cơ chế kiểm tra trực tuyến (Check Update) của Hugging Face**: Kể cả khi đã tải đầy đủ mô hình về cache, mặc định thư viện `huggingface_hub` khi khởi tạo vẫn thực hiện gửi yêu cầu HTTP để kiểm tra xem có phiên bản cập nhật mới hơn của file trên Hugging Face Hub hay không (so sánh ETag/commit hash). Nếu tắt mạng đột ngột mà không cấu hình chế độ Offline, tiến trình kiểm tra này sẽ bị lỗi (timeout hoặc connection error) và gây crash.
- **Giải pháp xử lý**:
  - Người dùng cần kết nối mạng ít nhất một lần để ứng dụng tải và lưu mô hình vào cache thành công.
  - Khi đã có cache, để ứng dụng chạy offline thực thụ mà không bị nghẽn ở bước kiểm tra trực tuyến của Hugging Face Hub, cần thiết lập biến môi trường `HF_HUB_OFFLINE=1` cho tiến trình chạy Python.

# Câu trả lời
**VieNeu-TTS** là một thư viện chuyển đổi văn bản thành giọng nói (TTS) **chạy Local (offline) trên thiết bị**. Tuy nhiên, lý do khi bạn tắt mạng thì ứng dụng `BT_TNC_Dot-NET` không chạy được là do:

1. **Chưa tải mô hình (Model Checkpoints) lần đầu**: VieNeu-TTS không đi kèm sẵn các file mô hình nặng hàng trăm MB đến vài GB trong mã nguồn. Khi bạn chạy lần đầu tiên, thư viện Python sẽ tự động kết nối với **Hugging Face Hub** để tải các file mô hình (`pnnbao-ump/VieNeu-TTS-v3-Turbo` và `OpenMOSS-Team/MOSS-Audio-Tokenizer-Nano-ONNX`) về máy của bạn. Nếu bạn tắt mạng ngay từ đầu, chương trình sẽ không có mô hình để chạy và báo lỗi.
2. **Cơ chế kiểm tra cập nhật của Hugging Face**: Kể cả sau khi đã tải mô hình về cache local (thường ở `C:\Users\<Tên_User>\.cache\huggingface\hub`), mặc định thư viện `huggingface_hub` vẫn sẽ cố gắng gửi một yêu cầu mạng nhỏ lên Hugging Face để kiểm tra xem tác giả có cập nhật mô hình mới hay không. Khi bạn ngắt kết nối mạng hoàn toàn, bước kiểm tra này sẽ gây ra lỗi kết nối và làm ứng dụng Python bị crash, trả lỗi về cho ứng dụng C#.

### Cách khắc phục để chạy Offline hoàn toàn:

* **Bước 1: Tải cache mô hình (chỉ cần làm 1 lần)**
  Hãy bật mạng lên và chạy ứng dụng `BT_TNC_Dot-NET`, thực hiện phát một câu nói bất kỳ bằng VieNeu-TTS để chương trình tự động tải đầy đủ mô hình về máy. Sau khi nghe thấy tiếng phát ra thành công, mô hình đã được lưu trữ an toàn trong cache máy bạn.
* **Bước 2: Cấu hình ứng dụng chạy ở chế độ Offline**
  Để tắt cơ chế kiểm tra cập nhật trực tuyến của Hugging Face, bạn có thể thiết lập biến môi trường `HF_HUB_OFFLINE = 1`. 
  Chúng ta có thể tích hợp trực tiếp việc này vào mã nguồn C# tại file [VieNeuTtsService.cs](file:///D:/Download/.Net/Bài%20Tự%20Nghiên%20Cứu/BT_TNC_Dot-NET/Services/VieNeuTtsService.cs) để ứng dụng tự động chạy offline mượt mà khi đã có cache.
