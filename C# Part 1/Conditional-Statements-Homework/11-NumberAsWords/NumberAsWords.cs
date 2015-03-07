using System;


namespace _11_NumberAsWords
{
    class NumberAsWords
    {
        static void Main()
        {
            // Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation.

            int n = 0;
            int units = 0, teens = 0, tens = 0, hundreds = 0;
            do
            {
                Console.WriteLine("Input a number(0-999):");
                n = int.Parse(Console.ReadLine());
            } while (n < 0 || n > 999);

            if (n>=0 || n<=9)   // IF for units - OK
            {
                units = n;
            }

            if (n>=11 || n<=19) // IF for teens - OK
            {
                teens = n;
            }

            if (n >= 10 || n <= 90)
            {
                tens = (n / 10) * 10;  // Ex. 27/10 = 2*10 = 20;
                units = n % 10;
            }
            /*
            if (n>=100 || n<=900)
            {
                hundreds = n / 100;
                tens = (n / 10) % 10;
                units = n % 10;
            }
            */
            // HUNDREDS
            switch (hundreds)
            {
                case 100:
                    Console.Write("one hundred ");
                    break;
                case 200:
                    Console.Write("two hundred ");
                    break;
                case 300:
                    Console.Write("three hundred ");
                    break;
                case 400:
                    Console.Write("four hundred ");
                    break;
                case 500:
                    Console.Write("five hundred ");
                    break;
                case 600:
                    Console.Write("six hundred ");
                    break;
                case 700:
                    Console.Write("seven hundred ");
                    break;
                case 800:
                    Console.Write("eight hundred ");
                    break;
                case 900:
                    Console.Write("nine hundred ");
                    break;
            }
            // TENS
            switch (tens)
            {
                case 10:
                    Console.Write("ten");
                    break;
                case 20:
                    Console.Write("twenty ");
                    break;
                case 30:
                    Console.Write("thirty ");
                    break;
                case 40:
                    Console.Write("fourty ");
                    break;
                case 50:
                    Console.Write("fifty ");
                    break;
                case 60:
                    Console.Write("sixty ");
                    break;
                case 70:
                    Console.Write("seventy ");
                    break;
                case 80:
                    Console.Write("eighty ");
                    break;
                case 90:
                    Console.Write("ninety ");
                    break;
            }
            // TEENS
            switch (teens)
            {
                case 11:
                    Console.Write("eleven");
                    break;
                case 12:
                    Console.Write("twelve");
                    break;
                case 13:
                    Console.Write("thirteen");
                    break;
                case 14:
                    Console.Write("fourteen");
                    break;
                case 15:
                    Console.Write("fifteen");
                    break;
                case 16:
                    Console.Write("sixteen");
                    break;
                case 17:
                    Console.Write("seventeen");
                    break;
                case 18:
                    Console.Write("eighteen");
                    break;
                case 19:
                    Console.Write("nineteen");
                    break;
            }
            // UNITS
        switch(units)
        {
            case 0:
                Console.Write("zero");
                break;
            case 1:
                Console.Write("one");
                break;
            case 2:
                Console.Write("two");
                break;
            case 3:
                Console.Write("three");
                break;
            case 4:
                Console.Write("four");
                break;
            case 5:
                Console.Write("five");
                break;
            case 6:
                Console.Write("six");
                break;
            case 7:
                Console.Write("seven");
                break;
            case 8:
                Console.Write("eight");
                break;
            case 9:
                Console.Write("nine");
                break;
        }
            
           
            
        }
    }
}
