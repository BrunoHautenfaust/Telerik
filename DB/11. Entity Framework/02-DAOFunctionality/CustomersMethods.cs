namespace _02_DAOFunctionality
{
    using System;
    using System.Linq;
    using _01_NorthwindDbContext;
    using System.Data.SqlClient;
    using System.Configuration;

    class CustomersMethods
    {
        // Create a DAO class with static methods which provide
        // functionality for inserting, modifying and deleting customers.

        public static void InsertCustomer(Customer customer, NorthwindEntities context)
        {
            using (context)
            {
                context.Customers.Add(customer);
                context.SaveChanges();
            }
            Console.WriteLine("Customer added.");
        }

        public static void DeleteCustomer(Customer customer, NorthwindEntities context)
        {
            using (context)
            {
                customer = context.Customers.First();
                context.Customers.Remove(customer);
                context.SaveChanges();
            }
            Console.WriteLine("Customer deleted.");
        }

        public static void ModifyCustomer(Customer customer, NorthwindEntities context)
        {
            using (context)
            {
                customer = context.Customers.First();
                customer.Address = "Some New Address";
                context.SaveChanges();
            }
            Console.WriteLine("Customer info modified.");
        }
    }
}
