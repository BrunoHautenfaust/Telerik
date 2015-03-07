using System;

    class IntegerCalculations
    {
        static void Main(string[] args)
        {
    /*Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
    Use variable number of arguments.*/

            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine("Minimum: {0}", Minimum(arr));
            Console.WriteLine("Maximum: {0}", Maximum(arr));
            Console.WriteLine("Average: {0}", Average(arr));
            Console.WriteLine("Sum: {0}", Sum(arr));
            Console.WriteLine("Product: {0}", Product(arr));

        }
        // Minimum
        public static int Minimum(params int[] array)
    {
        int min = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (min > array[i])
            {
                min = array[i];
            }
        }
        return min;
    }
        // Maximum
        public static int Maximum(params int[] array)
        {
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                }
            }
            return max;
        }
        // Average
        public static decimal Average(params int[] array)
        {
            decimal sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            decimal average = sum/array.Length;
            return average;
        }
        // Sum
        public static int Sum(params int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }
        // Product
        public static int Product(params int[] array)
        {
            int product = 1;
            for (int i = 0; i < array.Length; i++)
            {
                product *= array[i];
            }
            return product;
        }
    }

