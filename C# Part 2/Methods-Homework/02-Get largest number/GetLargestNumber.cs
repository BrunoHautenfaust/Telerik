using System;

class GetLargestNumber
{
    static void Main(string[] args)
    {
        /*Write a method GetMax() with two parameters that returns the larger of two integers.
Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax().*/

        Console.WriteLine("Input 3 integers(on one line separated by space)");
        string[] text = Console.ReadLine().Split();
        int n1 = Convert.ToInt32(text[0]);
        int n2 = Convert.ToInt32(text[1]);
        int n3 = Convert.ToInt32(text[2]);

        Console.WriteLine( GetMax(GetMax(n1, n2), n3) );

    }

    static int GetMax(int firstNumber, int secondNumber)
    {
        int max = 0;
        if (firstNumber > secondNumber)
        {
            max = firstNumber;
        }
        else
        {
            max = secondNumber;
        }
        return max;
       
    }

}

