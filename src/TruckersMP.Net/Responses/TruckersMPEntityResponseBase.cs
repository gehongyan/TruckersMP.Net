using Newtonsoft.Json;

namespace TruckersMP.Net
{
    public class TruckersMPEntityResponseBase<T> : TruckersMPResponseBase
    {
        [JsonProperty("response")]
        public T Response { get; set; }
    }
}