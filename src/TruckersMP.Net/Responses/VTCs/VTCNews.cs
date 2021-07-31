using Newtonsoft.Json;

namespace TruckersMP.Net.Responses.VTCs
{
    public class VTCNews
    {
        [JsonProperty("news")]
        private readonly NewsPostSimple[] _news;

        public NewsPostSimple[] News => _news;
    }
}