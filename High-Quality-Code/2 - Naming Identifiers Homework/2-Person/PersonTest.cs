
namespace task2
{
    using System;

    class PersonTest
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person = person.MakePerson(25);
            Console.WriteLine("Name: {0} \nAge: {1}", person.Name, person.Age);
        }
    }
}
