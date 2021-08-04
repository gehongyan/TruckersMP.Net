using Newtonsoft.Json;
using System;

namespace TruckersMP.Net
{
    public class AttendanceUser : User
    {
        [JsonProperty("following")] private readonly bool _following;
        [JsonProperty("created_at")] private readonly DateTime _createdAt;
        [JsonProperty("updated_at")] private readonly DateTime _updatedAt;

        public bool Following => _following;

        public DateTime CreatedAt => _createdAt;

        public DateTime UpdatedAt => _updatedAt;
    }
}