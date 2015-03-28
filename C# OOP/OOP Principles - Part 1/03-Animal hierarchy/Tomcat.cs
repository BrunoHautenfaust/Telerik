using System;


namespace _03_Animal_hierarchy
{
    class Tomcat : Cat
    {

        public Tomcat(int age, string name)
            : base(age, name, (char)11)
        {

        }
    }
}
