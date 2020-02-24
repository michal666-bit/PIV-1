using System;
using System.Data.SqlClient;

namespace PIV_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString =
               @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            using SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string CommandText = "SELECT * FROM Northwind.dbo.Customers";
            SqlCommand command = new SqlCommand(CommandText, conn);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                //Console.WriteLine(reader["CompanyName"]);
            }
            reader.Close();

            CRUD crud = new CRUD();
            //crud.Create(3,"Bielsko", conn);

            //crud.Update(4, "BBielsko", conn);

            crud.Delete(5, conn);
            conn.Close();
        }
    }
}