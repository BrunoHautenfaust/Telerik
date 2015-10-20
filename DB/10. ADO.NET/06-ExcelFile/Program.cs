// Create an Excel file with 2 columns: name and score
// Write a program that reads your MS Excel file through the OLE DB data provider
// and displays the name and score row by row.

namespace _06_ExcelFile
{
    using System;
    using System.Data.OleDb;

    class Program
    {
        static void Main(string[] args)
        {
            // http://www.connectionstrings.com/excel/

            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;
                                        Data Source=..\..\file.xlsx;
                                        Extended Properties=""Excel 12.0 Xml; HDR=YES"" ";

            OleDbConnection dbConn = new OleDbConnection(connectionString);

            dbConn.Open();
            using (dbConn)
            {
                OleDbCommand comm = new OleDbCommand(
                    @"SELECT * FROM [Sheet1$]", dbConn);

                OleDbDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    string name = (string)reader["Name"];
                    double score = (double)reader["Score"];

                    Console.WriteLine("Name: {0}\t Score: {1}", name, score);
                }
            }
        }
    }
}
