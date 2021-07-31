using System.Threading.Tasks;
using TruckersMP.Net.Responses.Events;

namespace TruckersMP.Net.Requests.Events
{
    /// <summary>
    ///     Specific event information
    /// </summary>
    public class EventRequest : TruckersMPRequestBase, IRequestHasOneParam<Event, int>
    {
        private int _id;

        protected override string GetEndpoint()
        {
            return $"events/{_id}";
        }

        public async Task<Event> SendAsync(int id)
        {
            _id = id;
            return await SendAsync<Event>().ConfigureAwait(false);
        }
    }
}