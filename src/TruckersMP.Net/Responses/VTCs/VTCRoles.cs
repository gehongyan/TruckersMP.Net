using Newtonsoft.Json;

namespace TruckersMP.Net
{
    public class VTCRoles
    {
        [JsonProperty("roles")]
        private readonly Role[] _roles;

        public Role[] Roles => _roles;
    }
}