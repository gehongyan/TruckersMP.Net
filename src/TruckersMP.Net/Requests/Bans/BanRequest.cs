using System.Threading.Tasks;

namespace TruckersMP.Net
{
    /// <summary>
    /// Latest 5 bans for a selected user
    /// if bans are not hidden or user has no bans.
    /// Use player lookup to check if user is currently banned
    /// </summary>
    public class BanRequest : TruckersMPRequestBase, IRequestHasOneParam<Ban[], int>
    {
        private long _id;

        protected override string GetEndpoint()
        {
            return $"bans/{_id}";
        }

        /// <param name="truckersMPId">TruckersMP ID</param>
        public async Task<Ban[]> SendAsync(int truckersMPId)
        {
            _id = truckersMPId;
            return await SendAsync<Ban[]>().ConfigureAwait(false);
        }

        /// <param name="steamId64">SteamID64</param>
        public async Task<Ban[]> SendAsync(long steamId64)
        {
            _id = steamId64;
            return await SendAsync<Ban[]>().ConfigureAwait(false);
        }
    }
}