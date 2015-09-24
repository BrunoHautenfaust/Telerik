namespace TemplateMethod
{
    using System;

    public abstract class AbstractTarator
    {
        public void CookTarator()
        {
            this.AddYoghurt();
            this.AddSalt();
            this.AddDill();
            this.Cucumber();
            this.AddCucumber();
            this.Done();
        }

        protected abstract void Cucumber();

        protected void AddYoghurt()
        {
            Console.WriteLine("Added yoghurt.");
        }

        protected void AddSalt()
        {
            Console.WriteLine("Added salt.");
        }

        protected void AddDill()
        {
            Console.WriteLine("Added dill.");
        }

        protected void AddCucumber()
        {
            Console.WriteLine("Added cucumber.");
        }

        protected void Done()
        {
            Console.WriteLine("Meal is ready!");
        }
    }
}
