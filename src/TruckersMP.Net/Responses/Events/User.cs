using Newtonsoft.Json;

namespace TruckersMP.Net.Responses.Events
{
    public class User
    {
        [JsonProperty("id")] private readonly int _id;
        [JsonProperty("username")] private readonly string _username;

        public int Id => _id;

        public string Username => _username;
    }
}