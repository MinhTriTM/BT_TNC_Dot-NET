using System;
using System.IO;
using System.Text;

namespace BT_TNC_Dot_NET.Helpers
{
    public static class FileHelper
    {
        /// <summary>
        /// Đọc nội dung file văn bản (.txt) với tự động phát hiện mã hóa UTF-8
        /// </summary>
        public static string ReadTextFile(string filePath)
        {
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException("Không tìm thấy file văn bản cần đọc.", filePath);
            }

            try
            {
                // Sử dụng StreamReader với UTF8Encoding và detectEncodingFromByteOrderMarks = true
                using (var reader = new StreamReader(filePath, Encoding.UTF8, true))
                {
                    return reader.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                throw new IOException($"Lỗi khi đọc file '{Path.GetFileName(filePath)}': {ex.Message}", ex);
            }
        }
    }
}
