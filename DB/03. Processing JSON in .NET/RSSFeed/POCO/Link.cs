
namespace RSSFeed
{
    using Newtonsoft.Json;

    class Link
    {
        [JsonProperty("@href")]
        public string Href { get; set; }
    }
}
