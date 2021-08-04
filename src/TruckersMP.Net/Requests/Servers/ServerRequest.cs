using System.Threading.Tasks;

namespace TruckersMP.Net
{
    /// <summary>
    ///     List of available TruckersMP servers and their status
    /// </summary>
    public class ServerRequest : TruckersMPRequestBase, IRequestHasNoParams<Server[]>
    {
        protected override string GetEndpoint()
        {
            return "servers";
        }

        public async Task<Server[]> SendAsync()
        {
            return await SendAsync<Server[]>().ConfigureAwait(false);
        }
    }
}