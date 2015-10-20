namespace _03_Orders1997ToCanada
{
    using System;
    using System.Linq;
    using _01_NorthwindDbContext;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            // 3. Write a method that finds all customers who have orders made in 1997 and shipped to Canada.
            NorthwindEntities db = new NorthwindEntities();
            OrdersAndShipped(db, "Canada", 1997);
        }

        public static void OrdersAndShipped(NorthwindEntities context, string country, int year)
        {

            using (context)
            {
                var customers = context.Orders
                    .Where(o => o.ShipCountry == country && o.ShippedDate.Value.Year == year)
                    .Select(c => c.Customer.ContactName)
                    .Distinct()
                    .ToList();

                foreach (var c in customers)
                {
                    Console.WriteLine("Customer Contact Name: " + c);
                }
            }
        }
    }
}
