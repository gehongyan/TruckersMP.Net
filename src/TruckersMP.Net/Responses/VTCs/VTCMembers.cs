using Newtonsoft.Json;

namespace TruckersMP.Net.Responses.VTCs
{
    /// <summary>
    ///     List of specific VTC members
    /// </summary>
    public class VTCMembers
    {
        [JsonProperty("members")]
        private readonly Member[] _members;

        [JsonProperty("members_count")]
        private readonly int _membersCount;

        public Member[] Members => _members;

        public int MembersCount => _membersCount;
    }
}