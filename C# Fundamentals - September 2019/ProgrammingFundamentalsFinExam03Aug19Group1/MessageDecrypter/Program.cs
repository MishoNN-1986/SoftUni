using System;
using System.Text.RegularExpressions;

namespace MessageDecrypter
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                string input = Console.ReadLine();
                string pattern = @"^((\$)([A-Z]{1}[a-z][a-z]+)\$\: \[([0-9]*)\]\|\[([0-9]*)\]\|\[([0-9]*)\]\||(\%)([A-Z]{1}[a-z][a-z]+)\%\: (\[([0-9]*)\]\|\[([0-9]*)\]\|\[([0-9]*)\]\|))$";
                Regex regex = new Regex(pattern);
                bool containsValidInput = regex.IsMatch(input);
                if (!containsValidInput)
                {
                    Console.WriteLine("Valid message not found!");
                    continue;
                }
                Match match = regex.Match(input);
                string symbol = match.Groups[2].ToString();
                if (symbol == "$")
                {
                    Console.WriteLine($"{match.Groups[3]}: {(char)(int.Parse(match.Groups[4].ToString()))}{(char)(int.Parse(match.Groups[5].ToString()))}{(char)(int.Parse(match.Groups[6].ToString()))}");
                }
                else
                {
                    Console.WriteLine($"{match.Groups[8]}: {(char)(int.Parse(match.Groups[10].ToString()))}{(char)(int.Parse(match.Groups[11].ToString()))}{(char)(int.Parse(match.Groups[12].ToString()))}");
                }
            }
        }
    }
}
