namespace TemplateMethod
{
    using System;

    public class TaratorB : AbstractTarator
    {
        protected override void Cucumber()
        {
            Console.WriteLine("- Shredded cucumber.");
        }
    }
}
