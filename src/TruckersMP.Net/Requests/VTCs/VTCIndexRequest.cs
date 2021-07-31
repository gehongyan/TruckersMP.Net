using System.Threading.Tasks;
using TruckersMP.Net.Responses.VTCs;

namespace TruckersMP.Net.Requests.VTCs
{
    /// <summary>
    ///     VTC index page information
    /// </summary>
    public class VTCIndexRequest : TruckersMPRequestBase, IRequestHasNoParams<VTCIndex>
    {
        protected override string GetEndpoint()
        {
            return "vtc";
        }

        public async Task<VTCIndex> SendAsync()
        {
            return await SendAsync<VTCIndex>().ConfigureAwait(false);
        }
    }
}