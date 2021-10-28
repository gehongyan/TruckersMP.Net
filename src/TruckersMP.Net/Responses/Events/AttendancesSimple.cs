using Newtonsoft.Json;

namespace TruckersMP.Net
{
    public class AttendancesSimple
    {
        [JsonProperty("confirmed")]
        public int Confirmed { get; init; }

        [JsonProperty("unsure")]
        public int Unsure { get; init; }
    }
}