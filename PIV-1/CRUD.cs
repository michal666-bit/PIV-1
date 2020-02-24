using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace PIV_1
{
    class CRUD
    {
        public void Update(int id, string newName, SqlConnection conn)
        {
            string sql = "UPDATE Northwind.dbo.Region SET RegionDescription = @regionName WHERE RegionID=@id";
            var command = new SqlCommand(sql, conn);
            command.Parameters.AddWithValue("@regionName", newName);
            command.Parameters.AddWithValue("@id", id);

            int x = command.ExecuteNonQuery();

            if (x > 0)
            {
                Console.WriteLine("Zmienione");
            }
        }
        public void Create(int id, string regionDescription, SqlConnection conn)
        {
            string sql = "INSERT INTO Northwind.dbo.Region(RegionID,RegionDescription) VALUES (@id,@regionName)";
            var command = new SqlCommand(sql, conn);
            command.Parameters.AddWithValue("@regionName", regionDescription);
            command.Parameters.AddWithValue("@id", id);

        
            int x = command.ExecuteNonQuery();

            if (x > 0)
            {
                Console.WriteLine("Wpisano");
            }
        }
        public void Delete(int id, SqlConnection conn)
        {
            string sql = "DELETE FROM Northwind.dbo.Region WHERE RegionID=@id";
            var comm = new SqlCommand(sql, conn);
            comm.Parameters.AddWithValue("@id", id);

            int x = comm.ExecuteNonQuery();

            if (x > 0)
            {
                Console.WriteLine("Usunieto");
            }
        }

    }
}