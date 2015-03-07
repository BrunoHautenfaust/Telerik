using System;

    class CorrectBrackets
    {
          //Write a program to check if in a given expression the brackets are put correctly.
        // Example of correct expression: ((a+b)/5-d). Example of incorrect expression: )(a+b)).
           
        static void Main(string[] args)
        {
            Console.WriteLine("Write a mathematical expression:");
            string text = Console.ReadLine();
            char[] arr = text.ToCharArray();

           bool result = BracketCountCheck(arr);
           Console.WriteLine("Brackets position in expression: {0}", result);
        }

        private static bool BracketCountCheck(char[] a)
        {
            int bracketCount = 0;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == '(')
                {
                    bracketCount++;
                }
                else if (a[i] == ')')
                {
                    bracketCount--;
                }
                if (bracketCount < 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
