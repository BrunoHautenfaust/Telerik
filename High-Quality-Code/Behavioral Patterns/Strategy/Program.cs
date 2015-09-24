namespace Strategy
{
    using System;

    public class Program
    {
        // Some guy has to get from point A to point B. He can choose from 2 types of public transportation.
        // He can also switch them on the go.
        public static void Main(string[] args)
        {
            Person p = new Person(new Bus());
            p.Transport();

            p = new Person(new Taxi());
            p.Transport();
        }
    }
}
