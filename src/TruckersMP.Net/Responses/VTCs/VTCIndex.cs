using Newtonsoft.Json;

namespace TruckersMP.Net.Responses.VTCs
{
    public class VTCIndex
    {
        [JsonProperty("recent")]
        private VTCSimple[] _recent;

        [JsonProperty("featured")]
        private VTCSimple[] _featured;

        [JsonProperty("featured_cover")]
        private VTCSimple[] _featuredCover;

        public VTCSimple[] Recent => _recent;

        public VTCSimple[] Featured => _featured;

        public VTCSimple[] FeaturedCover => _featuredCover;
    }
}