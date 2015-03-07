using System;

    class EnglishDigit
    {
        static void Main(string[] args)
        {
            // Write a method that returns the last digit of given integer as an English word.

            Console.WriteLine("Input a number:");
            int num = int.Parse(Console.ReadLine());

            LastDigit(num);

        }

        static int LastDigit(int number)
        {
            number %= 10;

            switch (number)
            {
                case 0:
                    Console.WriteLine("Zero");
                    break;
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                case 3:
                    Console.WriteLine("Three");
                    break;
                case 4:
                    Console.WriteLine("Four");
                    break;
                case 5:
                    Console.WriteLine("Five");
                    break;
                case 6:
                    Console.WriteLine("Six");
                    break;
                case 7:
                    Console.WriteLine("Seven");
                    break;
                case 8:
                    Console.WriteLine("Eight");
                    break;
                case 9:
                    Console.WriteLine("Nine");
                    break;
                default:
                    Console.WriteLine("Error!");
                    break;
            }
            return 0;
        }

    }

