using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Count_words
{
    class CountWords
    {
        /*Write a program that reads a list of words from the file words.txt and finds how many times each of the words is contained in another file test.txt.
The result should be written in the file result.txt and the words should be sorted by the number of their occurrences in descending order.
Handle all possible exceptions in your methods.*/

        static void Main(string[] args)      // All text files are in the CURRENT PROJECT FOLDER
        {

            var dict = new Dictionary<string, int>();

            // Extract words 

            string[] words = ExtractWordsFromFile();


            // Fill dict
            FillDict(dict, words);

            // Extract text to StringBuilder:
            string[] text = TextToStringBuilder();


            // Words occurence count
            WordOccurenceCount(dict, words, text);

            // Descending Sort TEST_OK + StringBuilder
            StringBuilder sb = SortDescAndToStringBuilder(dict);

            // Write to file
            WriteToFile(sb);
        }

        private static void WriteToFile(StringBuilder sb)
        {
            File.WriteAllText(@"..\..\result.txt", sb.ToString());
            //     Console.WriteLine(sb.ToString());
            Console.WriteLine("Words occurence written in \"result.txt.\"");
        }

        private static StringBuilder SortDescAndToStringBuilder(Dictionary<string, int> dict)
        {
            StringBuilder sb = new StringBuilder();
            foreach (KeyValuePair<string, int> element in dict.OrderByDescending(key => key.Value))
            {
                // Console.WriteLine("{0} - {1}", author.Key, author.Value);
                sb.AppendLine(string.Format("{0}: {1}", element.Key, element.Value));
            }
            return sb;
        }

        private static void WordOccurenceCount(Dictionary<string, int> dict, string[] words, string[] text)
        {
            int count = 0;
            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < text.Length; j++)
                {
                    if (words[i].Equals(text[j]))
                    {
                        count++;
                        dict[words[i]] = count;
                    }
                }
                count = 0;
            }
        }

        private static string[] TextToStringBuilder()
        {
            StringBuilder txt = new StringBuilder();
            txt.Append(File.ReadAllText(@"..\..\text.txt"));
            string[] text = txt.ToString().Split(' ').ToArray();
            // Console.WriteLine(text.ToString());
            return text;
        }

        private static void FillDict(Dictionary<string, int> dict, string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                dict.Add(words[i], 0);
            }
            /*
            // TEST DICT FILL _ OK
            foreach (var item in dict)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }
            */
        }


        private static string[] ExtractWordsFromFile()
        {
            StringBuilder sb = new StringBuilder();
            try
            {
                using (StreamReader wordsReader = new StreamReader(@"..\..\words.txt"))
                {
                    string line = wordsReader.ReadLine();

                    while (line != null)
                    {
                        sb.Append(line).Append(' ');
                        line = wordsReader.ReadLine();
                    }
                }
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FileLoadException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FileNotFoundException ex)
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
