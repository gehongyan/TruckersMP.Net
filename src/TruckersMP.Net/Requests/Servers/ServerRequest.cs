using System.Threading.Tasks;
using TruckersMP.Net.Responses.Servers;

namespace TruckersMP.Net.Requests.Servers
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