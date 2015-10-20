// Write a program that retrieves the name and description of all categories in the Northwind DB.

namespace _02_CategoriesNameAndDescription
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
                    "SELECT CategoryName, Description FROM Categories", dbCon);
                
                SqlDataReader reader = query.ExecuteReader();
                using (reader)
                {
                    while(reader.Read())
                    {
                        string categoryName = (string)reader["CategoryName"];
                        string description = (string)reader["Description"];
                        Console.WriteLine("Category Name : {0} \t Description: {1}",
                            categoryName, description);
                    }
                }
            }
        }
    }
}
