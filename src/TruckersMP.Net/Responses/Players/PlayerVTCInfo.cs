using Newtonsoft.Json;

namespace TruckersMP.Net
{
    public class PlayerVTCInfo
    {
        [JsonProperty("id")]
        public int Id { get; init; }

        [JsonProperty("name")]
        public string Name { get; init; }

        [JsonProperty("tag")]
        public string Tag { get; init; }

        [JsonProperty("inVTC")]
        public bool InVtc { get; init; }

        [JsonProperty("memberID")]
        public int MemberId { get; init; }
    }
}