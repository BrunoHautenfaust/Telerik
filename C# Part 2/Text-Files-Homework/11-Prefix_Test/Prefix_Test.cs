using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Prefix_Test
{
    class Prefix_Test
    {
        /*Write a program that deletes from a text file all words that start with the prefix 'test'.
          Words contain only the symbols 0…9, a…z, A…Z, _.
         */

        static void Main(string[] args)      // All text files are in the CURRENT PROJECT FOLDER
        {
            StringBuilder sb = new StringBuilder();
            using (StreamReader reader = new StreamReader(@"..\..\text.txt"))
            {
                string line = reader.ReadLine();
                while( line != null)
                {
                    sb.Append(line);
                    line = reader.ReadLine();
                }
            }

            char[] delimiters = {' ', '\t'};

            string[] text = sb.ToString()
                .Split(delimiters, StringSplitOptions.RemoveEmptyEntries)
                .Where(x => !x.StartsWith("test", StringComparison.OrdinalIgnoreCase))
                .ToArray();

            string result = String.Join(" ", text);
        //    Console.WriteLine(result);
           
              File.WriteAllText(@"..\..\text.txt", String.Empty);

              File.WriteAllText(@"..\..\text.txt", result);

              Console.WriteLine("Prefix test is ready. Check \"text.txt\"");

        }
    }
}
