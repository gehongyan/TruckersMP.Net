using Newtonsoft.Json;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TruckersMP.Net.Exceptions;

namespace TruckersMP.Net
{
    public abstract class TruckersMPRequestBase
    {
        private const string ApiEndpoint = "api.truckersmp.com";
        private const string ApiVersion = "v2";
        private readonly HttpClient _httpClient;

        protected TruckersMPRequestBase()
        {
            _httpClient = new HttpClient(new HttpClientHandler
            {
                AutomaticDecompression = DecompressionMethods.Brotli,
                UseCookies = false,
                UseProxy = false
            });
        }

        public string Url => $"https://{ApiEndpoint}/{ApiVersion}/{GetEndpoint()}";

        /// <summary>
        /// Derived class should return the endpoint string
        /// </summary>
        /// <returns>Endpoint string</returns>
        protected abstract string GetEndpoint();

        private async Task<string> SendRequestAsync(string requestContent = default, HttpMethod httpMethod = default)
        {
            httpMethod ??= HttpMethod.Get;
            HttpRequestMessage request = new(httpMethod, Url);

            if (requestContent is not null)
            {
                request.Content = new StringContent(requestContent, Encoding.UTF8, "application/json");
            }

            HttpResponseMessage response = await _httpClient.SendAsync(request).ConfigureAwait(false);
            return await response.Content.ReadAsStringAsync().ConfigureAwait(false);
        }

        public async Task<T> SendInternalAsync<T>()
        {
            string responseContent = await SendRequestAsync().ConfigureAwait(false);
            return JsonConvert.DeserializeObject<T>(responseContent);
        }

        public async Task<TEntity> SendAsync<TEntity>()
        {
            TruckersMPEntityResponseBase<TEntity> entity = await SendInternalAsync<TruckersMPEntityResponseBase<TEntity>>().ConfigureAwait(false);

            if (entity is null) throw new RequestException();

            if (!entity.Error) return entity.Response;

            if (entity.Descriptor == "Page not found") throw new PageNotFountException();
            if (entity.Descriptor == "PRIVATE_MEMBERS") throw new PrivateMembersException();

            throw new RequestException();
        }
    }
}