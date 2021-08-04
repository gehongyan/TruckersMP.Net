using Newtonsoft.Json;

namespace TruckersMP.Net
{
    public class EventType
    {
        [JsonProperty("key")] private readonly string _key;
        [JsonProperty("name")] private readonly string _name;

        public string Key => _key;

        public string Name => _name;
    }
}