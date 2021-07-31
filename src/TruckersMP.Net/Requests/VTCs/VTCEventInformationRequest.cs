using System.Threading.Tasks;
using TruckersMP.Net.Responses.Events;

namespace TruckersMP.Net.Requests.VTCs
{
    /// <summary>
    ///     Specific VTC event
    /// </summary>
    public class VTCEventInformationRequest : TruckersMPRequestBase, IRequestHasTwoParams<Event, int, int>, IRequestHasTwoParams<Event, string, int>
    {
        private string _idOrSlug;
        private int _eventId;

        protected override string GetEndpoint()
        {
            return $"vtc/{_idOrSlug}/events/{_eventId}";
        }

        public async Task<Event> SendAsync(int vtcId, int eventId)
        {
            _idOrSlug = vtcId.ToString();
            _eventId = eventId;
            return await SendAsync<Event>().ConfigureAwait(false);
        }

        public async Task<Event> SendAsync(string vtcSlug, int eventId)
        {
            _idOrSlug = vtcSlug;
            _eventId = eventId;
            return await SendAsync<Event>().ConfigureAwait(false);
        }
    }
}