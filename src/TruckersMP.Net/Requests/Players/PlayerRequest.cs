using System.Threading.Tasks;
using TruckersMP.Net.Responses.Players;

namespace TruckersMP.Net.Requests.Players
{
    /// <summary>
    ///     Lookup player information
    /// </summary>
    public class PlayerRequest : TruckersMPRequestBase, IRequestHasOneParam<Player, int>, IRequestHasOneParam<Player, long>
    {
        private long _id;

        protected override string GetEndpoint()
        {
            return $"player/{_id}";
        }

        /// <param name="truckersMPId">TruckersMP ID</param>
        public async Task<Player> SendAsync(int truckersMPId)
        {
            _id = truckersMPId;
            return await SendAsync<Player>().ConfigureAwait(false);
        }

        /// <param name="steamId64">SteamID64</param>
        public async Task<Player> SendAsync(long steamId64)
        {
            _id = steamId64;
            return await SendAsync<Player>().ConfigureAwait(false);
        }
    }
}