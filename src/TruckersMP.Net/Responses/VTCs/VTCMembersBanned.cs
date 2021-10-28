using Newtonsoft.Json;

namespace TruckersMP.Net
{
    /// <summary>
    ///     List of specific VTC banned members
    /// </summary>
    public class VTCMembersBanned
    {
        [JsonProperty("members")]
        private readonly Member[] _members;

        [JsonProperty("members_banned_count")]
        private readonly int _membersBannedCount;

        public Member[] Members => _members;

        public int MembersBannedCount => _membersBannedCount;
    }
}