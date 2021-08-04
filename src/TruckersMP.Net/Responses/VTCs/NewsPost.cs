using Newtonsoft.Json;

namespace TruckersMP.Net
{
    public class NewsPost
    {
        [JsonProperty("id")]
        private readonly int _id;

        [JsonProperty("title")]
        private readonly string _title;

        [JsonProperty("content_summary")]
        private readonly string _contentSummary;

        [JsonProperty("content")]
        private readonly string _content;

        [JsonProperty("author_id")]
        private readonly int _authorId;

        [JsonProperty("author")]
        private readonly string _author;

        [JsonProperty("pinned")]
        private readonly bool _pinned;

        public int Id => _id;

        public string Title => _title;

        public string ContentSummary => _contentSummary;

        public string Content => _content;

        public int AuthorId => _authorId;

        public string Author => _author;

        public bool Pinned => _pinned;
    }
}