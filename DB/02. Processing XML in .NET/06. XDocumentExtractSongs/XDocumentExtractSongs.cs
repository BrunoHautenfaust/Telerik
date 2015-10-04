namespace _06.XDocumentExtractSongs
{
    using System;
    using System.Linq;
    using System.Xml.Linq;

    public class XDocumentExtractSongs
    {
        public static void Main(string[] args)
        {
            var doc = XDocument.Load("../../catalog.xml");
            var albums = doc.Element("catalog").Elements("album");

            var titles = from title in albums.Descendants("title") select title.Value;

            foreach (var title in titles)
            {
                Console.WriteLine(title);
            }
        }
    }
}
