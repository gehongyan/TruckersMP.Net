using Newtonsoft.Json;

namespace TruckersMP.Net.Responses
{
    public class TruckersMPResponseBase
    {
        [JsonProperty("error")]
        public bool Error { get; set; }

        [JsonProperty("descriptor")]
        public string Descriptor { get; set; }
    }
}