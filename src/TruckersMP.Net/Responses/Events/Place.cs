using Newtonsoft.Json;

namespace TruckersMP.Net
{
    public class Place
    {
        [JsonProperty("location")]
        public string Location { get; init; }

        [JsonProperty("city")]
        public string City { get; init; }
    }
}