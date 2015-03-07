using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _10_Extract_text_from_XML
{
    class ExtractTextFromXML
    {
        /*Write a program that extracts from given XML file all the text without the tags.
Example:

<?xml version="1.0"><student><name>Pesho</name><age>21</age><interests count="3"><interest>Games</interest><interest>C#</interest><interest>Java</interest></interests></student>
          
   Expected output: Pesho21GamesC#Java
         */
        static void Main(string[] args)      // All text files are in the CURRENT PROJECT FOLDER
        {
            StringBuilder sb = new StringBuilder();
            // Extract string
            using (StreamReader reader = new StreamReader(@"..\..\file.xml"))
            {
                string line = reader.ReadLine();
              
                while(line != null)
                {
                    sb.Append(line);
                    line = reader.ReadLine();
                }
            }

          //  Console.WriteLine(sb.ToString());

            string HTML_TAG_PATTERN = "<.*?>";
            string result = Regex.Replace(sb.ToString(), HTML_TAG_PATTERN, string.Empty);
            Console.WriteLine(result);
        }
    }
}
