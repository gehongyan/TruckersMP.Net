using System.Collections.Generic;
using Newtonsoft.Json;

namespace TruckersMP.Net
{
    public class Attendances
    {
        [JsonProperty("confirmed")]
        public int Confirmed { get; init; }

        [JsonProperty("unsure")]
        public int Unsure { get; init; }

        [JsonProperty("confirmed_users")]
        public IReadOnlyCollection<AttendanceUser> ConfirmedUsers { get; init; }

        [JsonProperty("unsure_users")]
        public IReadOnlyCollection<AttendanceUser> UnsureUsers { get; init; }
    }
}