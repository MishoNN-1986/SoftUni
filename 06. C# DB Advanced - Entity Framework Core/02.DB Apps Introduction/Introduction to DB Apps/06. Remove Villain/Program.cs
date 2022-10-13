using System;
using System.Data.SqlClient;

namespace _06._Remove_Villain
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
                string villainName;

                string villainQuery = "SELECT Name FROM Villains WHERE Id = @villainId";

                SqlCommand command = new SqlCommand(villainQuery, connection);

                using (command)
                {
                    command.Parameters.AddWithValue("@villainId", id);
                    villainName = (string)command.ExecuteScalar();

                    if (villainName == null)
                    {
                        Console.WriteLine("No such villain was found");
                        return;
                    }
                }

                int affectedRows = DeleteMinionsVillainsById(connection, id);
                DeleteVillainsById(connection, id);

                Console.WriteLine($"{villainName} was deleted");
                Console.WriteLine($"{affectedRows} minions released");
            }
        }

        private static void DeleteVillainsById(SqlConnection connection, int id)
        {
            string deleteVillainQuery = $"DELETE FROM Villains WHERE Id = @villainId";

            SqlCommand command = new SqlCommand(deleteVillainQuery, connection);

            using (command)
            {
                command.Parameters.AddWithValue("@villainId", id);
                command.ExecuteNonQuery();
            }
        }

        private static int DeleteMinionsVillainsById(SqlConnection connection, int id)
        {
            string deleteVillainQuery = $"DELETE FROM MinionsVillains WHERE VillainId = @villainId";

            SqlCommand command = new SqlCommand(deleteVillainQuery, connection);

            using (command)
            {
                command.Parameters.AddWithValue("@villainId", id);
                return command.ExecuteNonQuery();
            }
        }
    }
}
