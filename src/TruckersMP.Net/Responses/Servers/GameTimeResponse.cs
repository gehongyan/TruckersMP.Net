using Newtonsoft.Json;

namespace TruckersMP.Net.Responses.Servers
{
    public class GameTimeResponse : TruckersMPResponseBase
    {
        [JsonProperty("game_time")]
        private int _gameTime;

        public int GameTime
        {
            get => _gameTime;
        }
    }
}