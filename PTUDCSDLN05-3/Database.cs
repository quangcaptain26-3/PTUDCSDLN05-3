using System;
using System.Data;
using System.Data.SqlClient;

namespace PTUDCSDLN05_3
{
    internal class Database
    {
        private static string connectionString =
            @"Data Source=PHAMMINHQUANG;Initial Catalog=PTUDCSDLN05_3;Integrated Security=True;TrustServerCertificate=True";

        private static SqlConnection connection;

        public static DataTable Query(string sql)
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            connection.Close();
            return dataTable;
        }

        public static void Execute(string sql)
        {
            Console.WriteLine(sql);
            connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand(sql, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
