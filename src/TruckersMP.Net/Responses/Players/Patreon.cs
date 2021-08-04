using Newtonsoft.Json;

namespace TruckersMP.Net
{
    public class Patreon
    {
        [JsonProperty("isPatron")] private readonly bool _isPatron;
        [JsonProperty("active")] private readonly bool _active;
        [JsonProperty("color")] private readonly string _color;
        [JsonProperty("tierId")] private readonly int? _tierId;
        [JsonProperty("currentPledge")] private readonly int? _currentPledge;
        [JsonProperty("lifetimePledge")] private readonly int? _lifetimePledge;
        [JsonProperty("nextPledge")] private readonly int? _nextPledge;
        [JsonProperty("hidden")] private readonly bool? _hidden;

        public bool IsPatron => _isPatron;

        public bool Active => _active;

        public string Color => _color;

        public int? TierId => _tierId;

        public int? CurrentPledge => _currentPledge;

        public int? LifetimePledge => _lifetimePledge;

        public int? NextPledge => _nextPledge;

        public bool? Hidden => _hidden;
    }
}