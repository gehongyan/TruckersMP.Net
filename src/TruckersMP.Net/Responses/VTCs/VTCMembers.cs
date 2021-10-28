using System.Collections.Generic;
using Newtonsoft.Json;

namespace TruckersMP.Net
{
    /// <summary>
    ///     List of specific VTC members
    /// </summary>
    public class VTCMembers
    {
        [JsonProperty("members")]
        public IReadOnlyCollection<Member> Members { get; init; }

        [JsonProperty("members_count")]
        public int MembersCount { get; init; }
    }
}