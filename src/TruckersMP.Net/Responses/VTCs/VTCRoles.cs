using System.Collections.Generic;
using Newtonsoft.Json;

namespace TruckersMP.Net
{
    public class VTCRoles
    {
        [JsonProperty("roles")]
        public IReadOnlyCollection<Role> Roles { get; init; }
    }
}