using Newtonsoft.Json;
using System;

namespace TruckersMP.Net
{
    public class Player
    {
        [JsonProperty("id")]
        public int Id { get; init; }

        [JsonProperty("name")]
        public string Name { get; init; }

        [JsonProperty("avatar")]
        public string Avatar { get; init; }

        [JsonProperty("smallAvatar")]
        public string SmallAvatar { get; init; }

        [JsonProperty("joinDate")]
        public DateTime JoinDate { get; init; }

        [JsonProperty("steamID64")]
        public long SteamId64 { get; init; }

        [JsonProperty("steamID")]
        public string SteamId { get; init; }

        [JsonProperty("discordSnowflake")]
        public string DiscordSnowflake { get; init; }

        [JsonProperty("groupName")]
        public string GroupName { get; init; }

        [JsonProperty("groupColor")]
        public string GroupColor { get; init; }

        [JsonProperty("groupID")]
        public int GroupId { get; init; }

        [JsonProperty("banned")]
        public bool Banned { get; init; }

        [JsonProperty("bannedUntil")]
        public DateTime? BannedUntil { get; init; }

        [JsonProperty("bansCount")]
        public int? BansCount { get; init; }

        [JsonProperty("displayBans")]
        public bool DisplayBans { get; init; }

        [JsonProperty("patreon")]
        public Patreon Patreon { get; init; }

        [JsonProperty("permissions")]
        public Permissions Permissions { get; init; }

        [JsonProperty("vtc")]
        public PlayerVTCInfo VTC { get; init; }
    }
}