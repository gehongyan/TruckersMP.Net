using Newtonsoft.Json;

namespace TruckersMP.Net
{
    public class VTCSimple
    {
        [JsonProperty("id")]
        public int Id { get; init; }

        [JsonProperty("name")]
        public string Name { get; init; }

        [JsonProperty("owner_id")]
        public int OwnerId { get; init; }

        [JsonProperty("owner_username")]
        public string OwnerUsername { get; init; }

        [JsonProperty("slogan")]
        public string Slogan { get; init; }

        [JsonProperty("tag")]
        public string Tag { get; init; }

        [JsonProperty("website")]
        public string Website { get; init; }

        [JsonProperty("socials")]
        public Socials Socials { get; init; }

        [JsonProperty("games")]
        public Games Games { get; init; }

        [JsonProperty("members_count")]
        public int MembersCount { get; init; }

        [JsonProperty("recruitment")]
        public string Recruitment { get; init; }

        [JsonProperty("language")]
        public string Language { get; init; }

        [JsonProperty("verified")]
        public bool Verified { get; init; }

        [JsonProperty("validated")]
        public bool Validated { get; init; }

        [JsonProperty("created")]
        public string Created { get; init; }
    }
}