
namespace task2
{
    using System;

    public class Person
    {
        public Gender Gender { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public Person MakePerson(int value)
        {
            Person newPerson = new Person();
            newPerson.Age = value;
            if (value % 2 == 0)
            {
                newPerson.Name = "The man";
                newPerson.Gender = Gender.Male;
            }
            else
            {
                newPerson.Name = "The chick";
                newPerson.Gender = Gender.Female;
            }
            return newPerson;
        }
    }
}
