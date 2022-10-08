using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Race2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ");
            string text = Console.ReadLine();
            Dictionary<string, int> names = new Dictionary<string, int>();
            foreach (var item in input)
            {
                names.Add(item, 0);
            }
            string patternDistance = @"(?<distance>\d{1})";
            string patternLetter = @"(?<letter>[A-Z]{1}|[a-z]{1})";
            Regex regex = new Regex(patternLetter);
            Regex distanceRegex = new Regex(patternDistance);
            while (text != "end of race")
            {
                string name = string.Empty;
                int distance = 0;
                MatchCollection charCollection = regex.Matches(text);
                MatchCollection distanceCollection = distanceRegex.Matches(text);
                foreach (Match match in charCollection)  // може и string name=string.Join("", charCollection);
                {
                    name += match.Value;
                }
                if (names.ContainsKey(name))
                {
                    foreach (Match match in distanceCollection)
                    {
                        distance += int.Parse(match.Value);
                    }
                    names[name] += distance;
                }
                text = Console.ReadLine();
            }
            names = names.OrderByDescending(d => d.Value).ToDictionary(d => d.Key, d => d.Value);
            StringBuilder output = new StringBuilder();
            output.Append($"1st place: {names.Keys.ToList()[0]} {Environment.NewLine}");
            output.Append($"2nd place: {names.Keys.ToList()[1]} {Environment.NewLine}");
            output.Append($"3rd place: {names.Keys.ToList()[2]}");
            Console.WriteLine(output);
        }
    }
}
