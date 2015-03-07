using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Compare_text_files
{
    class CompareTextFiles
    {
        /*Write a program that compares two text files line by line and prints the number of lines that are the same and the number of lines that are different.
            Assume the files have equal number of lines.*/

        static void Main(string[] args)      // All text files are in the CURRENT PROJECT FOLDER
        {
            int SameLinesCount = 0;
            int DiffLinesCount = 0;
            using (StreamReader reader1 = new StreamReader(@"..\..\pizza1.txt"))
            {
                using (StreamReader reader2 = new StreamReader(@"..\..\pizza2.txt"))
                {
                    string line1 = reader1.ReadLine();
                    string line2 = reader2.ReadLine();
                   
                    while (line1 != null && line2 != null)
                    {
                        if (line1 == line2)
                        {
                            SameLinesCount++;
                        }
                        else
                        {
                            DiffLinesCount++;
                        }
                        line1 = reader1.ReadLine();
                        line2 = reader2.ReadLine();
                    }
                }
            }
            Console.WriteLine("Same number of lines: {0}", SameLinesCount);
            Console.WriteLine("Different number of lines: {0}", DiffLinesCount);
        }
    }
}
