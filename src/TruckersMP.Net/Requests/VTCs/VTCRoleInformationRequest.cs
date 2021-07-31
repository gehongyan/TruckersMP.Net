using System.Threading.Tasks;
using TruckersMP.Net.Responses.VTCs;

namespace TruckersMP.Net.Requests.VTCs
{
    /// <summary>
    ///     Specific VTC role
    /// </summary>
    public class VTCRoleInformationRequest : TruckersMPRequestBase, IRequestHasTwoParams<Role, int, int>, IRequestHasTwoParams<Role, string, int>
    {
        private string _idOrSlug;
        private int _roleId;

        protected override string GetEndpoint()
        {
            return $"vtc/{_idOrSlug}/role/{_roleId}";
        }

        public async Task<Role> SendAsync(int vtcId, int roleId)
        {
            _idOrSlug = vtcId.ToString();
            _roleId = roleId;
            return await SendAsync<Role>().ConfigureAwait(false);
        }

        public async Task<Role> SendAsync(string vtcSlug, int memberId)
        {
            _idOrSlug = vtcSlug;
            _roleId = memberId;
            return await SendAsync<Role>().ConfigureAwait(false);
        }
    }
}