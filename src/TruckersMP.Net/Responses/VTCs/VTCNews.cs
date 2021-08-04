using Newtonsoft.Json;

namespace TruckersMP.Net
{
    public class VTCNews
    {
        [JsonProperty("news")]
        private readonly NewsPostSimple[] _news;

        public NewsPostSimple[] News => _news;
    }
}