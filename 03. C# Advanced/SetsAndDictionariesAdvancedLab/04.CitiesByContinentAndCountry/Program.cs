using System;
using System.Collections.Generic;
using System.Text;

namespace _04.CitiesByContinentAndCountry
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, List<string>>> continents = new Dictionary<string, Dictionary<string, List<string>>>();
            for (int i = 0; i < count; i++)
            {
                string[] input = Console.ReadLine().Split();
                string continent = input[0];
                string country = input[1];
                string city = input[2];
                if (!continents.ContainsKey(continent))
                {
                    continents.Add(continent, new Dictionary<string, List<string>>());
                }
                if (!continents[continent].ContainsKey(country))
                {
                    continents[continent].Add(country, new List<string>());
                }
                continents[continent][country].Add(city);
            }
            StringBuilder output = new StringBuilder();
            foreach (var continent in continents.Keys)
            {
                output.Append($"{continent}:{Environment.NewLine}");
                foreach (var country in continents[continent].Keys)
                {
                    output.Append($"  {country} -> {string.Join(", ", continents[continent][country])}{Environment.NewLine}");
                }
            }
            Console.WriteLine(output);
        }
    }
}
