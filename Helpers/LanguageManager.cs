using System;
using System.Collections.Generic;

namespace TTS_Windows_App.Helpers
{
    public enum AppLanguage
    {
        Vietnamese,
        English
    }

    public static class LanguageManager
    {
        private static readonly Dictionary<string, string> ViDict = new Dictionary<string, string>
        {
            {"AppTitle", "🎙️ VOICECRAFT STUDIO | AI Text-To-Speech Pro"},
            {"AppSubtitle", "Phần mềm chuyển đổi văn bản thành giọng nói AI chất lượng cao (.NET 4.8)"},
            {"EngineTitle", "⚙️ Chọn Engine TTS:"},
            {"VoiceTitle", "🗣️ Chọn Giọng Đọc:"},
            {"StyleTitle", "🎭 Phong Cách Đọc (Style):"},
            {"GenderTitle", "🚻 Giới Tính:"},
            {"AgeTitle", "👶 Độ Tuổi:"},
            {"PersonalityTitle", "🧠 Tính Cách / Tông Giọng:"},
            {"AudioSettingsTitle", "🎛️ Tùy Chỉnh Âm Thanh Chi Tiết"},
            {"SpeedLabel", "⚡ Tốc độ (Speed):"},
            {"VolumeLabel", "🔊 Âm lượng (Volume):"},
            {"PitchLabel", "🎵 Cao độ (Pitch):"},
            {"FileToolsTitle", "📁 Công Cụ File & Xuất Audio"},
            {"OpenFileBtn", "📄 Mở File Văn Bản (.txt)"},
            {"ExportWavBtn", "💾 Xuất File Âm Thanh (.wav)"},
            {"PlayBtn", "▶  ĐỌC VĂN BẢN (F5)"},
            {"PauseBtn", "⏸ Tạm Dừng"},
            {"ResumeBtn", "▶ Đọc Tiếp"},
            {"StopBtn", "⏹ Dừng"},
            {"ClearTextBtn", "🗑️ Xóa Nội Dung Văn Bản"},
            {"HistoryTitle", "📜 Lịch Sử Đọc"},
            {"ClearHistoryBtn", "🗑️ Xóa Lịch Sử"},
            {"ReadyStatus", "⏹ Sẵn sàng đọc văn bản"},
            {"ThemeTitle", "🎨 Chủ Đề (Theme):"},
            {"LangTitle", "🌐 Ngôn Ngữ:"},
            {"AllGender", "Tất cả giới tính"},
            {"MaleGender", "Nam (Male)"},
            {"FemaleGender", "Nữ (Female)"},
            {"AllAges", "Tất cả độ tuổi"},
            {"ChildAge", "🧒 Trẻ em (Child)"},
            {"YoungAge", "🧑 Thanh niên (Young)"},
            {"AdultAge", "👨 Trưởng thành (Adult)"},
            {"SeniorAge", "👴 Lão niên (Senior)"},
            {"AllPersonalities", "Tất cả tính cách"},
            {"ExcitedPersona", "🔥 Hào hứng / Vui vẻ"},
            {"WarmPersona", "🧘 Dịu dàng / Ấm áp"},
            {"SeriousPersona", "💼 Nghiêm túc / Chuyên nghiệp"},
            {"MysteriousPersona", "🕵️ Bí ẩn / Kịch tính"}
        };

        private static readonly Dictionary<string, string> EnDict = new Dictionary<string, string>
        {
            {"AppTitle", "🎙️ VOICECRAFT STUDIO | AI Text-To-Speech Pro"},
            {"AppSubtitle", "High-Fidelity AI Text-to-Speech Application (.NET Framework 4.8)"},
            {"EngineTitle", "⚙️ Select TTS Engine:"},
            {"VoiceTitle", "🗣️ Select Voice:"},
            {"StyleTitle", "🎭 Speaking Style:"},
            {"GenderTitle", "🚻 Gender Filter:"},
            {"AgeTitle", "👶 Age Group:"},
            {"PersonalityTitle", "🧠 Voice Tone / Persona:"},
            {"AudioSettingsTitle", "🎛️ Detailed Audio Controls"},
            {"SpeedLabel", "⚡ Speed Rate:"},
            {"VolumeLabel", "🔊 Volume Level:"},
            {"PitchLabel", "🎵 Pitch Frequency:"},
            {"FileToolsTitle", "📁 Tools & Export Audio"},
            {"OpenFileBtn", "📄 Open Text File (.txt)"},
            {"ExportWavBtn", "💾 Export Audio (.wav)"},
            {"PlayBtn", "▶  SPEAK TEXT (F5)"},
            {"PauseBtn", "⏸ Pause"},
            {"ResumeBtn", "▶ Resume"},
            {"StopBtn", "⏹ Stop"},
            {"ClearTextBtn", "🗑️ Clear Text Editor"},
            {"HistoryTitle", "📜 Speech History"},
            {"ClearHistoryBtn", "🗑️ Clear History"},
            {"ReadyStatus", "⏹ Ready to speak text"},
            {"ThemeTitle", "🎨 UI Theme:"},
            {"LangTitle", "🌐 UI Language:"},
            {"AllGender", "All Genders"},
            {"MaleGender", "Male"},
            {"FemaleGender", "Female"},
            {"AllAges", "All Ages"},
            {"ChildAge", "🧒 Child / Kid"},
            {"YoungAge", "🧑 Young Adult"},
            {"AdultAge", "👨 Mature Adult"},
            {"SeniorAge", "👴 Senior / Elder"},
            {"AllPersonalities", "All Personas"},
            {"ExcitedPersona", "🔥 Excited / Cheerful"},
            {"WarmPersona", "🧘 Gentle / Warm"},
            {"SeriousPersona", "💼 Serious / Professional"},
            {"MysteriousPersona", "🕵️ Mysterious / Dramatic"}
        };

        public static string Get(string key, AppLanguage lang)
        {
            var dict = lang == AppLanguage.English ? EnDict : ViDict;
            if (dict.TryGetValue(key, out string value))
            {
                return value;
            }
            return key;
        }
    }
}
