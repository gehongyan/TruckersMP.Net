using System.Threading.Tasks;

namespace TruckersMP.Net
{
    /// <summary>
    ///     List of currently banned user of specific VTC
    /// </summary>
    public class VTCMembersBannedRequest : TruckersMPRequestBase, IRequestHasOneParam<VTCMembersBanned, int>, IRequestHasOneParam<VTCMembersBanned, string>
    {
        private string _idOrSlug;

        protected override string GetEndpoint()
        {
            return $"vtc/{_idOrSlug}/members/banned";
        }

        public async Task<VTCMembersBanned> SendAsync(int id)
        {
            _idOrSlug = id.ToString();
            return await SendAsync<VTCMembersBanned>().ConfigureAwait(false);
        }

        public async Task<VTCMembersBanned> SendAsync(string vtcSlug)
        {
            _idOrSlug = vtcSlug;
            return await SendAsync<VTCMembersBanned>().ConfigureAwait(false);
        }
    }
}