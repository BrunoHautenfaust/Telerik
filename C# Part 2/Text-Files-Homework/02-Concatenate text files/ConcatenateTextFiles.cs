using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Concatenate_text_files
{
    class ConcatenateTextFiles
    {
        // Write a program that concatenates two text files into another text file.

        static void Main(string[] args)         // All text files are in the CURRENT PROJECT FOLDER
        {
            using (StreamWriter writer = new StreamWriter(@"..\..\concat_text.txt"))
            {
                // First Reader
                using (StreamReader reader1 = new StreamReader(@"..\..\text1.txt"))
                {
                    string line = reader1.ReadLine();
                    while (line != null)
                    {
                        writer.WriteLine(line);
                        line = reader1.ReadLine();
                    }
                }

                // Second Reader
                using (StreamReader reader2 = new StreamReader(@"..\..\text2.txt"))
                {
                    string line = reader2.ReadLine();
                    while (line != null)
                    {
                        writer.WriteLine(line);
                        line = reader2.ReadLine();
                    }

                }
                Console.WriteLine("A new text file called \"concat_text.txt\" was created.");


            }
        }
    }
}
