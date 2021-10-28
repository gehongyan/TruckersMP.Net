using Newtonsoft.Json;

namespace TruckersMP.Net
{
    public class NewsPost
    {
        [JsonProperty("id")]
        public int Id { get; init; }

        [JsonProperty("title")]
        public string Title { get; init; }

        [JsonProperty("content_summary")]
        public string ContentSummary { get; init; }

        [JsonProperty("content")]
        public string Content { get; init; }

        [JsonProperty("author_id")]
        public int AuthorId { get; init; }

        [JsonProperty("author")]
        public string Author { get; init; }

        [JsonProperty("pinned")]
        public bool Pinned { get; init; }
    }
}