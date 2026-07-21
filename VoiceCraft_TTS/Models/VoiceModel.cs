namespace VoiceCraft_TTS.Models
{
    public class VoiceModel
    {
        public string Id { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Language { get; set; } = string.Empty;
        public string Gender { get; set; } = string.Empty;
        public string Source { get; set; } = "Windows Engine"; // "Windows Engine" hoặc "AI Neural Engine"

        public override string ToString()
        {
            return $"[{Source}] {Name}";
        }
    }

    public class HistoryItem
    {
        public string Id { get; set; } = System.Guid.NewGuid().ToString();
        public string Text { get; set; } = string.Empty;
        public string VoiceName { get; set; } = string.Empty;
        public string Engine { get; set; } = string.Empty;
        public System.DateTime Timestamp { get; set; } = System.DateTime.Now;
        public string? AudioFilePath { get; set; }
    }
}
