using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Reverse_sentence
{
    /*Write a program that reverses the words in given sentence.
    Example:

input:	                                output:
C# is not C++, not PHP and not Delphi!	Delphi not and PHP, not C++ not is C#!
     */

    class ReverseSentence
    {
        static void Main(string[] args)
        {
            string text = "C# is not C++, not PHP and not Delphi!";
            string[] splitText = text.Split(' ', '!');
            Array.Reverse(splitText);
           string reversed = string.Join(" ", splitText).TrimStart()+"!";
           Console.WriteLine(reversed);

        }
    }
}
