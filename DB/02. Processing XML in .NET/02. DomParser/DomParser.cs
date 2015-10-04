namespace DomParser
{
    using System;
    using System.Collections.Generic;
    using System.Xml;

    public class DomParser
    {
        public static void Main()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("../../catalog.xml");
            XmlElement root = doc.DocumentElement;

            XmlNodeList artists = root.GetElementsByTagName("artist");
            var artistDict = new Dictionary<string, int>();

            foreach (XmlElement artist in artists)
            {
                string artistName = artist.InnerText;
                if (artistDict.ContainsKey(artistName))
                {
                    artistDict[artistName]++;
                }
                else
                {
                    artistDict.Add(artistName, 1);
                }
            }

            foreach (var artist in artistDict)
            {
                Console.WriteLine("{0} - {1} albums(s)", artist.Key, artist.Value);
            }
        }
    }
}