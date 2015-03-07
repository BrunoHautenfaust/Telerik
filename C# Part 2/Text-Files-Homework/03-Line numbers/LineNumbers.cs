using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Line_numbers
{
    class LineNumbers
    {
        //Write a program that reads a text file and inserts line numbers in front of each of its lines.
        //The result should be written to another text file.

        static void Main(string[] args)      // All text files are in the CURRENT PROJECT FOLDER
        {
            using (StreamWriter writer = new StreamWriter(@"..\..\lineNumbers.txt"))
            {
                using (StreamReader reader = new StreamReader(@"..\..\ingredients.txt"))
                {
                    string line = reader.ReadLine();
                    int count = 1;
                    while(line != null)
                    {
                        writer.WriteLine("{0} - {1}", count, line);
                        line = reader.ReadLine();
                        count++;
                    }
                }

            }
            Console.WriteLine("Line numbers added and a new file \"lineNumbers.txt\" was created.");
        }
    }
}
