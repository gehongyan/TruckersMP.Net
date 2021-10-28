using Newtonsoft.Json;
using System;

namespace TruckersMP.Net
{
    public class GameVersion
    {
        [JsonProperty("name")]
        public string Name { get; init; }

        [JsonProperty("numeric")]
        public string Numeric { get; init; }

        [JsonProperty("stage")]
        public string Stage { get; init; }

        [JsonProperty("ets2mp_checksum")]
        public Checksum ETS2MPChecksum { get; init; }

        [JsonProperty("atsmp_checksum")]
        public Checksum ATSMPChecksum { get; init; }

        [JsonProperty("time")]
        public DateTime Time { get; init; }

        [JsonProperty("supported_game_version")]
        public string SupportedGameVersion { get; init; }

        [JsonProperty("supported_ats_game_version")]
        public string SupportedAtsGameVersion { get; init; }
    }

    public class Checksum
    {
        [JsonProperty("dll")]
        public string Dll { get; init; }

        [JsonProperty("adb")]
        public string Adb { get; init; }
    }
}