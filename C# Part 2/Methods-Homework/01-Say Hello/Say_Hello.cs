using System;

    class Say_Hello
    {
        static void Main(string[] args)
        {
            /*Write a method that asks the user for his name and prints “Hello, <name>”
Write a program to test this method.*/

            Console.WriteLine("What is your name:");
            string name = Console.ReadLine();
            NameIs(name);

        }

        static void NameIs(string name)
        {
            Console.WriteLine("Hello, {0}!", name);
        }


    }

