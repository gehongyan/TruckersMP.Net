using Newtonsoft.Json;
using System;

namespace TruckersMP.Net
{
    public class Member
    {
        [JsonProperty("id")]
        public int Id { get; init; }

        [JsonProperty("user_id")]
        public int UserId { get; init; }

        [JsonProperty("username")]
        public string Username { get; init; }

        [JsonProperty("steam_id")]
        public long SteamId { get; init; }

        [JsonProperty("role_id")]
        public int RoleId { get; init; }

        [JsonProperty("role")]
        public string Role { get; init; }

        [JsonProperty("joinDate")]
        public DateTime JoinDate { get; init; }
    }
}