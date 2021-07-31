using System.Threading.Tasks;
using TruckersMP.Net.Responses.VTCs;

namespace TruckersMP.Net.Requests.VTCs
{
    /// <summary>
    ///     List of specific VTC members
    /// </summary>
    public class VTCMembersRequest : TruckersMPRequestBase, IRequestHasOneParam<VTCMembers, int>, IRequestHasOneParam<VTCMembers, string>
    {
        private string _idOrSlug;

        protected override string GetEndpoint()
        {
            return $"vtc/{_idOrSlug}/members";
        }

        public async Task<VTCMembers> SendAsync(int id)
        {
            _idOrSlug = id.ToString();
            return await SendAsync<VTCMembers>().ConfigureAwait(false);
        }

        public async Task<VTCMembers> SendAsync(string vtcSlug)
        {
            _idOrSlug = vtcSlug;
            return await SendAsync<VTCMembers>().ConfigureAwait(false);
        }
    }
}