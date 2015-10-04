namespace _07.TextToXML
{
    using System;
    using System.IO;
    using System.Xml;

    public class TextToXML
    {
        public static void Main(string[] args)
        {

            string[] lines = System.IO.File.ReadAllLines("../../info.txt");

            XmlDocument doc = new XmlDocument();
            XmlNode rootNode = doc.CreateElement("persons");
            doc.AppendChild(rootNode);
            XmlNode personNode = doc.CreateElement("person");
            rootNode.AppendChild(personNode);

            XmlNode nameNode = doc.CreateElement("name");
            XmlNode addressNode = doc.CreateElement("address");
            XmlNode phoneNumberNode = doc.CreateElement("phoneNumber");
            personNode.AppendChild(nameNode);
            personNode.AppendChild(addressNode);
            personNode.AppendChild(phoneNumberNode);

            nameNode.InnerText = lines[0];
            addressNode.InnerText = lines[1];
            phoneNumberNode.InnerText = lines[2];

            doc.Save("../../info.xml");
            Console.WriteLine("Xml document \"info.xml\" saved in Project directory.");
        }
    }
}
