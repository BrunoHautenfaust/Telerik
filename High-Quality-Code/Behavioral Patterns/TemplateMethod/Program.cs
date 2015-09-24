namespace TemplateMethod
{
    using System;

    public class Program
    {
        // Tarator is a traditional Bulgarian meal. Different variations are present in other cuisines.
        // The cucumber can be prepared in different ways.
        public static void Main(string[] args)
        {
            TaratorA tA = new TaratorA();
            TaratorB tB = new TaratorB();
            tA.CookTarator();
            Console.WriteLine("=======");
            tB.CookTarator();
        }
    }
}
