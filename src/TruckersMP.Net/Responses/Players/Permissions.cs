using Newtonsoft.Json;

namespace TruckersMP.Net
{
    public class Permissions
    {
        [JsonProperty("isStaff")]
        public bool IsStaff { get; init; }

        [JsonProperty("isUpperStaff")]
        public bool IsUpperStaff { get; init; }

        [JsonProperty("isGameAdmin")]
        public bool IsGameAdmin { get; init; }

        [JsonProperty("showDetailedOnWebMaps")]
        public bool ShowDetailedOnWebMaps { get; init; }
    }
}