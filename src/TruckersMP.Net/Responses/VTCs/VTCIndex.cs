using System.Collections.Generic;
using Newtonsoft.Json;

namespace TruckersMP.Net
{
    public class VTCIndex
    {
        [JsonProperty("recent")]
        public IReadOnlyCollection<VTCSimple> Recent { get; init; }

        [JsonProperty("featured")]
        public IReadOnlyCollection<VTCSimple> Featured { get; init; }

        [JsonProperty("featured_cover")]
        public IReadOnlyCollection<VTCSimple> FeaturedCover { get; init; }
    }
}