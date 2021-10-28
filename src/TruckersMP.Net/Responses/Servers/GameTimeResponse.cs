using Newtonsoft.Json;

namespace TruckersMP.Net
{
    public class GameTimeResponse : TruckersMPResponseBase
    {
        [JsonProperty("game_time")]
        public int GameTime { get; init; }
    }
}