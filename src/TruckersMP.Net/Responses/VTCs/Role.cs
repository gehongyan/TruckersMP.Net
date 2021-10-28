using Newtonsoft.Json;
using System;

namespace TruckersMP.Net
{
    public class Role
    {
        [JsonProperty("id")]
        public int Id { get; init; }

        [JsonProperty("name")]
        public string Name { get; init; }

        [JsonProperty("order")]
        public int Order { get; init; }

        [JsonProperty("owner")]
        public bool Owner { get; init; }

        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; init; }

        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; init; }
    }
}