namespace Singleton
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            // UniqueObject uo = new UniqueObject();    Innacessible! Cannot use 'new'! 
            UniqueObject uo = UniqueObject.Instance();
            uo.ID = 1;
            UniqueObject uo2 = UniqueObject.Instance();
            uo2.ID = 2;
            Console.WriteLine(uo);  // "A UniqueObject instance with id = 2
            Console.WriteLine(uo2); // "A UniqueObject instance with id = 2
        }
    }
}
