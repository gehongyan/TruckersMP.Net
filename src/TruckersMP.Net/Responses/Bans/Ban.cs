using Newtonsoft.Json;
using System;

namespace TruckersMP.Net
{
    public class Ban
    {
        [JsonProperty("expiration")] private readonly DateTime? _expiration;
        [JsonProperty("timeAdded")] private readonly DateTime _timeAdded;
        [JsonProperty("active")] private readonly bool _active;
        [JsonProperty("reason")] private readonly string _reason;
        [JsonProperty("adminName")] private readonly string _adminName;
        [JsonProperty("adminID")] private readonly int _adminId;

        public DateTime? Expiration => _expiration;

        public DateTime TimeAdded => _timeAdded;

        public bool Active => _active;

        public string Reason => _reason;

        public string AdminName => _adminName;

        public int AdminId => _adminId;
    }
}