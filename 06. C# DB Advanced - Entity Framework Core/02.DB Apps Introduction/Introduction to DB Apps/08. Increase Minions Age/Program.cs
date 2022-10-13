using System;
using System.Data.SqlClient;
using System.Linq;

namespace _08._Increase_Minions_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ids = Console.ReadLine().Split().Select(int.Parse).ToArray();

            SqlConnection connection = new SqlConnection(
            @"Server = DESKTOP-MFH0NH3\SQLEXPRESS;Database = MinionDB;Integrated Security = true");

            using (connection)
            {
                connection.Open();

                string updateMinions = $"UPDATE Minions SET Name = UPPER(LEFT(Name, 1)) + SUBSTRING(Name, 2, LEN(Name)), Age += 1 WHERE Id = @Id";

                SqlCommand command = new SqlCommand();

                for (int i = 0; i < ids.Length; i++)
                {
                    int id = ids[i];
                    command = new SqlCommand(updateMinions, connection);

                    using (command)
                    {
                        command.Parameters.AddWithValue("@Id", id);
                        command.ExecuteNonQuery();
                    }
                }

                string minionsQuery = "SELECT Name, Age FROM Minions";

                command = new SqlCommand(minionsQuery, connection);

                using (command)
                {
                    SqlDataReader reader = command.ExecuteReader();

                    using (reader)
                    {
                        while (reader.Read())
                        {
                            string name = (string)reader[0];
                            int age = (int)reader[1];

                            Console.WriteLine($"{name} {age}");
                        }
                    }
                }
            }
        }
    }
}
