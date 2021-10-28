using Newtonsoft.Json;
using System;

namespace TruckersMP.Net
{
    public class AttendanceUser : User
    {
        [JsonProperty("following")]
        public bool Following { get; init; }

        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; init; }

        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; init; }
    }
}