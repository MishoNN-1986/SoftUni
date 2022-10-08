using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace SoftUniBarIncome
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double allSum = 0;
            StringBuilder output = new StringBuilder();
            while (input != "end of shift")
            {
                string pattern = @"\%(?<name>[A-Z]{1}[a-z]+)\%[^|$%.]*<(?<product>\w+)>[^|$%.]*\|(?<quantity>\d+)\|[^|$%.]*?[^|$%.[0-9]*]*(?<price>\d+\.?\d*)\$";
                Regex regex = new Regex(pattern);
                bool containsValid = regex.IsMatch(input);
                if (containsValid)
                {
                    Match match = regex.Match(input);
                    string name = match.Groups[1].ToString();
                    string product = match.Groups[2].ToString();
                    int quantity = int.Parse(match.Groups[3].ToString());
                    double price = double.Parse(match.Groups[4].ToString());
                    double sum = quantity * price;
                    allSum += sum;
                    output.Append($"{name}: {product} - {sum:F2} {Environment.NewLine}");
                }
                input = Console.ReadLine();
            }
            if (allSum != 0)
            {
                output.Append($"Total income: {allSum:F2}");
            }
            Console.WriteLine(output);
        }
    }
}
