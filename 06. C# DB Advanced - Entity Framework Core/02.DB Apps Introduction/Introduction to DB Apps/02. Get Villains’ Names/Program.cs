using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace _02._Get_Villains__Names
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection connection = new SqlConnection(
                @"Server = DESKTOP-MFH0NH3\SQLEXPRESS;Database = MinionDB;Integrated Security = true");
            connection.Open();

            using (connection)
            {
                //Here's the query we want to execute
                string query = @"SELECT v.Name, COUNT(mv.VillainId) AS MinionsCount  
                            FROM Villains AS v 
                            JOIN MinionsVillains AS mv ON v.Id = mv.VillainId 
                            GROUP BY v.Id, v.Name 
                            HAVING COUNT(mv.VillainId) > 3 
                            ORDER BY COUNT(mv.VillainId)";

                //The output is a table so we need to use SqlReader (row by row)
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string villainName = (string)reader["Name"]; //[0]
                            int numberOfMinions = (int)reader["MinionsCount"]; //[1]
                            Console.WriteLine($"{villainName} {numberOfMinions}");
                        }
                    }
                }
            }
        }
    }
}
