using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace TruckersMP.Net.Responses.Events
{
    public class EventBase
    {
        [JsonProperty("id")] private readonly int _id;
        [JsonProperty("event_type")] private readonly EventType _eventType;
        [JsonProperty("name")] private readonly string _name;
        [JsonProperty("slug")] private readonly string _slug;
        [JsonProperty("game")] private readonly string _game;
        [JsonProperty("server")] private readonly ServerSimple _server;
        [JsonProperty("language")] private readonly string _language;
        [JsonProperty("departure")] private readonly Place _departure;
        [JsonProperty("arrive")] private readonly Place _arrive;
        [JsonProperty("start_at")] private readonly DateTime _startAt;
        [JsonProperty("banner")] private readonly string _banner;
        [JsonProperty("map")] private readonly string _map;
        [JsonProperty("description")] private readonly string _description;
        [JsonProperty("rule")] private readonly string _rule;
        [JsonProperty("voice_link")] private readonly string _voiceLink;
        [JsonProperty("external_link")] private readonly string _externalLink;
        [JsonProperty("featured")] private readonly string _featured;
        [JsonProperty("vtc")] private readonly EventVTCInfo _vtc;
        [JsonProperty("user")] private readonly User _user;
        [JsonProperty("dlcs")] private readonly object _dlcResult;
        [JsonProperty("url")] private readonly string _url;
        [JsonProperty("created_at")] private readonly DateTime _createdAt;
        [JsonProperty("updated_at")] private readonly DateTime _updatedAt;

        public int Id => _id;

        public EventType EventType => _eventType;

        public string Name => _name;

        public string Slug => _slug;

        public string Game => _game;

        public ServerSimple Server => _server;

        public string Language => _language;

        public Place Departure => _departure;

        public Place Arrive => _arrive;

        public DateTime StartAt => _startAt;

        public string Banner => _banner;

        public string Map => _map;

        public string Description => _description;

        public string Rule => _rule;

        public string VoiceLink => _voiceLink;

        public string ExternalLink => _externalLink;

        public string Featured => _featured;

        public EventVTCInfo Vtc => _vtc;

        public User User => _user;

        [JsonIgnore]
        public Dictionary<string, string> DLCs
        {
            get
            {
                try
                {
                    return JsonConvert.DeserializeObject<Dictionary<string, string>>(
                        JsonConvert.SerializeObject(_dlcResult));
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }

        public string Url => _url;

        public DateTime CreatedAt => _createdAt;

        public DateTime UpdatedAt => _updatedAt;
    }
}