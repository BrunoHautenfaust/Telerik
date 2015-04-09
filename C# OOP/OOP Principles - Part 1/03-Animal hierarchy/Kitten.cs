using System;

namespace _03_Animal_hierarchy
{
    public class Kitten : Cat
    {
    
        public Kitten(int age, string name)
            : base(age, name, (char)12)
        {

        }
    }
}
