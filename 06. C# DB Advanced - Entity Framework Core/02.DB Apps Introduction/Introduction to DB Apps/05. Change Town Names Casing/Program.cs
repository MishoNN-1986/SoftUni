using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace _05._Change_Town_Names_Casing
{
    class Program
    {
        static void Main(string[] args)
        {
            string countryName = Console.ReadLine();

            SqlConnection connection = new SqlConnection(
            @"Server = DESKTOP-MFH0NH3\SQLEXPRESS;Database = MinionDB;Integrated Security = true");

            using (connection)
            {
                connection.Open();

                string updateTownNames = @"UPDATE Towns SET Name = UPPER(Name) WHERE CountryCode = (SELECT c.Id FROM Countries AS c WHERE c.Name = @countryName)";

                SqlCommand command = new SqlCommand(updateTownNames, connection);

                using (command)
                {
                    command.Parameters.AddWithValue("@countryName", countryName);
                    int rowsAffected = command.ExecuteNonQuery();
                    Console.WriteLine($"{rowsAffected} town names were affected.");
                }
                List<string> towns = new List<string>();

                string townNamesQuery = @"SELECT t.Name FROM Towns as t JOIN Countries AS c ON c.Id = t.CountryCode WHERE c.Name = @countryName";

                command = new SqlCommand(townNamesQuery, connection);

                using (command)
                {
                    command.Parameters.AddWithValue("@countryName", countryName);

                    SqlDataReader reader = command.ExecuteReader();

                    using (reader)
                    {
                        while (reader.Read())
                        {
                            towns.Add((string)reader[0]);
                        }
                    }
                }

                Console.WriteLine("[" + string.Join(", ", towns) + "]");

            }
        }
    }
}
