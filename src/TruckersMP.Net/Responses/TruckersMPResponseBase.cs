using Newtonsoft.Json;

namespace TruckersMP.Net
{
    public class TruckersMPResponseBase
    {
        [JsonProperty("error")]
        public bool Error { get; set; }

        [JsonProperty("descriptor")]
        public string Descriptor { get; set; }
    }
}