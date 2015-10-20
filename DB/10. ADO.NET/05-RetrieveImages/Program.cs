/*
 Write a program that retrieves the images for all categories in the
 Northwind database and stores them as JPG files in the file system.
*/

namespace _05_RetrieveImages
{
    using System;
    using System.Data.SqlClient;
    using System.IO;

    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection dbCon = new SqlConnection("Server=.\\SQLEXPRESS; " +
                "Database=Northwind; Integrated Security=true");
            dbCon.Open();
            using (dbCon)
            {
                RetrieveImages(dbCon);
                Console.WriteLine("Images stored in project directory.");
            }
        }

        private static void RetrieveImages(SqlConnection con)
        {
            string query = "SELECT CategoryName, Picture FROM Categories";

            SqlCommand allPictures = new SqlCommand(query, con);
            SqlDataReader reader = allPictures.ExecuteReader();
            using (reader)
            {
                while (reader.Read())
                {
                    string categoryName = (string)reader["CategoryName"];
                    categoryName = categoryName.Replace('/', '_');
                    byte[] fileContent = (byte[])reader["Picture"];
                    string fileName = string.Format(@"..\..\{0}.jpg", categoryName);

                    FileStream stream = File.OpenWrite(fileName);
                    using (stream)
                    {
                        stream.Write(fileContent, 78, fileContent.Length - 78);
                    }
                }
            }
        }
    }
}
