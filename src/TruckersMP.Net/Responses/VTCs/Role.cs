using Newtonsoft.Json;
using System;

namespace TruckersMP.Net.Responses.VTCs
{
    public class Role
    {
        [JsonProperty("id")]
        private readonly int _id;

        [JsonProperty("name")]
        private readonly string _name;

        [JsonProperty("order")]
        private readonly int _order;

        [JsonProperty("owner")]
        private readonly bool _owner;

        [JsonProperty("created_at")]
        private readonly DateTime _createdAt;

        [JsonProperty("updated_at")]
        private readonly DateTime _updatedAt;

        public int Id => _id;

        public string Name => _name;

        public int Order => _order;

        public bool Owner => _owner;

        public DateTime CreatedAt => _createdAt;

        public DateTime UpdatedAt => _updatedAt;
    }
}