using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Race
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ");
            Dictionary<string, int> names = new Dictionary<string, int>();
            foreach (var item in input)
            {
                names.Add(item, 0);
            }
            string text = Console.ReadLine();
            string name = string.Empty;
            int distance = 0;
            while (text != "end of race")
            {
                for (int i = 0; i < text.Length; i++)
                {
                    char symbol = text[i];
                    if (char.IsLetter(symbol))
                    {
                        name += symbol;
                    }
                    if (char.IsDigit(symbol))
                    {
                        distance += int.Parse(symbol.ToString());
                    }
                }
                if (names.ContainsKey(name))
                {
                    names[name] += distance;
                }
                distance = 0;
                name = string.Empty;
                text = Console.ReadLine();
            }
            names = names.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            names.Take(3);
            List<string> getFirstNames = names.Keys.ToList();
            StringBuilder output = new StringBuilder();
            output.Append($"1st place: {getFirstNames[0]} {Environment.NewLine}");
            output.Append($"2nd place: {getFirstNames[1]} {Environment.NewLine}");
            output.Append($"3rd place: {getFirstNames[2]}");
            Console.WriteLine(output);
        }
    }
}
