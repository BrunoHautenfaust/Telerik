/*
 Write a method that adds a new product in the products table in the Northwind database.
 Use a parameterized SQL command.
*/

namespace _04_AddProduct
{
    using System;
    using System.Data.SqlClient;

    public class Program
    {
        public static void Main(string[] args)
        {
            SqlConnection dbCon = new SqlConnection("Server=.\\SQLEXPRESS; " +
            "Database=Northwind; Integrated Security=true");
            dbCon.Open();
            using (dbCon)
            {
                int newProduct = InsertProduct(dbCon, "Some Product", 1, 1, 50, 15.00M, 3, 0, 0, true);
                Console.WriteLine("Inserted new product ID: {0}", newProduct);
            }
        }

        private static int InsertProduct(SqlConnection con,
            string name, int supplier, int category, int quantity,
            decimal price, int inStock, int onOrder, int reorder, bool discont)
        {
            string query = @"INSERT INTO Products
                    (ProductName, SupplierID, CategoryID, QuantityPerUnit, UnitPrice,
                    UnitsInStock, UnitsOnOrder, ReorderLevel, Discontinued)
                    VALUES
                    (@name, @supplier, @category, @quantity, @price,
                    @inStock, @onOrder, @reorder, @discont)";
            
            
            SqlCommand insertProduct = new SqlCommand(query, con);
            insertProduct.Parameters.AddWithValue("@name", name);
            insertProduct.Parameters.AddWithValue("@supplier", supplier);
            insertProduct.Parameters.AddWithValue("@category", category);
            insertProduct.Parameters.AddWithValue("@quantity", quantity);
            insertProduct.Parameters.AddWithValue("@price", price);
            insertProduct.Parameters.AddWithValue("@inStock", inStock);
            insertProduct.Parameters.AddWithValue("@onOrder", onOrder);
            insertProduct.Parameters.AddWithValue("@reorder", reorder);
            insertProduct.Parameters.AddWithValue("@discont", discont);
            insertProduct.ExecuteNonQuery();

            SqlCommand cmdSelectIdentity = new SqlCommand("SELECT @@Identity", con);
            int insertedRecordId = (int)(decimal)cmdSelectIdentity.ExecuteScalar();
            
            return insertedRecordId;
        }
               
    }
}
