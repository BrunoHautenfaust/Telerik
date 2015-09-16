namespace Builder
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            // Creates a cashier
            Cashier cashier = new Cashier();

            // Creates a cook
            ICook cook1 = null;
            ICook cook2 = null;

            // Assigns the cook to be a Peperoni Cook
            cook1 = new PeperoniCook();
            cook2 = new HawaiiCook();

            // The cashier tells the cook to make a peperoni pizza
            cashier.Make(cook1);
            cashier.Make(cook2);

            Console.WriteLine(cook1.Pizza);
            Console.WriteLine(cook2.Pizza);

        }
    }
}
