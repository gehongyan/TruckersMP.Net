using Newtonsoft.Json;

namespace TruckersMP.Net
{
    public class Server
    {
        [JsonProperty("id")]
        public int Id { get; init; }

        [JsonProperty("game")]
        public string Game { get; init; }

        [JsonProperty("ip")]
        public string Ip { get; init; }

        [JsonProperty("port")]
        public int Port { get; init; }

        [JsonProperty("name")]
        public string Name { get; init; }

        [JsonProperty("shortname")]
        public string ShortName { get; init; }

        [JsonProperty("idprefix")]
        public object IdPrefix { get; init; }

        [JsonProperty("online")]
        public bool Online { get; init; }

        [JsonProperty("players")]
        public int Players { get; init; }

        [JsonProperty("queue")]
        public int Queue { get; init; }

        [JsonProperty("maxplayers")]
        public int MaxPlayers { get; init; }

        [JsonProperty("mapid")]
        public int MapId { get; init; }

        [JsonProperty("displayorder")]
        public int DisplayOrder { get; init; }

        [JsonProperty("speedlimiter")]
        public int SpeedLimiter { get; init; }

        [JsonProperty("collisions")]
        public bool Collisions { get; init; }

        [JsonProperty("carsforplayers")]
        public bool CarsForPlayers { get; init; }

        [JsonProperty("policecarsforplayers")]
        public bool PoliceCarsForPlayers { get; init; }

        [JsonProperty("afkenabled")]
        public bool AfkEnabled { get; init; }

        [JsonProperty("_event")]
        public bool Event { get; init; }

        [JsonProperty("specialEvent")]
        public bool SpecialEvent { get; init; }

        [JsonProperty("promods")]
        public bool ProMods { get; init; }

        [JsonProperty("syncdelay")]
        public int SyncDelay { get; init; }
    }
}