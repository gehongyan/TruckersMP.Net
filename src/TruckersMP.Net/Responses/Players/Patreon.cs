using Newtonsoft.Json;

namespace TruckersMP.Net
{
    public class Patreon
    {
        [JsonProperty("isPatron")]
        public bool IsPatron { get; init; }

        [JsonProperty("active")]
        public bool Active { get; init; }

        [JsonProperty("color")]
        public string Color { get; init; }

        [JsonProperty("tierId")]
        public int? TierId { get; init; }

        [JsonProperty("currentPledge")]
        public int? CurrentPledge { get; init; }

        [JsonProperty("lifetimePledge")]
        public int? LifetimePledge { get; init; }

        [JsonProperty("nextPledge")]
        public int? NextPledge { get; init; }

        [JsonProperty("hidden")]
        public bool? Hidden { get; init; }
    }
}