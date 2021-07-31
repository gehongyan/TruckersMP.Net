using Newtonsoft.Json;

namespace TruckersMP.Net.Responses.Events
{
    public class AttendancesSimple
    {
        [JsonProperty("confirmed")] private readonly int _confirmed;
        [JsonProperty("unsure")] private readonly int _unsure;

        public int Confirmed => _confirmed;

        public int Unsure => _unsure;
    }
}