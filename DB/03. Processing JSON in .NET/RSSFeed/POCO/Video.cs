namespace RSSFeed
{
    using Newtonsoft.Json;

    class Video
    {
        [JsonProperty("yt:videoId")]
        public string VideoID { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
        
        [JsonProperty("link")]
        public Link Link { get; set; }
       
    }
}
/*
 <id>yt:video:Wu1K7UHk9XA</id>
<yt:videoId>Wu1K7UHk9XA</yt:videoId>
<yt:channelId>UCLC-vbm7OWvpbqzXaoAMGGw</yt:channelId>
<title>Моделиране на данни</title>
<link rel="alternate" href="http://www.youtube.com/watch?v=Wu1K7UHk9XA"/>
 */