using Newtonsoft.Json;

namespace TruckersMP.Net
{
    public class RulesResponse : TruckersMPResponseBase
    {
        [JsonProperty("rules")]
        public string RulesContent { get; init; }

        [JsonProperty("revision")]
        public int Revision { get; init; }
    }
}