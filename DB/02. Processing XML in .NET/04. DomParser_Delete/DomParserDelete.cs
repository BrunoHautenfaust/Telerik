namespace _04.DomParser_Delete
{
    using System;
    using System.Xml;

    public class Program
    {
        public static void Main(string[] args)
        {
            var doc = new XmlDocument();
            doc.Load("../../catalog.xml");
            XmlElement root = doc.DocumentElement;


            XmlNodeList albums = root.ChildNodes;
            foreach(XmlElement album in albums)
            {
                string albumPrice = album["price"].InnerText;
                double price = double.Parse(albumPrice);
                if (price > 20)
                {
                    root.RemoveChild(album);
                }
            }

            doc.Save("../../newCatalog.xml");
            Console.WriteLine("Changes saved.");

        }
    }
}
