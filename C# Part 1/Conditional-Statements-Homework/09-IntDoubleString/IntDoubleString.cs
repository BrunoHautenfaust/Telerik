using System;

namespace _09_IntDoubleString
{
    class IntDoubleString
    {
        static void Main()
        {
        /*Write a program that, depending on the user’s choice, inputs an int, double or string variable.
        If the variable is int or double, the program increases it by one.
        If the variable is a string, the program appends * at the end.
        Print the result at the console. Use switch statement.*/

            Console.WriteLine("Please choose a type:\nInt->1\t\tDouble->2\tString->3");
            int input = int.Parse(Console.ReadLine());
           switch (input)
           {
               case 1:
                   { 
                   Console.WriteLine("Please enter an integer:");
                   int i = int.Parse(Console.ReadLine());
                   Console.WriteLine(i + 1);
                   break;
                   }
               case 2:
                   {
                       Console.WriteLine("Please enter a double:");
                       double d = double.Parse(Console.ReadLine());
                       Console.WriteLine(d + 1);
                       break;
                   }
               case 3:
                   {
                       Console.WriteLine("Please enter a string:");
                       string s = Console.ReadLine();
                       Console.WriteLine(s + '*');
                       break;
                   }
               default:
                   Console.WriteLine("Error!");
                   break;
           }

        }
    }
}
