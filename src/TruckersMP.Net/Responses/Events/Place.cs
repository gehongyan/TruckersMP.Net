using Newtonsoft.Json;

namespace TruckersMP.Net.Responses.Events
{
    public class Place
    {
        [JsonProperty("location")] private readonly string _location;
        [JsonProperty("city")] private readonly string _city;

        public string Location => _location;

        public string City => _city;
    }
}