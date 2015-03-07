using System;

class PrintOddAndEvenProduct
{
    static void Main()
    {

        Console.Write("Enter binary number: ");
        string binary = Console.ReadLine();

        int result = 0;
        for (int bit = 0; bit < binary.Length; bit++)
        {
            result *= 2;
            result += int.Parse(binary[bit].ToString());
        }
        Console.WriteLine(result);
    }
}