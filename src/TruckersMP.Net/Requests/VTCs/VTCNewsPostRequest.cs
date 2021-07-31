using System.Threading.Tasks;
using TruckersMP.Net.Responses.VTCs;

namespace TruckersMP.Net.Requests.VTCs
{
    /// <summary>
    ///     Specific VTC news post
    /// </summary>
    public class VTCNewsPostRequest : TruckersMPRequestBase, IRequestHasTwoParams<NewsPost, int, int>, IRequestHasTwoParams<NewsPost, string, int>
    {
        private string _idOrSlug;
        private int _postId;

        protected override string GetEndpoint()
        {
            return $"vtc/{_idOrSlug}/news/{_postId}";
        }

        public async Task<NewsPost> SendAsync(int vtcId, int postId)
        {
            _idOrSlug = vtcId.ToString();
            _postId = postId;
            return await SendAsync<NewsPost>().ConfigureAwait(false);
        }

        public async Task<NewsPost> SendAsync(string vtcSlug, int memberId)
        {
            _idOrSlug = vtcSlug;
            _postId = memberId;
            return await SendAsync<NewsPost>().ConfigureAwait(false);
        }
    }
}