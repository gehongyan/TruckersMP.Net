using System.Threading.Tasks;
using TruckersMP.Net.Responses.VTCs;

namespace TruckersMP.Net.Requests.VTCs
{
    /// <summary>
    ///     Specific VTC information
    /// </summary>
    public class VTCInformationRequest : TruckersMPRequestBase, IRequestHasOneParam<VTC, int>, IRequestHasOneParam<VTC, string>
    {
        private string _idOrSlug;

        protected override string GetEndpoint()
        {
            return $"vtc/{_idOrSlug}";
        }

        public async Task<VTC> SendAsync(int id)
        {
            _idOrSlug = id.ToString();
            return await SendAsync<VTC>().ConfigureAwait(false);
        }

        public async Task<VTC> SendAsync(string slug)
        {
            _idOrSlug = slug;
            return await SendAsync<VTC>().ConfigureAwait(false);
        }
    }
}