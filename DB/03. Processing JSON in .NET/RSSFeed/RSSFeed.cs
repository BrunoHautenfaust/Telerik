namespace RSSFeed
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Xml;

    public class RSSFeed
    {
        public static void Main(string[] args)
        {

            string xml = GetXmlData();
            // Console.WriteLine(xml);

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xml);

            string json = JsonConvert.SerializeXmlNode(doc, Newtonsoft.Json.Formatting.Indented);
            //Console.WriteLine(json);

            var jObj = JObject.Parse(json);
            
            var videoTitles = jObj["feed"]["entry"].Select(t => t["title"]);
           
            foreach(var title in videoTitles)
            {
                Console.WriteLine(title);
            }

            var videos = jObj["feed"]["entry"].Select(v => JsonConvert.DeserializeObject<Video>(v.ToString()));

            GenerateHTML(videos);

            Console.WriteLine("\n HTML page generated in Project folder.\n");
        }

        private static string GetXmlData()
        {
            Console.OutputEncoding = Encoding.UTF8;
            var webClient = new WebClient();
            var data = webClient.DownloadData("https://www.youtube.com/feeds/videos.xml?channel_id=UCLC-vbm7OWvpbqzXaoAMGGw");
            string xml = Encoding.UTF8.GetString(data);
            return xml;
        }

        private static void GenerateHTML(IEnumerable<Video> videos)
        {
            var sb = new StringBuilder();
            sb.AppendLine(@"<!DOCTYPE html>
                        <html>
                        <head>
                            <title>Videos</title>
                        </head>
<style> body { 
background: -moz-linear-gradient(top,  #c9de96 0%, #8ab66b 44%, #398235 100%); /* FF3.6+ */
background: -webkit-gradient(linear, left top, left bottom, color-stop(0%,#c9de96), color-stop(44%,#8ab66b), color-stop(100%,#398235)); /* Chrome,Safari4+ */
background: -webkit-linear-gradient(top,  #c9de96 0%,#8ab66b 44%,#398235 100%); /* Chrome10+,Safari5.1+ */
background: -o-linear-gradient(top,  #c9de96 0%,#8ab66b 44%,#398235 100%); /* Opera 11.10+ */
background: -ms-linear-gradient(top,  #c9de96 0%,#8ab66b 44%,#398235 100%); /* IE10+ */
background: linear-gradient(to bottom,  #c9de96 0%,#8ab66b 44%,#398235 100%); /* W3C */
filter: progid:DXImageTransform.Microsoft.gradient( startColorstr='#c9de96', endColorstr='#398235',GradientType=0 ); /* IE6-9 */
}
</style>
                        <body>
                        <ul>");

            foreach (var video in videos)
            {
                sb.AppendFormat("<li><a href=\"{0}\"/><strong>{1}:</strong><br>", video.Link.Href, video.Title);
                sb.AppendFormat("<br><iframe width=\"500\" height=\"350\" src=\"http://www.youtube.com/embed/{0}\"></iframe></li>", video.VideoID);
            }

            sb.AppendLine("</ul></body></html>");

            var html = sb.ToString();

            File.WriteAllText("../../videos.html", html, Encoding.UTF8);
        }
    }
}
