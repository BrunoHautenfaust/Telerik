using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Remove_words
{
    class RemoveWords
    {
        // Write a program that removes from a text file all words listed in given another text file.
        // Handle all possible exceptions in your methods.

        static void Main(string[] args)      // All text files are in the CURRENT PROJECT FOLDER
        {
            try
            {
                string[] words = ExtractWordsFromFile();

                StringBuilder text = new StringBuilder();
                text.Append(File.ReadAllText(@"..\..\text.txt"));
                // Console.WriteLine(text.ToString());


                // Prepare string "replaced"
                string replaced = text.ToString();
                for (int i = 0; i < words.Length; i++)
                {
                    if (replaced.Contains(words[i]))
                    {
                        replaced = replaced.Replace(words[i], String.Empty);
                    }
                }

                // Empty text.txt
                File.WriteAllText(@"..\..\text.txt", String.Empty);

                using (StreamWriter writer = new StreamWriter(@"..\..\text.txt"))
                {
                    writer.Write(replaced);
                }

                //  Console.WriteLine(replaced);

                Console.WriteLine("Word removal completed. Open \"text.txt\" file to see result.");

            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (EndOfStreamException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        private static string[] ExtractWordsFromFile()
        {
            StringBuilder sb = new StringBuilder();
            using (StreamReader wordsReader = new StreamReader(@"..\..\words.txt"))
            {
                string line = wordsReader.ReadLine();

                while (line != null)
                {
                    sb.Append(line).Append(' ');
                    line = wordsReader.ReadLine();
                }
            }
            //       Console.WriteLine(sb.ToString());
            string[] words = sb.ToString().Trim().Split(' ').ToArray();

            // WORDS TEST WORDS TEST 
            /*
            foreach (var item in words)
            {
                Console.WriteLine(item);
            }
            */
            return words;
        }
    }
}
