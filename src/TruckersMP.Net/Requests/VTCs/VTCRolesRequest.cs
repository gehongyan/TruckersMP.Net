using System.Threading.Tasks;

namespace TruckersMP.Net
{
    /// <summary>
    ///     List of specific VTC roles
    /// </summary>
    public class VTCRolesRequest : TruckersMPRequestBase, IRequestHasOneParam<VTCRoles, int>, IRequestHasOneParam<VTCRoles, string>
    {
        private string _idOrSlug;

        protected override string GetEndpoint()
        {
            return $"vtc/{_idOrSlug}/roles";
        }

        public async Task<VTCRoles> SendAsync(int id)
        {
            _idOrSlug = id.ToString();
            return await SendAsync<VTCRoles>().ConfigureAwait(false);
        }

        public async Task<VTCRoles> SendAsync(string vtcSlug)
        {
            _idOrSlug = vtcSlug;
            return await SendAsync<VTCRoles>().ConfigureAwait(false);
        }
    }
}