using Newtonsoft.Json;

namespace TruckersMP.Net
{
    public class VTC
    {
        [JsonProperty("id")]
        private readonly int _id;

        [JsonProperty("name")]
        private readonly string _name;

        [JsonProperty("owner_id")]
        private readonly int _ownerId;

        [JsonProperty("owner_username")]
        private readonly string _ownerUsername;

        [JsonProperty("slogan")]
        private readonly string _slogan;

        [JsonProperty("tag")]
        private readonly string _tag;

        [JsonProperty("logo")]
        private readonly string _logo;

        [JsonProperty("cover")]
        private readonly string _cover;

        [JsonProperty("information")]
        private readonly string _information;

        [JsonProperty("rules")]
        private readonly string _rules;

        [JsonProperty("requirements")]
        private readonly string _requirements;

        [JsonProperty("website")]
        private readonly string _website;

        [JsonProperty("socials")]
        private readonly Socials _socials;

        [JsonProperty("games")]
        private readonly Games _games;

        [JsonProperty("members_count")]
        private readonly int _membersCount;

        [JsonProperty("recruitment")]
        private readonly string _recruitment;

        [JsonProperty("language")]
        private readonly string _language;

        [JsonProperty("verified")]
        private readonly bool _verified;

        [JsonProperty("validated")]
        private readonly bool _validated;

        [JsonProperty("created")]
        private readonly string _created;

        public int Id => _id;

        public string Name => _name;

        public int OwnerId => _ownerId;

        public string OwnerUsername => _ownerUsername;

        public string Slogan => _slogan;

        public string Tag => _tag;

        public string Logo => _logo;

        public string Cover => _cover;

        public string Information => _information;

        public string Rules => _rules;

        public string Requirements => _requirements;

        public string Website => _website;

        public Socials Socials => _socials;

        public Games Games => _games;

        public int MembersCount => _membersCount;

        public string Recruitment => _recruitment;

        public string Language => _language;

        public bool Verified => _verified;

        public bool Validated => _validated;

        public string Created => _created;
    }
}