namespace TemplateMethod
{
    using System;

    public class TaratorA : AbstractTarator
    {
        protected override void Cucumber()
        {
            Console.WriteLine("- Diced cucumber.");
        }
    }
}
