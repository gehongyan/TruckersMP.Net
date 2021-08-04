using System.Threading.Tasks;
using TruckersMP.Net.Exceptions;

namespace TruckersMP.Net
{
    /// <summary>
    ///     Current in-game rules.
    /// </summary>
    public class RulesRequest : TruckersMPRequestBase, IRequestHasNoParams<GameRules>
    {
        protected override string GetEndpoint()
        {
            return "rules";
        }

        public async Task<GameRules> SendAsync()
        {
            RulesResponse response = await SendInternalAsync<RulesResponse>().ConfigureAwait(false);

            if (response.Error)
            {
                throw new RequestException();
            }

            return new GameRules(response.RulesContent, response.Revision);
        }
    }
}