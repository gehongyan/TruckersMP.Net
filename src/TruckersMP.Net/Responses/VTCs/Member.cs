using Newtonsoft.Json;
using System;

namespace TruckersMP.Net
{
    public class Member
    {
        [JsonProperty("id")]
        private readonly int _id;

        [JsonProperty("user_id")]
        private readonly int _userId;

        [JsonProperty("username")]
        private readonly string _username;

        [JsonProperty("steam_id")]
        private readonly long _steamId;

        [JsonProperty("role_id")]
        private readonly int _roleId;

        [JsonProperty("role")]
        private readonly string _role;

        [JsonProperty("joinDate")]
        private readonly DateTime _joinDate;

        public int Id => _id;

        public int UserId => _userId;

        public string Username => _username;

        public long SteamId => _steamId;

        public int RoleId => _roleId;

        public string Role => _role;

        public DateTime JoinDate => _joinDate;
    }
}