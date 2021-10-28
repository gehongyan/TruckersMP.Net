using Newtonsoft.Json;
using System;

namespace TruckersMP.Net
{
    public class Ban
    {
        [JsonProperty("expiration")]
        public DateTime? Expiration { get; init; }

        [JsonProperty("timeAdded")]
        public DateTime TimeAdded { get; init; }

        [JsonProperty("active")]
        public bool Active { get; init; }

        [JsonProperty("reason")]
        public string Reason { get; init; }

        [JsonProperty("adminName")]
        public string AdminName { get; init; }

        [JsonProperty("adminID")]
        public int AdminId { get; init; }
    }
}