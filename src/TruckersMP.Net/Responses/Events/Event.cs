using Newtonsoft.Json;

namespace TruckersMP.Net
{
    public class Event : EventBase
    {
        [JsonProperty("attendances")] private readonly Attendances _attendances;
        public Attendances Attendances => _attendances;
    }
}