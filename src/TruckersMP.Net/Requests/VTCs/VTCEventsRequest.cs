using System.Threading.Tasks;
using TruckersMP.Net.Responses.Events;

namespace TruckersMP.Net.Requests.VTCs
{
    /// <summary>
    ///     List of specific VTC events
    /// </summary>
    public class VTCEventsRequest : TruckersMPRequestBase, IRequestHasOneParam<EventWithSimpleAttendances[], int>, IRequestHasOneParam<EventWithSimpleAttendances[], string>
    {
        private string _idOrSlug;

        protected override string GetEndpoint()
        {
            return $"vtc/{_idOrSlug}/events";
        }

        public async Task<EventWithSimpleAttendances[]> SendAsync(int id)
        {
            _idOrSlug = id.ToString();
            return await SendAsync<EventWithSimpleAttendances[]>().ConfigureAwait(false);
        }

        public async Task<EventWithSimpleAttendances[]> SendAsync(string vtcSlug)
        {
            _idOrSlug = vtcSlug;
            return await SendAsync<EventWithSimpleAttendances[]>().ConfigureAwait(false);
        }
    }
}