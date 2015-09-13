namespace Prototype
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            ConcretePrototype p1 = new ConcretePrototype(1);
            ConcretePrototype c1 = (ConcretePrototype) p1.Clone();
            Console.WriteLine(p1.ID);
            Console.WriteLine(c1.ID);
        }
    }
}
