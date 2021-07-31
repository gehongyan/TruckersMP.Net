using System.Threading.Tasks;
using TruckersMP.Net.Responses.Versions;

namespace TruckersMP.Net.Requests.Versions
{
    /// <summary>
    ///     Information about the current TruckersMP version for ETS2 and ATS
    /// </summary>
    public class VersionRequest : TruckersMPRequestBase, IRequestHasNoParams<GameVersion>
    {
        protected override string GetEndpoint()
        {
            return "version";
        }

        public async Task<GameVersion> SendAsync()
        {
            return await SendInternalAsync<GameVersion>().ConfigureAwait(false);
        }
    }
}