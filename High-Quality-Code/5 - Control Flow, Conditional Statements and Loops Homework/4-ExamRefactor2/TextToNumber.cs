namespace _4_ExamRefactor2
{
    using System;
    public class Zad2
    {
        static void Main()
        {
            /*
             * You are given a text and a number (M). This text can contain digits, Latin letters (both capital and letter case) and any other symbols, except for '@'. The number is used to the parsing of the text.
Your task is to go through all characters of the text and, starting from RESULT = 0, to perform the following operations:
•	If the current character is '@', stop the program and print the RESULT
•	If the current character is a digit (0-9), then multiply the RESULT by this digit
•	If the current character is a letter, add its number from the Latin alphabet to RESULT. 'A' is with number 0
•	If the current character is a symbol, that is different from the ones above, create module of the RESULT by the provided number (M)
             *  M will always be between 2000 and 10 000.
             */
            int number;
            do
            {
                 Console.WriteLine("Input number between 2000 and 10 000:");
                 number = int.Parse(Console.ReadLine());    // 2001
            } while(number < 2000 || number > 10000);
           
            Console.WriteLine("Input some text:");
            string text = Console.ReadLine();               // Hello .NET 5! My name is Peter 8-)@
            long result = 0;

            for (int i = 0; i < text.Length; i++)
            {
                char currentChar = text[i];
                // Console.WriteLine(currentChar);

                if (currentChar == '@')
                {
                    break;
                }
                else if (Char.IsDigit(currentChar))
                {
                    result *= currentChar - '0';
                }
                else if (Char.IsLetter(currentChar))
                {
                    result += char.ToUpper(currentChar) - 65;
                }
                else
                {
                    result %= number;
                }

            }
            Console.WriteLine(result);
        }
    }
}
