using Newtonsoft.Json;

namespace TruckersMP.Net
{
    public class Event : EventBase
    {
        [JsonProperty("attendances")]
        public Attendances Attendances { get; init; }
    }
}