using System;
using System.Linq;
using System.Collections.Generic;

namespace _03_Animal_hierarchy
{
    class Animals : ISound
    {   

        public int Age { get; set; }
        public string Name { get; set; }
        public char Sex { get; set; }

        public Animals()
        {

        }

        public Animals(int age, string name, char sex)
        {
            this.Age = age;
            this.Name = name;
            this.Sex = sex;
        }

        public void MakeASound()
        {
            Console.WriteLine("Default animal sound!");
        }
        public static double AverageAge(IEnumerable<Animals> animals)
        {
            return animals.Average(x => x.Age);
        }
        public override string ToString()
        {
            return string.Format("Age: {0}\tName: {1}\tSex: {2}", this.Age, this.Name, this.Sex);
        }
    }
}
