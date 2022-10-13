using System;
using System.Data.SqlClient;

namespace _03._Get_Minion_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            int id = int.Parse(Console.ReadLine());

            SqlConnection connection = new SqlConnection(
                @"Server = DESKTOP-MFH0NH3\SQLEXPRESS;Database = MinionDB;Integrated Security = true");
            connection.Open();

            using (connection)
            {
                string villainNameQuery = "SELECT Name FROM Villains WHERE Id = @Id";
                SqlCommand command = new SqlCommand(villainNameQuery, connection);

                using (command)
                {
                    command.Parameters.AddWithValue("@Id", id);
                    string villainName = (string)command.ExecuteScalar();

                    if (villainName == null)
                    {
                        Console.WriteLine($"No villain with ID {10} exists in the database.");
                        return;
                    }

                    Console.WriteLine($"Villain: {villainName}");
                }

                string minionsQuery = @"SELECT ROW_NUMBER() OVER (ORDER BY m.Name) as RowNum,
                                         m.Name, 
                                         m.Age
                                    FROM MinionsVillains AS mv
                                    JOIN Minions As m ON mv.MinionId = m.Id
                                   WHERE mv.VillainId = @Id
                                ORDER BY m.Name";

                command = new SqlCommand(minionsQuery, connection);

                using (command)
                {
                    command.Parameters.AddWithValue("@Id", id);
                    SqlDataReader reader = command.ExecuteReader();

                    using (reader)
                    {
                        if (reader == null)
                        {
                            Console.WriteLine($"Villain: Victor Jr.(no minions)");
                        }

                        while (reader.Read())
                        {
                            long rowNumber = (long)reader[0];
                            string name = (string)reader[1];
                            int age = (int)reader[2];

                            Console.WriteLine($"{rowNumber}. {name} {age}");
                        }

                        if (!reader.HasRows)
                        {
                            Console.WriteLine("(no minions)");
                        }
                    }
                }
            }
        }
    }
}
