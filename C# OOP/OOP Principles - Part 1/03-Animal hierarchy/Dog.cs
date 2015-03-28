﻿using System;

namespace _03_Animal_hierarchy
{
    class Dog : Animals
    {
        public Dog()
        {

        }

        public Dog (int age, string name, char sex)
            : base(age, name, sex)
        {

        }

        public new void MakeASound()
        {
            Console.WriteLine("Woof!");
        }

    }
}
