using System;

class FirstLargerThanNeighbours
{
    static void Main(string[] args)
    {
        /*Write a method that returns the index of the first element in array that is larger than its neighbours, or -1, if there’s no such element.
Use the method from the previous exercise.*/

        Console.WriteLine("Input array length:");
        int arrLength = int.Parse(Console.ReadLine());

        int[] arr = new int[arrLength];

        // fill array
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write("arr[{0}] = ", i);
            arr[i] = int.Parse(Console.ReadLine());
        }

        string final = LargerThanTwoNeighbours(arr);
        Console.WriteLine(final);
    }




    // LargerThanTwoNeighbours METHOD
    static string LargerThanTwoNeighbours(int[] array1)
    {

        string result = string.Empty;

        for (int i = 1; i < array1.Length-1; i++)
        {
            int StaringPosition = i;
            int previous = StaringPosition - 1;
            int next = StaringPosition + 1;

            if (array1[i] > array1[previous] && array1[i] > array1[next])
            {
                int number = array1[i];
                result = number+" is the first number that is larger than its two neighbours.";
                break;
            }
            else if (array1[i] == array1[array1.Length-2])
            {
                result = "No number in the array is larger than its two neighbours.";
            }
        }

        return result;
    }
}
