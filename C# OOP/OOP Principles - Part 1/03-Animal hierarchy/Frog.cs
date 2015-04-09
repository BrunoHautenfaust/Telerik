using System;

namespace _03_Animal_hierarchy
{
    public class Frog : Animals
    {
        public Frog()
        {

        }
        public Frog(int age, string name, char sex)
            : base(age, name, sex)
        {

        }

        public override void MakeASound()
        {
            Console.WriteLine("Ribbit!");
        }
    }
}
