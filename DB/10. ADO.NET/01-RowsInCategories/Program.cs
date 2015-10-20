/*
 Write a program that retrieves from the Northwind sample database in MS SQL Server
 the number of rows in the Categories table.
 */

namespace _01_RowsInCategories
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
                SqlCommand cmdCount = new SqlCommand(
                    "SELECT COUNT(*) FROM Categories", dbCon);
                int rowCount = (int)cmdCount.ExecuteScalar();
                Console.WriteLine("The number of rows in the Categories table is " + rowCount);
            }
        }
    }
}
