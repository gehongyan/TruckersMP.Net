using Newtonsoft.Json;

namespace TruckersMP.Net
{
    public class Attendances
    {
        [JsonProperty("confirmed")] private readonly int _confirmed;
        [JsonProperty("unsure")] private readonly int _unsure;
        [JsonProperty("confirmed_users")] private readonly AttendanceUser[] _confirmedUsers;
        [JsonProperty("unsure_users")] private readonly AttendanceUser[] _unsureUsers;

        public int Confirmed => _confirmed;

        public int Unsure => _unsure;

        public AttendanceUser[] ConfirmedUsers => _confirmedUsers;

        public AttendanceUser[] UnsureUsers => _unsureUsers;
    }
}