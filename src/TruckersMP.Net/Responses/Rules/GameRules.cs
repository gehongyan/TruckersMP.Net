using Newtonsoft.Json;

namespace TruckersMP.Net
{
    public class GameRules
    {
        [JsonProperty("rules")]
        private readonly string _rules;

        [JsonProperty("revision")]
        private readonly int _revision;

        public GameRules(string rules, int revision)
        {
            _rules = rules;
            _revision = revision;
        }

        public string RulesContent => _rules;

        public int Revision => _revision;
    }
}