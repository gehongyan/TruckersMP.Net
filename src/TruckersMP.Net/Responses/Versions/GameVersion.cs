using Newtonsoft.Json;
using System;

namespace TruckersMP.Net.Responses.Versions
{
    public class GameVersion
    {
        [JsonProperty("name")]
        private readonly string _name;

        [JsonProperty("numeric")]
        private readonly string _numeric;

        [JsonProperty("stage")]
        private readonly string _stage;

        [JsonProperty("ets2mp_checksum")]
        private readonly Checksum _ets2MPChecksum;

        [JsonProperty("atsmp_checksum")]
        private readonly Checksum _atsmpChecksum;

        [JsonProperty("time")]
        private readonly DateTime _time;

        [JsonProperty("supported_game_version")]
        private readonly string _supportedGameVersion;

        [JsonProperty("supported_ats_game_version")]
        private readonly string _supportedAtsGameVersion;

        public string Name => _name;

        public string Numeric => _numeric;

        public string Stage => _stage;

        public Checksum ETS2MPChecksum => _ets2MPChecksum;

        public Checksum ATSMPChecksum => _atsmpChecksum;

        public DateTime Time => _time;

        public string SupportedGameVersion => _supportedGameVersion;

        public string SupportedAtsGameVersion => _supportedAtsGameVersion;
    }

    public class Checksum
    {
        [JsonProperty("dll")]
        private readonly string _dll;

        [JsonProperty("adb")]
        private readonly string _adb;

        public string Dll => _dll;

        public string Adb => _adb;
    }
}