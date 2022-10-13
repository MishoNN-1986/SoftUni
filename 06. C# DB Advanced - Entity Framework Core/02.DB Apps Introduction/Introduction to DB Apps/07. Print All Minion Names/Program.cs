using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace _07._Print_All_Minion_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();

            SqlConnection connection = new SqlConnection(
            @"Server = DESKTOP-MFH0NH3\SQLEXPRESS;Database = MinionDB;Integrated Security = true");

            using (connection)
            {
                connection.Open();

                string sqlQuery = "SELECT Name FROM Minions";

                SqlCommand command = new SqlCommand(sqlQuery, connection);

                using (command)
                {
                    SqlDataReader reader = command.ExecuteReader();

                    using (reader)
                    {
                        while (reader.Read())
                        {
                            names.Add((string)reader[0]);
                        }
                    }
                }
            }

            for (int i = 0, j = names.Count - 1; i < names.Count / 2; i++, j--)
            {
                Console.WriteLine(names[i]);
                Console.WriteLine(names[j]);
            }

            if (names.Count % 2 != 0)
            {
                Console.WriteLine(names[names.Count / 2]);
            }
        }
    }
}
