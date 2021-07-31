using Newtonsoft.Json;

namespace TruckersMP.Net.Responses.Players
{
    public class PlayerVTCInfo
    {
        [JsonProperty("id")] private readonly int _id;
        [JsonProperty("name")] private readonly string _name;
        [JsonProperty("tag")] private readonly string _tag;
        [JsonProperty("inVTC")] private readonly bool _inVtc;
        [JsonProperty("memberID")] private readonly int _memberId;

        public int Id => _id;

        public string Name => _name;

        public string Tag => _tag;

        public bool InVtc => _inVtc;

        public int MemberId => _memberId;
    }
}