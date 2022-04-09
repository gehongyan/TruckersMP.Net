using System.Threading.Tasks;

namespace TruckersMP.Net
{
    /// <summary>
    ///     List of specific VTC events
    /// </summary>
    public class VTCAttendingEventsRequest : TruckersMPRequestBase, IRequestHasOneParam<EventWithSimpleAttendances[], int>, IRequestHasOneParam<EventWithSimpleAttendances[], string>
    {
        private string _idOrSlug;

        protected override string GetEndpoint()
        {
            return $"vtc/{_idOrSlug}/events/attending";
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