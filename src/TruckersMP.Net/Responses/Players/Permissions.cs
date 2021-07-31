using Newtonsoft.Json;

namespace TruckersMP.Net.Responses.Players
{
    public class Permissions
    {
        [JsonProperty("isStaff")] private readonly bool _isStaff;
        [JsonProperty("isUpperStaff")] private readonly bool _isUpperStaff;
        [JsonProperty("isGameAdmin")] private readonly bool _isGameAdmin;
        [JsonProperty("showDetailedOnWebMaps")] private readonly bool _showDetailedOnWebMaps;

        public bool IsStaff => _isStaff;

        public bool IsUpperStaff => _isUpperStaff;

        public bool IsGameAdmin => _isGameAdmin;

        public bool ShowDetailedOnWebMaps => _showDetailedOnWebMaps;
    }
}