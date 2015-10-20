using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01_NorthwindDbContext;

namespace _04
{
    class Program
    {
        static void Main(string[] args)
        {
            // 4. Implement previous by using native SQL query and executing it through the DbContext.

            NorthwindEntities db = new NorthwindEntities();
            NativeSQLOrdersAndShipped(db);

            Console.WriteLine("===================");

            // 5. Write a method that finds all the sales by specified region and period (start / end dates).
            // Doesn't work... I'm "shocked"!
            NorthwindEntities db2 = new NorthwindEntities();
            FindAllOrders(db2, "Canada", new DateTime(1991, 1, 1), new DateTime(2005, 12, 12));
        }
        private static void NativeSQLOrdersAndShipped(NorthwindEntities context)
        {
            using (context)
            {
                string nativeSQLQuery =
                  @"SELECT DISTINCT c.ContactName, o.ShipCountry, o.ShippedDate
                  FROM Customers c
                  JOIN Orders o
                  ON c.CustomerId = o.CustomerId
                  WHERE YEAR(o.OrderDate) = 1997 AND o.ShipCountry = 'Canada'";
                var results = context.Database.SqlQuery<Order>(nativeSQLQuery).ToList();

                foreach (var r in results)
                {
                    Console.WriteLine(r);
                }
            }
        }

        public static void FindAllOrders(NorthwindEntities context, string region, DateTime startDate, DateTime endDate)
        {
            using (context)
            {
                var orders = context.Orders
                    .Where(o => o.ShipRegion == region && o.OrderDate >= startDate && o.OrderDate <= endDate)
                    //.OrderBy(sd => sd.ShippedDate)
                    .ToList();

                foreach (var order in orders)
                {
                    Console.WriteLine("Shipped to {0} in region {1} at {2:d.MM.yy}",
                                        order.ShipName, order.ShipRegion, order.OrderDate);
                }
            }
        }

    }
}
