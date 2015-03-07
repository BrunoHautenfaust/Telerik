using System;
using System.IO;
using System.Net;

class DownloadFile
{
    /*Write a program that downloads a file from Internet (e.g. Ninja image) and stores it the current directory.
Find in Google how to download files in C#.
Be sure to catch all exceptions and to free any used resources in the finally block.*/

    static void Main(string[] args)
    {
        try
        {
            using (WebClient Client = new WebClient())
            {
                Client.DownloadFile("http://telerikacademy.com/Content/Images/news-img01.png", "ninja.png");
                Console.WriteLine("File saved at {0}", Directory.GetCurrentDirectory());
            }
        }
        catch (ArgumentNullException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (WebException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (NotSupportedException ex)
        {
            Console.WriteLine(ex.Message);
        }

    }
}

