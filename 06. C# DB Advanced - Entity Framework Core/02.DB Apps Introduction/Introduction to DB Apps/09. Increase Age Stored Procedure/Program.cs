using System;
using System.Data.SqlClient;

namespace _09._Increase_Age_Stored_Procedure
{
    class Program
    {
        static void Main(string[] args)
        {
            int id = int.Parse(Console.ReadLine());

            SqlConnection connection = new SqlConnection(
            @"Server = DESKTOP-MFH0NH3\SQLEXPRESS;Database = MinionDB;Integrated Security = true");

            using (connection)
            {
                connection.Open();

                string uspGetOlderProc = "EXEC usp_GetOlder @id";

                SqlCommand command = new SqlCommand(uspGetOlderProc, connection);

                using (command)
                {
                    command.Parameters.AddWithValue("@id", id);
                    SqlDataReader reader = command.ExecuteReader();

                    using (reader)
                    {
                        reader.Read();

                        string name = (string)reader[0];
                        int age = (int)reader[1];

                        Console.WriteLine($"{name} - {age} years old");
                    }
                }
            }
        }
    }
}
