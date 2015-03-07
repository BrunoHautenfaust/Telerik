using System;

    class SquareRoot
    {
        static void Main(string[] args)
        {
            /*Write a program that reads an integer number and calculates and prints its square root.
            If the number is invalid or negative, print Invalid number.
            In all cases finally print Good bye.
            Use try-catch-finally block.*/

            try
            {
                Console.WriteLine("Input an integer:");
                int number = int.Parse(Console.ReadLine());

                if (number < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                // Must be after the throw, otherwise would Sqrt the number and output would be (NaN)
                Console.WriteLine(Math.Sqrt(number));  
            }
            catch (OverflowException)
            {
                Console.WriteLine("Invalid number.");
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Invalid number!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Not a number.");
            }
            finally
            {
                Console.WriteLine("Goodbye!");
            }
        }
    }

