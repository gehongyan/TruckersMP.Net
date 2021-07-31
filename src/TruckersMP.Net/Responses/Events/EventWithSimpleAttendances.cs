using Newtonsoft.Json;

namespace TruckersMP.Net.Responses.Events
{
    public class EventWithSimpleAttendances : EventBase
    {
        [JsonProperty("attendances")] private readonly AttendancesSimple _attendances;
        public AttendancesSimple Attendances => _attendances;
    }
}