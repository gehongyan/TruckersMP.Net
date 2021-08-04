using System.Threading.Tasks;
using TruckersMP.Net.Exceptions;

namespace TruckersMP.Net
{
    /// <summary>
    ///     The current in-game time.
    ///     Game time is expressed in minutes,
    ///     where 10 real seconds is 1 minute of in-game time.
    ///     It is number of minutes since 2015-25-10 15:48:32 CET.
    /// </summary>
    /// <remarks>
    ///     Note: Game time may not be exact as time will drift.
    /// </remarks>
    public class GameTimeRequest : TruckersMPRequestBase, IRequestHasNoParams<int>
    {
        protected override string GetEndpoint()
        {
            return "game_time";
        }

        public async Task<int> SendAsync()
        {
            GameTimeResponse response = await SendInternalAsync<GameTimeResponse>().ConfigureAwait(false);

            if (response.Error)
            {
                throw new RequestException();
            }

            return response.GameTime;
        }
    }
}