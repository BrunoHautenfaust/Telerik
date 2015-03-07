using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Delete_odd_lines
{
    class DeleteOddLines
    {
        /*Write a program that deletes from given text file all odd lines.
        The result should be in the same file.*/

        static void Main(string[] args)      // All text files are in the CURRENT PROJECT FOLDER
        {
            // Step 1 - remove odd lines and save them in temp.txt
            using (StreamReader reader = new StreamReader(@"..\..\text.txt"))
            {
                using (StreamWriter writer = new StreamWriter(@"..\..\temp.txt"))
                {
                    string line = reader.ReadLine();
                    int count = 0;

                    while (line != null)
                    {
                        if (count % 2 == 0)
                        {
                            writer.WriteLine(line);
                        }
                        else if (count % 2 != 0)
                        {
                            writer.WriteLine();
                        }
                        line = reader.ReadLine();
                        count++;
                    }
                }
            }

            // Step 2 -Empty text file
            File.WriteAllText(@"..\..\text.txt", String.Empty);

            // Step 3 - copy contents from temp to text.txt
            using (StreamReader reader = new StreamReader(@"..\..\temp.txt"))
            {
                using (StreamWriter writer = new StreamWriter(@"..\..\text.txt"))
                {
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        writer.WriteLine(line);
                        line = reader.ReadLine();
                    }
                }
            }

            // Step 4 - delete temp.txt
            File.Delete(@"..\..\temp.txt");

            Console.WriteLine("Deletion complete. All odd lines removed.");
        }
    }
}
