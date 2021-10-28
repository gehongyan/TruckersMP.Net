using Newtonsoft.Json;

namespace TruckersMP.Net
{
    public class EventWithSimpleAttendances : EventBase
    {
        [JsonProperty("attendances")]
        public AttendancesSimple Attendances { get; init; }
    }
}