using Newtonsoft.Json;

namespace TruckersMP.Net
{
    public class EventVTCInfo
    {
        [JsonProperty("id")]
        public int Id { get; init; }

        [JsonProperty("name")]
        public string Name { get; init; }
    }
}