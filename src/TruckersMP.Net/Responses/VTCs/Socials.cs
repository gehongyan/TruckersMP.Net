using Newtonsoft.Json;

namespace TruckersMP.Net.Responses.VTCs
{
    public class Socials
    {
        [JsonProperty("twitter")]
        private string _twitter;

        [JsonProperty("facebook")]
        private string _facebook;

        [JsonProperty("twitch")]
        private string _twitch;

        [JsonProperty("discord")]
        private string _discord;

        [JsonProperty("youtube")]
        private string _youtube;

        public string Twitter => _twitter;

        public string Facebook => _facebook;

        public string Twitch => _twitch;

        public string Discord => _discord;

        public string Youtube => _youtube;
    }
}