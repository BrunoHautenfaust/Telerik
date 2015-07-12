namespace _4_ExamRefactor
{
    using System;

    class Zad1
    {
        public static void Main()
        {
            /*
             The first C# exam is coming! Help the trainers to calculate the amount of money they save for not printing on paper the exam descriptions. There are N students in the academy. The number of paper sheets that should be printed for each student is S. One realm (box with paper sheets) contains exactly 500 sheets of paper. The price of one realm is P.
               You can buy part of a realm. For example if the price of a realm is 2.20
               you can buy 0.45 parts of one realm which means that you will pay 0.45 * 2.20 = 0.99.
               N, S, P should be read from the console. Output the exact total amount of money
               the trainers save for not printing the exams on paper.
               The output should be rounded with 2 digits after the decimal point.
             */

            const int REAM_QUANTITY = 500;

            Console.WriteLine("Input number of students:");
            int numberOfStudents = int.Parse(Console.ReadLine());
            Console.WriteLine("Input sheets per student:");
            int SheetsPerStudent = int.Parse(Console.ReadLine());
            Console.WriteLine("Input paper ream price:");
            decimal reamPrice = decimal.Parse(Console.ReadLine());

            int TotalNumberOfPapers = numberOfStudents * SheetsPerStudent;
            decimal reamsCount = (decimal)TotalNumberOfPapers / REAM_QUANTITY;
            decimal moneySaved = reamsCount * reamPrice;

            Console.WriteLine("Money saved from not printing the exam descriptions on paper: {0:F2}", moneySaved);

        }
    }
}
