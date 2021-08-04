using Newtonsoft.Json;
using System;

namespace TruckersMP.Net
{
    public class Player
    {
        [JsonProperty("id")] private readonly int _id;
        [JsonProperty("name")] private readonly string _name;
        [JsonProperty("avatar")] private readonly string _avatar;
        [JsonProperty("smallAvatar")] private readonly string _smallAvatar;
        [JsonProperty("joinDate")] private readonly DateTime _joinDate;
        [JsonProperty("steamID64")] private readonly long _steamId64;
        [JsonProperty("steamID")] private readonly string _steamId;
        [JsonProperty("discordSnowflake")] private readonly string _discordSnowflake;
        [JsonProperty("groupName")] private readonly string _groupName;
        [JsonProperty("groupColor")] private readonly string _groupColor;
        [JsonProperty("groupID")] private readonly int _groupId;
        [JsonProperty("banned")] private readonly bool _banned;
        [JsonProperty("bannedUntil")] private readonly DateTime? _bannedUntil;
        [JsonProperty("bansCount")] private readonly int? _bansCount;
        [JsonProperty("displayBans")] private readonly bool _displayBans;
        [JsonProperty("patreon")] private readonly Patreon _patreon;
        [JsonProperty("permissions")] private readonly Permissions _permissions;
        [JsonProperty("vtc")] private readonly PlayerVTCInfo _vtc;

        public int Id => _id;

        public string Name => _name;

        public string Avatar => _avatar;

        public string SmallAvatar => _smallAvatar;

        public DateTime JoinDate => _joinDate;

        public long SteamId64 => _steamId64;

        public string SteamId => _steamId;

        public string DiscordSnowflake => _discordSnowflake;

        public string GroupName => _groupName;

        public string GroupColor => _groupColor;

        public int GroupId => _groupId;

        public bool Banned => _banned;

        public DateTime? BannedUntil => _bannedUntil;

        public int? BansCount => _bansCount;

        public bool DisplayBans => _displayBans;

        public Patreon Patreon => _patreon;

        public Permissions Permissions => _permissions;

        public PlayerVTCInfo VTC => _vtc;
    }
}