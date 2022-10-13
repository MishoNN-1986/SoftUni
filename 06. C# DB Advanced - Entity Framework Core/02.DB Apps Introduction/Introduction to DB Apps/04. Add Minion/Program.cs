using System;
using System.Data.SqlClient;

namespace _04._Add_Minion
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] minionInfo = Console.ReadLine().Split();
            string[] villainInfo = Console.ReadLine().Split();

            string minionName = minionInfo[1];
            int minionAge = int.Parse(minionInfo[2]);
            string minionTown = minionInfo[3];
            string villainName = villainInfo[1];

            SqlConnection connection = new SqlConnection(
            @"Server = DESKTOP-MFH0NH3\SQLEXPRESS;Database = MinionDB;Integrated Security = true");

            using (connection)
            {
                connection.Open();
                int? townId = GetTownByName(minionTown, connection);

                if (townId == null)
                {
                    AddTown(connection, minionTown);
                }

                townId = GetTownByName(minionTown, connection);

                AddMinion(connection, minionName, minionAge, townId);

                int? villainId = GetVillainByName(connection, villainName);

                if (villainId == null)
                {
                    AddVillain(connection, villainName);
                }

                villainId = GetVillainByName(connection, villainName);

                int minionId = GetMinionByName(connection, minionName);

                AddMinionVillain(connection, villainId, minionId, minionName, villainName);
            }
        }

        private static void AddMinionVillain(SqlConnection connection, int? villainId, int minionId, string minionName, string villainName)
        {
            string insertMinionVillain = "INSERT INTO MinionsVillains (MinionId, VillainId) VALUES (@villainId, @minionId)";
            SqlCommand command = new SqlCommand(insertMinionVillain, connection);

            using (command)
            {
                command.Parameters.AddWithValue("@villainId", villainId);
                command.Parameters.AddWithValue("@minionId", minionId);

                command.ExecuteNonQuery();
            }

            Console.WriteLine($"Successfully added {minionName} to be minion of {villainName}.");
        }

        private static int GetMinionByName(SqlConnection connection, string minionName)
        {
            string minionIdQuery = "SELECT Id FROM Minions WHERE Name = @Name";
            SqlCommand command = new SqlCommand(minionIdQuery, connection);

            using (command)
            {
                command.Parameters.AddWithValue("@Name", minionIdQuery);
                return (int)command.ExecuteScalar();
            }
        }

        private static void AddVillain(SqlConnection connection, string villainName)
        {
            string insertVillainSql = "INSERT INTO Villains (Name, EvilnessFactorId)  VALUES (@villainName, 4)";
            SqlCommand command = new SqlCommand(insertVillainSql, connection);

            using (command)
            {
                command.Parameters.AddWithValue("@villainName", villainName);

                command.ExecuteNonQuery();
            }

            Console.WriteLine($"Villain {villainName} was added to the database.");
        }

        private static int? GetVillainByName(SqlConnection connection, string villainName)
        {
            string villainIdQuery = "SELECT Id FROM Villains WHERE Name = @Name";
            SqlCommand command = new SqlCommand(villainIdQuery, connection);

            using (command)
            {
                command.Parameters.AddWithValue("@Name", villainIdQuery);
                return (int?)command.ExecuteScalar();
            }
        }

        private static void AddMinion(SqlConnection connection, string minionName, int minionAge, int? townId)
        {
            string insertMinionSql = "INSERT INTO Minions (Name, Age, TownId) VALUES (@name, @age, @townId)";
            SqlCommand command = new SqlCommand(insertMinionSql, connection);

            using (command)
            {
                command.Parameters.AddWithValue("@name", minionName);
                command.Parameters.AddWithValue("@age", minionAge);
                command.Parameters.AddWithValue("@townId", townId);

                command.ExecuteNonQuery();
            }
        }

        private static int? GetTownByName(string minionTown, SqlConnection connection)
        {
            string townIdQuery = "SELECT Id FROM Towns WHERE Name = @townName";
            SqlCommand command = new SqlCommand(townIdQuery, connection);

            using (command)
            {
                command.Parameters.AddWithValue("@townName", minionTown);
                return (int?)command.ExecuteScalar();
            }
        }

        private static void AddTown(SqlConnection connection, string minionTown)
        {
            string insertTownSql = "INSERT INTO Towns (Name) VALUES (@townName)";
            SqlCommand command = new SqlCommand(insertTownSql, connection);

            using (command)
            {
                command.Parameters.AddWithValue("@townName", minionTown);
                command.ExecuteNonQuery();
            }

            Console.WriteLine($"Town {minionTown} was added to the database.");
        }
    }
}
