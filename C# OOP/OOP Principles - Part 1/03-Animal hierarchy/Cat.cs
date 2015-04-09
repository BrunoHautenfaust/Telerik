using System;

namespace _03_Animal_hierarchy
{
   public class Cat : Animals
    {
        public Cat()
        {

        }

        public Cat(int age, string name, char sex)
            : base(age, name, sex)
        {

        }

        public override void MakeASound()        
        {
            Console.WriteLine("Meow!");
        }

    }
}
