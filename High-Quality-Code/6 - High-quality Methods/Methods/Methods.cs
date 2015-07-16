﻿namespace Methods
{
    using System;

    class Methods
    {
        static double CalculateTriangleArea(double a, double b, double c)  
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentException("Sides should be positive.");
            }
           
            double s = (a + b + c) / 2;
            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            return area;
        }

        static string NumberToDigit(int number)
        {
            switch (number)
            {
                case 0: return "zero";
                case 1: return "one";
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7: return "seven";
                case 8: return "eight";
                case 9: return "nine";
                default: return "Invalid number!";
            }
        }

        static int FindMax(params int[] elements)
        {
            if (elements == null || elements.Length == 0)
            {
                throw new ArgumentNullException("Parameter cannot be null or empty.");
            }

            for (int i = 1; i < elements.Length; i++)
            {
                if (elements[i] > elements[0])
                {
                    elements[0] = elements[i];
                }
            }
            return elements[0];
        }

        static void PrintAsNumber(object number, string format)
        {
            switch (format)
            {
                case "f": Console.WriteLine("{0:f2}", number); break;
                case "%": Console.WriteLine("{0:p0}", number); break;
                case "r": Console.WriteLine("{0,8}", number); break;
                default: Console.WriteLine("Invalid input!"); break;
            }
        }

        static double CalcDistance(double x1, double x2, double y1, double y2,
            out bool isHorizontal, out bool isVertical)
        {
            isHorizontal = (x1 == x2);
            isVertical = (y1 == y2);

            double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            return distance;
        }

        static void Main()
        {
            Console.WriteLine(CalculateTriangleArea(3, 4, 5));
           // Console.WriteLine(CalculateTriangleArea(0, 4, 5));
            Console.WriteLine();

            Console.WriteLine(NumberToDigit(5));
            Console.WriteLine(NumberToDigit(55));
            Console.WriteLine();

            Console.WriteLine(FindMax(5, -1, 3, 2, 14, 2, 3));
           // Console.WriteLine(FindMax());
            Console.WriteLine();

            PrintAsNumber(1.3, "f");
            PrintAsNumber(0.75, "%");
            PrintAsNumber(2.30, "r");
            PrintAsNumber(2.30, "A");
            Console.WriteLine();

            bool horizontal, vertical;
            Console.WriteLine(CalcDistance(3, 3, -1, 2.5, out horizontal, out vertical));
            Console.WriteLine("Horizontal? " + horizontal);
            Console.WriteLine("Vertical? " + vertical);
            Console.WriteLine();

            Student peter = new Student() { FirstName = "Peter", LastName = "Ivanov" };
            peter.BirthDate = "17.03.1992";
            peter.City = "Sofia";
            peter.Info = "None";

            Student stella = new Student() { FirstName = "Stella", LastName = "Markova" };
            stella.BirthDate = "03.11.1993";
            stella.City = "Vidin";
            stella.Info = "gamer, high results";

            Console.WriteLine("{0} older than {1} -> {2}",
                peter.FirstName, stella.FirstName, peter.IsOlderThan(stella));
        }
    }
}