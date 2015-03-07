using System;

class SubstringInText
{
    /*Write a program that finds how many times a sub-string is contained in a given text (perform case insensitive search).
Example:

The target sub-string is "in"

The text is as follows: We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.

The result is: 9*/


    static void Main(string[] args)
    {
        string text = "We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";

        string target = "in";   // length = 2;
        int count = 0;
        for (int i = 0; i < text.Length - 1; i++)
        {
            if (text.Substring(i, target.Length).ToLower() == target)
            {
                count++;
                i += target.Length;
            }
        }
        Console.WriteLine("Target substring is found {0} times in the string.", count);
    }
}
