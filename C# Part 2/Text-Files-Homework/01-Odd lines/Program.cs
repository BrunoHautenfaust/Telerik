using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Odd_lines
{
    class Program
    {
        // Write a program that reads a text file and prints on the console its odd lines.

        static void Main(string[] args)     // All text files are in the CURRENT PROJECT FOLDER
        {
           
            using (StreamReader reader = new StreamReader(@"..\..\text.txt"))
            {
                int lineNum = 0;
                string line = reader.ReadLine();
                while (line != null)
                {
                    if (lineNum % 2 == 1)
                    {
                        Console.WriteLine(line);
                    }
                    lineNum++;
                    line = reader.ReadLine();
                }
            }


        }
    }
}
