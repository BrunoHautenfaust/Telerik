using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Replace_sub_string
{
    class ReplaceSubstring
    {
        /*Write a program that replaces all occurrences of the sub-string start with the sub-string finish in a text file.
Ensure it will work with large files (e.g. 100 MB).*/

        static void Main(string[] args)      // All text files are in the CURRENT PROJECT FOLDER
        {
            using (StreamWriter writer = new StreamWriter(@"..\..\output.txt"))
            {
                using (StreamReader reader = new StreamReader(@"..\..\text.txt"))
                {
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        line = line.Replace("start", "FINISH");   // Uppercase so you can spot the word
                        writer.WriteLine(line);
                        line = reader.ReadLine();
                    }
                }
            }
            Console.WriteLine("All occurrences were replaced and written in output.txt.");
        }
    }
}
