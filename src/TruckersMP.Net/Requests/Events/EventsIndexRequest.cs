using System.Threading.Tasks;
using TruckersMP.Net.Responses.Events;

namespace TruckersMP.Net.Requests.Events
{
    /// <summary>
    ///     List of available TruckersMP servers and their status
    /// </summary>
    public class EventsIndexRequest : TruckersMPRequestBase, IRequestHasNoParams<EventsIndex>
    {
        protected override string GetEndpoint()
        {
            return "events";
        }

        public async Task<EventsIndex> SendAsync()
        {
            return await SendAsync<EventsIndex>().ConfigureAwait(false);
        }
    }
}