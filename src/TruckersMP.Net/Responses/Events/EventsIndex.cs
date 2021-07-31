using Newtonsoft.Json;

namespace TruckersMP.Net.Responses.Events
{
    public class EventsIndex
    {
        [JsonProperty("featured")] private readonly EventWithSimpleAttendances[] _featured;
        [JsonProperty("today")] private readonly EventWithSimpleAttendances[] _today;
        [JsonProperty("upcoming")] private readonly EventWithSimpleAttendances[] _upcoming;

        public EventWithSimpleAttendances[] Featured => _featured;

        public EventWithSimpleAttendances[] Today => _today;

        public EventWithSimpleAttendances[] Upcoming => _upcoming;
    }
}