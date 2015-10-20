namespace _02_DAOFunctionality
{
    using System;
    using _01_NorthwindDbContext;
    using System.Data.Entity.Validation;
    using System.Threading;
    
    // Create a DAO class with static methods which provide
    // functionality for inserting, modifying and deleting customers.
    
    class Program
    {
        static void Main(string[] args)
        {   
            // I'm using 3 different NorthwindEntities, otherwise I getting a "DBContext is exposed" message   !!!

            var northwind = new NorthwindEntities();
            var northwind2 = new NorthwindEntities();
            var northwind3 = new NorthwindEntities();
            
            Customer customer = new Customer()
            {
               CustomerID = "999",
               Address = "Some address",
               City = "Some city",
               CompanyName = "Some company",
               ContactName = "Some Contact Name",
               ContactTitle = "Some Title",
               Country = "Some country",
               Fax = "Some fax",
               Phone = "Some Phone",
               PostalCode = "999",
               Region = "Some region"
            };

            try
            {
                // Add
                CustomersMethods.InsertCustomer(customer, northwind);
                // Modify
                CustomersMethods.ModifyCustomer(customer, northwind2);
                // Remove
                CustomersMethods.DeleteCustomer(customer, northwind3);

            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        System.Console.WriteLine("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }
        }
    }
}
