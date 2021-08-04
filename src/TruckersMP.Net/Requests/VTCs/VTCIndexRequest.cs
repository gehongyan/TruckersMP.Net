using System.Threading.Tasks;

namespace TruckersMP.Net
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