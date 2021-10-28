using System.Collections.Generic;
using Newtonsoft.Json;

namespace TruckersMP.Net
{
    public class EventsIndex
    {
        [JsonProperty("featured")]
        public IReadOnlyCollection<EventWithSimpleAttendances> Featured { get; init; }

        [JsonProperty("today")]
        public IReadOnlyCollection<EventWithSimpleAttendances> Today { get; init; }

        [JsonProperty("upcoming")]
        public IReadOnlyCollection<EventWithSimpleAttendances> Upcoming { get; init; }
    }
}