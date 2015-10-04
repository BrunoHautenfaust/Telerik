namespace _03.XPath
{
    using System;
    using System.Collections.Generic;
    using System.Xml;

    public class XPath
    {
        public static void Main(string[] args)
        {
            var doc = new XmlDocument();
            doc.Load("../../catalog.xml");

            string xPathQuery = "/catalog/album/artist";

            XmlNodeList artists = doc.SelectNodes(xPathQuery);

            var artistsAndAlbums = new Dictionary<string, int>();

            foreach (XmlNode artist in artists)
            {
                string artistName = artist.InnerText;

                if (artistsAndAlbums.ContainsKey(artistName))
                {
                    artistsAndAlbums[artistName] += 1;
                }
                else
                {
                    artistsAndAlbums.Add(artistName, 1);
                }
            }

            foreach (var pair in artistsAndAlbums)
            {
                Console.WriteLine("{0} - {1} album(s)", pair.Key, pair.Value);
            }

        }
    }
}
