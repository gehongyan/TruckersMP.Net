using Newtonsoft.Json;

namespace TruckersMP.Net
{
    public class Games
    {
        [JsonProperty("ats")]
        public bool Ats { get; init; }

        [JsonProperty("ets")]
        public bool Ets { get; init; }
    }
}