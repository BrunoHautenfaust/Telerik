// Implement appending new rows to the Excel file.

namespace _07_ExcelAppendRow
{
    using System;
    using System.Data.OleDb;

    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;
                                        Data Source=..\..\file.xlsx;
                                        Extended Properties=""Excel 12.0 Xml; HDR=YES"" ";

            OleDbConnection dbConn = new OleDbConnection(connectionString);

            dbConn.Open();
            using (dbConn)
            {
            
                OleDbCommand comm = new OleDbCommand(
                    @"INSERT INTO [Sheet1$]
                    VALUES (@name, @score)", dbConn);

                string name = "Pesho Peshev";
                double score = 25;

                comm.Parameters.AddWithValue("@name", name);
                comm.Parameters.AddWithValue("@supplier", score);
                comm.ExecuteNonQuery();
                Console.WriteLine("Values inserted.\n");

                PrintTable(dbConn);
            }

        }

        private static void PrintTable(OleDbConnection connnection)
        {
            string query = @"SELECT * FROM [Sheet1$]";

            OleDbCommand PrintTableCommand = new OleDbCommand(query, connnection);

            OleDbDataReader reader = PrintTableCommand.ExecuteReader();
            while (reader.Read())
            {
                string name = (string)reader["Name"];
                double score = (double)reader["Score"];

                Console.WriteLine("Name: {0}\t Score: {1}", name, score);
            }
        }
    }
}
