using System;

class Program
{
    static void Main(string[] args)
    {
        // Write a program that fills and prints a matrix of size (n, n) as shown below:        // Samo "a" raboti
        // a
        // 1	5	9 	13
        // 2	6	10	14
        // 3	7	11	15
        // 4	8	12	16

        // b
        // 1	8	9	16
        // 2	7	10	15
        // 3	6	11	14
        // 4	5	12	13

        //  c
        // 7	11	14	16
        // 4	8	12	15
        // 2	5	9	13
        // 1	3	6	10

        // d
        // 1	12	11	10
        // 2	13	16	9
        // 3	14	15	8
        // 4	5	6	7

        Console.WriteLine("Input n:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Select type(a, b, c, d):");
        char type = char.Parse(Console.ReadLine());
        //  int n = 4;

        int[,] arr = new int[n, n];
        int digit = 1;

        switch (type)
        {
            case 'a':

                // fill array
                for (int row = 0; row < arr.GetLength(0); row++)
                {
                    for (int col = 0; col < arr.GetLength(1); col++, digit++)
                    {
                        arr[row, col] = digit;
                    }
                }

                // print array
                for (int row = 0; row < arr.GetLength(0); row++)
                {
                    for (int col = 0; col < arr.GetLength(1); col++)
                    {
                        Console.Write("{0,5}", arr[col, row]);
                    }
                    Console.WriteLine();
                };
                break;

            case 'b':

                // fill array
                for (int row = 0; row < arr.GetLength(0); row++)
                {
                    if (row % 2 == 0)
                    {
                        for (int col = 0; col < arr.GetLength(1); col++, digit++)
                        {
                            Console.Write("{0,5}", arr[col, row]);
                        }
                    }
                    else
                    {
                        for (int col = n - 1; col >= 0; col--, digit++)
                        {
                            Console.Write("{0,5}", arr[col, row]);
                        }
                    }
                }

                    // print array
                    for (int row = 0; row < arr.GetLength(0); row++)
                    {
                        for (int col = 0; col < arr.GetLength(1); col++)
                        {
                            Console.Write("{0,5}", arr[col, row]);
                        }
                        Console.WriteLine();
                    };
                    break;


                }




        }
    }


