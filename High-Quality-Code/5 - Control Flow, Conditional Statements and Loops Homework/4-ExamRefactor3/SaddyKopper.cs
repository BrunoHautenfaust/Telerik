namespace _4_ExamRefactor3
{
    using System;
    using System.Numerics;
    class Zad3
    {
        static void Main(string[] args)
        {
            /*  SOLUTION IS NOT 100%. BGCODER EVALUATES 50/100 POINTS.
             
             The steps for performing the mathematical transformation follow:
1.	Saddy gets a random positive number from the public
2.	Saddy removes the last digit (the rightmost one) from the number
3.	Saddy then finds all digits at even positions (starting from zero) and finds their sum
4.	Saddy returns again to the step 2 and continues until no digits are left
5.	Saddy then finds the product of all sums found from the current number
6.	Saddy then takes the product as a new number and in this way one transformation occurred
7.	If the new number has only one digit, Saddy stops the magic trick and tells the public how many transformations occurred in total and what is the final resulted number
8.	Else if this is not the 10th transformation in turn, Saddy gets the new number and starts again with it from step 2
9.	If this is the 10th transformation in turn, Saddy stops the magic trick and tells the public the final resulted number
             * 
             •	The number from the public will be between 10,000,000 and 99,999,999,999,999,999
            ------------------------------
             * Example input - 123456789
             * Example output - 3
             *                  9
             */
            BigInteger number;
            do
            {
                Console.WriteLine("Input a number between 10,000,000 and 99,999,999,999,999,999:");
                number = BigInteger.Parse(Console.ReadLine());
            } while(number < 10000000 || number > 99999999999999999);
            //int counter = 0;
            BigInteger innerSum = 0;
            BigInteger innerProduct = 1;
            int transformation = 0;

            string text = number.ToString();
           
            while (text.Length > 1)
            {
                text = text.Remove(text.Length - 1);
                
                // New:
                for (int i = 0; i < text.Length; i += 2)
                {
                    innerSum += text[i] - '0';
                }
                
                // Old:
                //foreach (char symbol in text)
                //{
                //    if (counter % 2 == 0)
                //    {
                //        innerSum += symbol - '0';
                //    }
                //    counter++;
                //}
                innerProduct *= innerSum;
                innerSum = 0;               
                //counter = 0;                
               
                if (text.Length == 1 && transformation < 10)
                {
                    transformation++;
                    text = innerProduct.ToString();
                    innerProduct = 1;
                }
                else if (transformation == 10)
                {
                    text = innerProduct.ToString();
                    innerProduct = 1;
                    break;
                }

            }
            if (transformation < 10)
            {
                Console.WriteLine(transformation);
            }
            Console.WriteLine(text);
        }
    }
}
