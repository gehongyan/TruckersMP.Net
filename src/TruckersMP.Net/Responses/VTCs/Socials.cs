using Newtonsoft.Json;

namespace TruckersMP.Net
{
    public class Socials
    {
        [JsonProperty("twitter")]
        public string Twitter { get; init; }

        [JsonProperty("facebook")]
        public string Facebook { get; init; }

        [JsonProperty("twitch")]
        public string Twitch { get; init; }

        [JsonProperty("discord")]
        public string Discord { get; init; }

        [JsonProperty("youtube")]
        public string Youtube { get; init; }
    }
}