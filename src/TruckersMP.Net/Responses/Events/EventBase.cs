using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace TruckersMP.Net
{
    public class EventBase
    {
        [JsonProperty("dlcs")] private readonly object _dlcResult;

        [JsonProperty("id")]
        public int Id { get; init; }

        [JsonProperty("event_type")]
        public EventType EventType { get; init; }

        [JsonProperty("name")]
        public string Name { get; init; }

        [JsonProperty("slug")]
        public string Slug { get; init; }

        [JsonProperty("game")]
        public string Game { get; init; }

        [JsonProperty("server")]
        public ServerSimple Server { get; init; }

        [JsonProperty("language")]
        public string Language { get; init; }

        [JsonProperty("departure")]
        public Place Departure { get; init; }

        [JsonProperty("arrive")]
        public Place Arrive { get; init; }

        [JsonProperty("start_at")]
        public DateTime StartAt { get; init; }

        [JsonProperty("banner")]
        public string Banner { get; init; }

        [JsonProperty("map")]
        public string Map { get; init; }

        [JsonProperty("description")]
        public string Description { get; init; }

        [JsonProperty("rule")]
        public string Rule { get; init; }

        [JsonProperty("voice_link")]
        public string VoiceLink { get; init; }

        [JsonProperty("external_link")]
        public string ExternalLink { get; init; }

        [JsonProperty("featured")]
        public string Featured { get; init; }

        [JsonProperty("vtc")]
        public EventVTCInfo Vtc { get; init; }

        [JsonProperty("user")]
        public User User { get; init; }

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

        [JsonProperty("url")]
        public string Url { get; init; }

        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; init; }

        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; init; }
    }
}