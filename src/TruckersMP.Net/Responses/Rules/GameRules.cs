using Newtonsoft.Json;

namespace TruckersMP.Net
{
    public class GameRules
    {
        public GameRules(string rules, int revision)
        {
            RulesContent = rules;
            Revision = revision;
        }

        [JsonProperty("rules")]
        public string RulesContent { get; init; }

        [JsonProperty("revision")]
        public int Revision { get; init; }
    }
}