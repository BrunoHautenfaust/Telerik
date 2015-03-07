using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Save_sorted_names
{
    class SaveSortedNames
    {
        /*
     Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file.
    Example:

input.txt	      output.txt
Ivan                George 
Peter               Ivan            
Maria               Maria 
George              Peter
         */
        static void Main(string[] args)      // All text files are in the CURRENT PROJECT FOLDER
        {
            var names = new List<string>();
            names = ReadAndSortNames(names);

            string outputFilePath = @"..\..\output.txt";

            File.WriteAllLines(outputFilePath, names);
            Console.WriteLine("The names were sorted and saved in \"output.txt\".");

        }

        private static List<string> ReadAndSortNames(List<string> names)
        {
            using (StreamReader reader = new StreamReader(@"..\..\input.txt"))
            {

                string line = reader.ReadLine();
                while (line != null)
                {
                    names.Add(line);
                    line = reader.ReadLine();
                }
                names.Sort();
                /* SORT LIST TEST: OK
                foreach (var name in names)
                {
                    Console.WriteLine(name);
                }
                */
            }
            return names;
        }
    }
}

