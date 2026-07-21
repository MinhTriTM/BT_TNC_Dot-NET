using System;

namespace TTS_Windows_App.Models
{
    /// <summary>
    /// Lớp đại diện cho thông tin giọng đọc trong hệ thống
    /// </summary>
    public class VoiceItem
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Culture { get; set; }
        public string Gender { get; set; }

        public override string ToString()
        {
            return $"{Name} ({Culture})";
        }
    }

    /// <summary>
    /// Lớp đại diện cho mục lịch sử tổng hợp văn bản thành giọng nói
    /// </summary>
    public class HistoryRecord
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Text { get; set; }
        public string VoiceName { get; set; }
        public DateTime Timestamp { get; set; } = DateTime.Now;
        public int CharCount => Text?.Length ?? 0;
    }
}
