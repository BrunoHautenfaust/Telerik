using System;
using System.IO;
using System.Security;

    class ReadFileContents
    {
        /*Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), reads its contents and prints it on the console.
            Find in MSDN how to use System.IO.File.ReadAllText(…).
            Be sure to catch all possible exceptions and print user-friendly error messages.*/

        static void Main(string[] args)
        {
            // Creates a new text file with text in it. Location: Current project/bin/Debug
            using (StreamWriter writer =
                new StreamWriter("text.txt"))
                writer.Write("This is some random text in the file.");

            Console.WriteLine("A text file with contents was created at {0}\n", Directory.GetCurrentDirectory());
          
            // Access text file and print its contents on the console
            Console.WriteLine("Enter full path to file (include the file extension):");
            string path = Console.ReadLine();

            try
            { 
            string readText = File.ReadAllText(path);
            Console.WriteLine(readText);
            }

            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (PathTooLongException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
           
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (NotSupportedException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (SecurityException ex)
            {
                Console.WriteLine(ex.Message);
            }
         
        }
    }

