using System.Collections.Generic;
using Newtonsoft.Json;

namespace TruckersMP.Net
{
    public class VTCNews
    {
        [JsonProperty("news")]
        public IReadOnlyCollection<NewsPostSimple> News { get; init; }
    }
}