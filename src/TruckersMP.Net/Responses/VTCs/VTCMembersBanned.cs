using System.Collections.Generic;
using Newtonsoft.Json;

namespace TruckersMP.Net
{
    /// <summary>
    ///     List of specific VTC banned members
    /// </summary>
    public class VTCMembersBanned
    {
        [JsonProperty("members")]
        public IReadOnlyCollection<Member> Members { get; init; }

        [JsonProperty("members_banned_count")]
        public int MembersBannedCount { get; init; }
    }
}