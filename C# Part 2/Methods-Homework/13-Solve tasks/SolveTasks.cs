using System;

    class SolveTasks
    {
        static void Main(string[] args)
        {
            /*Write a program that can solve these tasks:
         Reverses the digits of a number
         Calculates the average of a sequence of integers
         Solves a linear equation a * x + b = 0
         Create appropriate methods.
         Provide a simple text-based menu for the user to choose which task to solve.
         Validate the input data:
         The decimal number should be non-negative
         The sequence should not be empty
         a should not be equal to 0*/

            Console.WriteLine(@"What do you want to do:
1/ Reverse the digits of a number
2/ Calculate the average of a sequence of integers
3/ Solve a linear equation   a * x + b = 0
====
Input number:");

            int choice = int.Parse(Console.ReadLine());

            switch(choice)
            {
                case 1:
                    {
                        Console.Clear();
                        ReverseDigits();
                    }
                    break;

                case 2:
                    {
                        Console.Clear();
                        Average();
                    }
                    break;

                case 3:
                    {
                        Console.Clear();
                        LinearEq();
                    }
                break;
            default:
                Console.WriteLine("Invalid input.");
                break;
            }

        }
        // Reverse:
        public static void ReverseDigits()
        {
            Console.WriteLine("Reverse the digits of a number");
            int numInt = 0;
            do
            {
                Console.WriteLine("Input a positive number:");
                numInt = int.Parse(Console.ReadLine());

            } while (numInt < 0);

            string number = numInt.ToString();
            char[] numberArr = number.ToCharArray();
            Array.Reverse(numberArr);
            foreach (char num in numberArr)
            {
                Console.Write(num);
            }
            Console.WriteLine();
        }

        // Average:
          public static void Average()
          {
            Console.WriteLine("Calculate the average of a sequence of integers");
            string text = String.Empty;
            do
            {
                Console.WriteLine("Input a sequence of numbers, separated by space or ,:");
                text = Console.ReadLine();
            } while (text == String.Empty);
            char[] delimiters = new char[] { ' ', ',' };
            string[] sequence = text.Split(delimiters);
            int[] numbers = new int[sequence.Length];
              // convert to int
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Convert.ToInt32(sequence[i]);
            }
             // average calculation
            decimal sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            decimal average = sum / numbers.Length;
            Console.WriteLine("The average is {0}", average);
          }
          // Solve a linear equation:     a * x + b = 0
        public static void LinearEq()
          {
              Console.WriteLine("Solve a linear equation (a * x + b = 0)");
              decimal a = 0;
            do
            {
                Console.WriteLine("Input a (must not be equal to 0):");
                a = decimal.Parse(Console.ReadLine());
            } while (a == 0);
            Console.WriteLine("Input b:");
            decimal b = decimal.Parse(Console.ReadLine());
            Console.WriteLine("{0}*x + {1} = 0", a, b);
            decimal result = -b / a;
            Console.WriteLine("x = {0}", result);
          }

        }
   

