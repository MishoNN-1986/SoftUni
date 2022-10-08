using System;
using System.Text.RegularExpressions;

namespace Password
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string pattern = @"([\w\W]{1,})\>([\d]{3})\|([a-z]{3})\|([A-Z]{3})\|([^<]{3})\<\1";
            Regex regex = new Regex(pattern);
            for (int i = 1; i <= num; i++)
            {
                string password = Console.ReadLine();
                bool containsValidPassword = regex.IsMatch(password);
                if (containsValidPassword)
                {
                    Match match = regex.Match(password);
                    Console.WriteLine($"Password: {match.Groups[2]}{match.Groups[3]}{match.Groups[4]}{match.Groups[5]}");
                }
                else
                {
                    Console.WriteLine("Try another password!");
                }
            }
        }
    }
}
