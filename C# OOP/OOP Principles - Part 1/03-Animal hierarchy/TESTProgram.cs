using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Animal_hierarchy
{
    class TESTProgram
    {
        static void Main(string[] args)
        {

            // Create arrays of different kinds of animals and calculate the average age of each kind of animal using a static method (you may use LINQ).

            Cat cat = new Cat();
            Dog dog = new Dog();
            Frog frog = new Frog();

            List<Cat> cats = new List<Cat>()
            {
                new Cat(8, "Tommy", (char)11),
                new Cat(4, "Filly", (char)12),
                new Tomcat(2, "Arnold"),
                new Kitten(1, "Kitty")          
            };

            List<Dog> dogs = new List<Dog>()
            {
                new Dog(7, "Jessica", (char)12),
                new Dog(4, "Butch", (char)11),
                new Dog(2, "Mailo", (char)11)
            };

            List<Frog> frogs = new List<Frog>()
            {
                new Frog(2, "Ernesto", (char)11),
                new Frog(3, "Fernanda", (char)12),
                new Frog(1, "Pablo", (char)11),
            };
            Console.WriteLine(string.Join(Environment.NewLine, cats) + "\n");   // This string.Join enum trick works only on lists
            Console.WriteLine(string.Join(Environment.NewLine, dogs) + "\n");
            Console.WriteLine(string.Join(Environment.NewLine, frogs) + "\n");
            Console.WriteLine(new string('=', 50));
            Console.WriteLine("SOUNDS:");
            Console.Write("Cats say: ");
            cat.MakeASound();
            Console.Write("Dogs say: ");
            dog.MakeASound();
            Console.Write("Frogs say: ");
            frog.MakeASound();
            Console.WriteLine("...");
            Console.WriteLine("What does the fox say?");

            Console.WriteLine(new string('=', 50));         
           
            double catsAge = Animals.AverageAge(cats);       // Includes Kittens and Tomcats
            Console.WriteLine("Average Cats age: " + catsAge);

            double dogsAge = Animals.AverageAge(dogs);
            Console.WriteLine("Average Dogs age: {0:F2}", dogsAge);

            double frogsAge = Animals.AverageAge(frogs);
            Console.WriteLine("Average Frogs age: " + frogsAge);

            Console.WriteLine();
         
        }

       
    }
}
