using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _08_Replace_whole_word
{
    class ReplaceWholeWord
    {
        // Modify the solution of the previous problem to replace only whole words (not strings).

        static void Main(string[] args)      // All text files are in the CURRENT PROJECT FOLDER
        {
            using (StreamReader streamReader = new StreamReader("../../text.txt"))
            {
                using (StreamWriter streamWriter = new StreamWriter("../../output.txt"))
                {
                    string line = streamReader.ReadLine();

                    while (line != null)
                    {
                        streamWriter.WriteLine(Regex.Replace(line, @"\bstart\b", "FINISH"));
                        line = streamReader.ReadLine();
                    }
                }
            }
            Console.WriteLine("All occurrences were replaced and written in output.txt.");
        }
    }
}
