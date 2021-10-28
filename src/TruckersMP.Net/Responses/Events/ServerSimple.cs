using Newtonsoft.Json;

namespace TruckersMP.Net
{
    public class ServerSimple
    {
        [JsonProperty("id")]
        public int Id { get; init; }

        [JsonProperty("name")]
        public string Name { get; init; }
    }
}