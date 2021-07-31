using Newtonsoft.Json;

namespace TruckersMP.Net.Responses.Servers
{
    public class Server
    {
        [JsonProperty("id")] private readonly int _id;
        [JsonProperty("game")] private readonly string _game;
        [JsonProperty("ip")] private readonly string _ip;
        [JsonProperty("port")] private readonly int _port;
        [JsonProperty("name")] private readonly string _name;
        [JsonProperty("shortname")] private readonly string _shortName;
        [JsonProperty("idprefix")] private readonly object _idPrefix;
        [JsonProperty("online")] private readonly bool _online;
        [JsonProperty("players")] private readonly int _players;
        [JsonProperty("queue")] private readonly int _queue;
        [JsonProperty("maxplayers")] private readonly int _maxPlayers;
        [JsonProperty("mapid")] private readonly int _mapId;
        [JsonProperty("displayorder")] private readonly int _displayOrder;
        [JsonProperty("speedlimiter")] private readonly int _speedLimiter;
        [JsonProperty("collisions")] private readonly bool _collisions;
        [JsonProperty("carsforplayers")] private readonly bool _carsForPlayers;
        [JsonProperty("policecarsforplayers")] private readonly bool _policeCarsForPlayers;
        [JsonProperty("afkenabled")] private readonly bool _afkEnabled;
        [JsonProperty("_event")] private readonly bool _event;
        [JsonProperty("specialEvent")] private readonly bool _specialEvent;
        [JsonProperty("promods")] private readonly bool _proMods;
        [JsonProperty("syncdelay")] private readonly int _syncDelay;

        public int Id => _id;

        public string Game => _game;

        public string Ip => _ip;

        public int Port => _port;

        public string Name => _name;

        public string ShortName => _shortName;

        public object IdPrefix => _idPrefix;

        public bool Online => _online;

        public int Players => _players;

        public int Queue => _queue;

        public int MaxPlayers => _maxPlayers;

        public int MapId => _mapId;

        public int DisplayOrder => _displayOrder;

        public int SpeedLimiter => _speedLimiter;

        public bool Collisions => _collisions;

        public bool CarsForPlayers => _carsForPlayers;

        public bool PoliceCarsForPlayers => _policeCarsForPlayers;

        public bool AfkEnabled => _afkEnabled;

        public bool Event => _event;

        public bool SpecialEvent => _specialEvent;

        public bool ProMods => _proMods;

        public int SyncDelay => _syncDelay;
    }
}