using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\>\>(?<furniture>[A-Z]([A-Z]+|[a-z]+))\<\<(?<price>(\d+\.\d+)|(\d+))\!(?<quantity>\d+)";  // \d+\.?\d* - за десетично число
            Regex regex = new Regex(pattern);
            string input = Console.ReadLine();
            string furniture = string.Empty;
            double price = 0;
            int quantity = 0;
            double allSum = 0;
            StringBuilder output = new StringBuilder();
            output.Append("Bought furniture:" + Environment.NewLine);
            while (input != "Purchase")
            {
                bool containsValidFurniture = regex.IsMatch(input);
                if (containsValidFurniture)
                {
                    Match match = regex.Match(input);
                    furniture = match.Groups["furniture"].Value;    //може и с [1],[2]....
                    price = double.Parse(match.Groups["price"].Value);
                    quantity = int.Parse(match.Groups["quantity"].Value);
                    output.Append($"{furniture} {Environment.NewLine}");
                    allSum += (price * quantity);
                }
                input = Console.ReadLine();
            }
            output.Append($"Total money spend: {allSum:F2}");
            Console.WriteLine(output);
        }
    }
}
