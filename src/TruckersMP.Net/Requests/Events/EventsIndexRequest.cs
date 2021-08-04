using System.Threading.Tasks;

namespace TruckersMP.Net
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