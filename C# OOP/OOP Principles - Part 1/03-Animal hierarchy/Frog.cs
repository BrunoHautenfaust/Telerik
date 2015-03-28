using System;

namespace _03_Animal_hierarchy
{
    class Frog : Animals
    {
        public Frog()
        {

        }
        public Frog(int age, string name, char sex)
            : base(age, name, sex)
        {

        }

        public new void MakeASound()
        {
            Console.WriteLine("Ribbit!");
        }
    }
}
