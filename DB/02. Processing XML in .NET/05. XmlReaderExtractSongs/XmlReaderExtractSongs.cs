namespace _05.XmlReaderExtractSongs
{
    using System;
    using System.Xml;

    public class XmlReaderExtractSongs
    {
        public static void Main(string[] args)
        {
            using (XmlReader reader = new XmlTextReader("../../catalog.xml"))
            {
                while (reader.Read())
                {
                    if (reader.NodeType == XmlNodeType.Element && reader.Name == "title")
                    {
                        Console.WriteLine(reader.ReadElementString());
                    }
                }
            }
        }
    }
}
