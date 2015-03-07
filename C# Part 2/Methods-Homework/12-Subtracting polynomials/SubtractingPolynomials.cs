using System;

    class SubtractingPolynomials
    {
        static void Main(string[] args)
        {
            // Extend the previous program to support also subtraction and multiplication of polynomials.

            Console.WriteLine("Input polynom count:");
            int n = int.Parse(Console.ReadLine());
         
            int[] arr1 = new int[n];

            for (int i = 0; i <arr1.Length; i++)
            {
                Console.Write("Add coefficient for polynomial 1/ {0}: ", i + 1);
                arr1[i] = int.Parse(Console.ReadLine());
            }

            int[] arr2 = new int[n];
              for (int i = 0; i <arr2.Length; i++)
            {
                Console.Write("Add coefficients for polynomial 2/ {0}: ", i + 1);
                arr2[i] = int.Parse(Console.ReadLine());
            }
              int[] result = new int[n];
           

            // Choice
              Console.WriteLine("Choose: Add(1), Substract(2), Multiply(3):");
              int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    result = AddPolynomials(arr1, arr2);
                    break;
                case 2:
                    result = SubstractPolynomials(arr1, arr2);
                    break;
                case 3:
                    result = MultiplyPolynomials(arr1, arr2);
                    break;
                default:
                    Console.WriteLine("Invalid input.");
                    break;
            }

             Console.Write("Coefficients are: {");
             for (int i = 0; i < result.Length; i++)
             {
                 Console.Write("{0}, ", result[i]);
             }
             Console.WriteLine("}");

        }
        // Add
        public static int[] AddPolynomials(int[] array1, int[] array2)
        {
            int[] res = new int[array1.Length];

            for (int i = 0; i < array1.Length; i++)
            {
                res[i] = array1[i] + array2[i];
            }
            return res;
        }
        // Substract
        public static int[] SubstractPolynomials(int[] array1, int[] array2)
        {
            int[] res = new int[array1.Length];

            for (int i = 0; i < array1.Length; i++)
            {
                res[i] = Math.Abs(array1[i] - array2[i]);
            }
            return res;
        }
        // Multiply
        public static int[] MultiplyPolynomials(int[] array1, int[] array2)
        {
            int[] res = new int[array1.Length];

            for (int i = 0; i < array1.Length; i++)
            {
                res[i] = array1[i] * array2[i];
            }
            return res;
        }

    }


