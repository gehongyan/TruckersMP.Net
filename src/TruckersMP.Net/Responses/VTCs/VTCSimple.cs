using Newtonsoft.Json;

namespace TruckersMP.Net.Responses.VTCs
{
    public class VTCSimple
    {
        [JsonProperty("id")]
        private int _id;

        [JsonProperty("name")]
        private string _name;

        [JsonProperty("owner_id")]
        private int _ownerId;

        [JsonProperty("owner_username")]
        private string _ownerUsername;

        [JsonProperty("slogan")]
        private string _slogan;

        [JsonProperty("tag")]
        private string _tag;

        [JsonProperty("website")]
        private string _website;

        [JsonProperty("socials")]
        private Socials _socials;

        [JsonProperty("games")]
        private Games _games;

        [JsonProperty("members_count")]
        private int _membersCount;

        [JsonProperty("recruitment")]
        private string _recruitment;

        [JsonProperty("language")]
        private string _language;

        [JsonProperty("verified")]
        private bool _verified;

        [JsonProperty("validated")]
        private bool _validated;

        [JsonProperty("created")]
        private string _created;

        public int Id => _id;

        public string Name => _name;

        public int OwnerId => _ownerId;

        public string OwnerUsername => _ownerUsername;

        public string Slogan => _slogan;

        public string Tag => _tag;

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