/*
  Write a program that retrieves from the Northwind database all product categories
  and the names of the products in each category.
  * Can you do this with a single SQL query (with table join)?
*/

namespace _03_ProductsAndCategories
{
    using System;
    using System.Data.SqlClient;

    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection dbCon = new SqlConnection("Server=.\\SQLEXPRESS; " +
            "Database=Northwind; Integrated Security=true");
            dbCon.Open();
            using (dbCon)
            {
                SqlCommand query = new SqlCommand(
                    @"SELECT c.CategoryName, p.ProductName
                     FROM Categories c
                     INNER JOIN Products p
                     ON c.CategoryID = p.CategoryID
                     ORDER BY c.CategoryName ", dbCon);
                
                SqlDataReader reader = query.ExecuteReader();
                using(reader)
                {
                    while (reader.Read())
                    {
                        string catName = (string)reader["CategoryName"];
                        string product = (string)reader["ProductName"];
                        Console.WriteLine("{0}:\t{1}",catName, product);
                    }
                }
            }
        }
    }
}
