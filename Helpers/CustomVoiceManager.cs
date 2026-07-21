using System;
using System.Collections.Generic;
using System.IO;
using System.Web.Script.Serialization;
using BT_TNC_Dot_NET.Services;

namespace BT_TNC_Dot_NET.Helpers
{
    public static class CustomVoiceManager
    {
        private static readonly string FilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "custom_voices.json");
        private static readonly JavaScriptSerializer Serializer = new JavaScriptSerializer();

        public static List<VieNeuVoiceItem> LoadCustomVoices()
        {
            try
            {
                if (File.Exists(FilePath))
                {
                    string json = File.ReadAllText(FilePath);
                    var list = Serializer.Deserialize<List<VieNeuVoiceItem>>(json);
                    return list ?? new List<VieNeuVoiceItem>();
                }
            }
            catch { }
            return new List<VieNeuVoiceItem>();
        }

        public static bool SaveCustomVoices(List<VieNeuVoiceItem> customVoices)
        {
            try
            {
                string json = Serializer.Serialize(customVoices);
                File.WriteAllText(FilePath, json);
                return true;
            }
            catch { return false; }
        }
    }
}
