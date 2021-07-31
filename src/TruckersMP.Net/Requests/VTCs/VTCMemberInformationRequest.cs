using System.Threading.Tasks;
using TruckersMP.Net.Responses.VTCs;

namespace TruckersMP.Net.Requests.VTCs
{
    /// <summary>
    ///     Specific VTC member
    /// </summary>
    public class VTCMemberInformationRequest : TruckersMPRequestBase, IRequestHasTwoParams<Member, int, int>, IRequestHasTwoParams<Member, string, int>
    {
        private string _idOrSlug;
        private int _memberId;

        protected override string GetEndpoint()
        {
            return $"vtc/{_idOrSlug}/member/{_memberId}";
        }

        public async Task<Member> SendAsync(int vtcId, int memberId)
        {
            _idOrSlug = vtcId.ToString();
            _memberId = memberId;
            return await SendAsync<Member>().ConfigureAwait(false);
        }

        public async Task<Member> SendAsync(string vtcSlug, int memberId)
        {
            _idOrSlug = vtcSlug;
            _memberId = memberId;
            return await SendAsync<Member>().ConfigureAwait(false);
        }
    }
}