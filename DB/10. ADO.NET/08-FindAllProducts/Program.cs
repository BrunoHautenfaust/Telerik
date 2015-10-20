/*
 Write a program that reads a string from the console and finds
 all products that contain this string.
 * Ensure you handle correctly characters like ', %, ", \ and _.
*/

namespace _08_FindAllProducts
{
    using System;
    using System.Data.SqlClient;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input text to search for products:");
            string input = Console.ReadLine();

            SqlConnection dbCon = new SqlConnection("Server=.\\SQLEXPRESS; " +
            "Database=Northwind; Integrated Security=true");
            dbCon.Open();

            using (dbCon)
            {
                SearchProduct(input, dbCon);
            }
        }

        private static void SearchProduct(string input, SqlConnection con)
        {
            string query = @"SELECT ProductName FROM Products
                            WHERE ProductName LIKE '%' + @input + '%'";

                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@input", input);

                var reader = command.ExecuteReader();
                Console.WriteLine("Found results:");

                while (reader.Read())
                {
                    if (input == "%" || input == "_" || input == "'" || input == string.Empty)
                    {
                        break;
                    }

                    Console.WriteLine("- " + reader["ProductName"]);
                }
            }
        }
    }
