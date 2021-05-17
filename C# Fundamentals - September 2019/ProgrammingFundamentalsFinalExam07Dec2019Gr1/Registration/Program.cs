using System;
using System.Text.RegularExpressions;

namespace Registration
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string pattern = @"([U][$]){1}([A-Z]{1}[a-z]{2,})\1([P][@][$]){1}([A-Za-z]{5,}\d+)\3";
            Regex regex = new Regex(pattern);
            int successfulRegistrationsCount = 0;
            for (int i = 1; i <= num; i++)
            {
                string input = Console.ReadLine();
                bool containsValidRegistration = regex.IsMatch(input);
                if (containsValidRegistration)
                {
                    Match match = regex.Match(input);
                    string username = match.Groups[2].ToString();
                    string password = match.Groups[4].ToString();
                    Console.WriteLine("Registration was successful");
                    Console.WriteLine($"Username: {username}, Password: {password}");
                    successfulRegistrationsCount++;
                }
                else
                {
                    Console.WriteLine("Invalid username or password");
                }
            }
            Console.WriteLine($"Successful registrations: {successfulRegistrationsCount}");
        }
    }
}
