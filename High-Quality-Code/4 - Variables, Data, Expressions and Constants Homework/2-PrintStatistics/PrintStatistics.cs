namespace _02___PrintStatistics
{
    using System;
    using System.Linq;
    public class Statistics
    {
        public void PrintStatistics(double[] numbers)
        {
            double numbersMaxValue = numbers.Max();
            double numbersMinValue = numbers.Min();
            double numbersAverageValue = numbers.Average();

            this.PrintMin(numbersMinValue);
            this.PrintMax(numbersMaxValue);
            this.PrintAvg(numbersAverageValue);
        }

        private void PrintMin(double numbersMinValue)
        {
            Console.WriteLine("The min value is: {0}", numbersMinValue);
        }
        private void PrintMax(double numbersMaxValue)
        {
            Console.WriteLine("The max value is: {0}", numbersMaxValue);
        }
        private void PrintAvg(double numbersAverageValue)
        {
            Console.WriteLine("The average value is: {0}", numbersAverageValue);
        }
    }
}
