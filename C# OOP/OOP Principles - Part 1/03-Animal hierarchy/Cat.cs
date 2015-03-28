using System;

namespace _03_Animal_hierarchy
{
    class Cat : Animals
    {
        public Cat()
        {

        }

        public Cat(int age, string name, char sex)
            : base(age, name, sex)
        {

        }

        public new void MakeASound()        
        {
            Console.WriteLine("Meow!");
        }

    }
}
