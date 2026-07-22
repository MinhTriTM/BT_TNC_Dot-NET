# Câu hỏi
Xử lý lỗi Permission Denied khi push submodule và hoàn tất cấu hình.

# Suy nghĩ (Thinking)
- Đăng ký submodule `VieNeu-TTS` thành công ở repo cha `BT_TNC_Dot-NET`.
- Commit và push `.gitmodules` ở repo cha thành công lên GitHub cá nhân của người dùng (`MinhTriTM/BT_TNC_Dot-NET.git`).
- Khôi phục file local từ backup vào `VieNeu-TTS` thành công.
- Phát hiện file mới `vieneu_bridge.py` ở local chưa có trên repo GitHub gốc.
- Tiến hành `git add`, `git commit` file này trong submodule cục bộ thành công.
- Tuy nhiên, lệnh `git push` trong submodule bị từ chối (HTTP 403 Forbidden) do tài khoản `MinhTriTM` không có quyền ghi trực tiếp vào repository gốc `pnnbao97/VieNeu-TTS.git`.
- Cần hướng dẫn người dùng fork repo `pnnbao97/VieNeu-TTS` về GitHub cá nhân của họ, sau đó đổi URL remote của submodule thành repo fork đó để có thể push code lên.

# Câu trả lời
Quá trình thiết lập Git Submodule đã hoàn tất ở repo cha. Tuy nhiên, khi thử push file local mới `vieneu_bridge.py` trong submodule, hệ thống báo lỗi 403 do tài khoản của bạn không có quyền ghi vào repository gốc `pnnbao97/VieNeu-TTS.git`.

Các bước khắc phục khuyến nghị:
1. Truy cập GitHub và **Fork** repository `https://github.com/pnnbao97/VieNeu-TTS.git` về tài khoản của bạn (thành `https://github.com/MinhTriTM/VieNeu-TTS.git`).
2. Thay đổi URL remote của submodule bằng lệnh:
   ```bash
   cd VieNeu-TTS
   git remote set-url origin https://github.com/MinhTriTM/VieNeu-TTS.git
   git push origin main
   ```
3. Sau khi push thành công, quay lại thư mục cha và cập nhật lại commit hash của submodule:
   ```bash
   cd ..
   git add VieNeu-TTS
   git commit -m "Update VieNeu-TTS submodule reference to fork"
   git push origin main
   ```
