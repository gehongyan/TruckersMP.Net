using Newtonsoft.Json;

namespace TruckersMP.Net
{
    public class RulesResponse : TruckersMPResponseBase
    {
        [JsonProperty("rules")]
        private readonly string _rules;

        [JsonProperty("revision")]
        private readonly int _revision;

        public string RulesContent => _rules;

        public int Revision => _revision;
    }
}