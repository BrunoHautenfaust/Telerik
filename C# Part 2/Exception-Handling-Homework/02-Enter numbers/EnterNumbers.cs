using System;

class EnterNumbers
{
    /*Write a method ReadNumber(int start, int end) that enters an integer number in a given range [start…end].
     If an invalid number or non-number text is entered, the method should throw an exception.
     Using this method write a program that enters 10 numbers: a1, a2, … a10, such that 1 < a1 < … < a10 < 100*/

    static void Main(string[] args)
    {
        int number = 0;
        number = ReadNumber(number);
    }

    // METHOD:
    private static int ReadNumber(int n)
    {
        int min = 0;
        for (int i = 0; i < 10; i++)
        {
            try
            {
                Console.WriteLine("Input a number[between 1 and 100]:");
                Console.Write("{0}/", i + 1);
                n = int.Parse(Console.ReadLine());

                if (n < 1 || n > 100)
                {
                    throw new ArgumentOutOfRangeException();
                }
            }

            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            if (min < n)
            {
                min = n;
            }
            else
            {
                Console.WriteLine("The number must be bigger than the previous one.");
                break;
            }
        }

        return n;
    }


}

