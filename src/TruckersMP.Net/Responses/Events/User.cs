using Newtonsoft.Json;

namespace TruckersMP.Net
{
    public class User
    {
        [JsonProperty("id")]
        public int Id { get; init; }

        [JsonProperty("username")]
        public string Username { get; init; }
    }
}