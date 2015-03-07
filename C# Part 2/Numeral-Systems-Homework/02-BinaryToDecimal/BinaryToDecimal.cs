using System;

class BinaryToDecimal
{
    static void Main(string[] args)
    {
        // Write a program to convert binary numbers to their decimal representation.

        Console.WriteLine("Input a binary number:");
        string number = Console.ReadLine();
        char[] CharArr = number.ToCharArray();
        
        int[] arr = new int[CharArr.Length];
      //  Console.WriteLine(arr.Length);

        arr = Array.ConvertAll(CharArr, c => (int)Char.GetNumericValue(c));
        int result = 0;
        int power = arr.Length-1;
      //  Console.WriteLine(power);
        for (int i = 0; i < arr.Length && power >= 0; i++, power--)
        {
            result += arr[i] * (int)Math.Pow(2, power);
           
        }
        Console.WriteLine("Decimal representation: {0}", result);
      
    }
}
