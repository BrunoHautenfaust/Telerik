using System;

    class AddingPolynomials
    {
        static void Main(string[] args)
        {
            /*Write a method that adds two polynomials.
Represent them as arrays of their coefficients.
Example:
      x^2 + 5 = 1x^2 + 0x + 5 => {5, 0, 1}*/

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
                Console.Write("Add coefficient for polynomial 2/ {0}: ", i + 1);
                arr2[i] = int.Parse(Console.ReadLine());
            }

             int[] result = AddPolynomials(arr1, arr2);

             Console.Write("Coefficients are: {");
             for (int i = 0; i < result.Length; i++)
             {
                 Console.Write("{0}, ", result[i]);
             }
             Console.WriteLine("}");

        }

        public static int[] AddPolynomials(int[] array1, int[] array2)
        {
            int[] res = new int[array1.Length];

            for (int i = 0; i < array1.Length; i++)
            {
                res[i] = array1[i] + array2[i];
            }
            return res;
        }
    }

