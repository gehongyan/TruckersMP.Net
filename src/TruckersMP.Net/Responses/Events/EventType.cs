using Newtonsoft.Json;

namespace TruckersMP.Net
{
    public class EventType
    {
        [JsonProperty("key")]
        public string Key { get; init; }

        [JsonProperty("name")]
        public string Name { get; init; }
    }
}