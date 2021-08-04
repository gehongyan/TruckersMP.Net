using System.Threading.Tasks;

namespace TruckersMP.Net
{
    /// <summary>
    ///     List of specific VTC news
    /// </summary>
    public class VTCNewsRequest : TruckersMPRequestBase, IRequestHasOneParam<VTCNews, int>, IRequestHasOneParam<VTCNews, string>
    {
        private string _idOrSlug;

        protected override string GetEndpoint()
        {
            return $"vtc/{_idOrSlug}/news";
        }

        public async Task<VTCNews> SendAsync(int id)
        {
            _idOrSlug = id.ToString();
            return await SendAsync<VTCNews>().ConfigureAwait(false);
        }

        public async Task<VTCNews> SendAsync(string vtcSlug)
        {
            _idOrSlug = vtcSlug;
            return await SendAsync<VTCNews>().ConfigureAwait(false);
        }
    }
}