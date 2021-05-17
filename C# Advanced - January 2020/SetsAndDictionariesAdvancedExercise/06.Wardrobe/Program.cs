using System;
using System.Collections.Generic;
using System.Text;

namespace _06.Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> clothes = new Dictionary<string, Dictionary<string, int>>();
            for (int i = 0; i < num; i++)
            {
                string[] input = Console.ReadLine().Split(new string[] { " -> ", "," }, StringSplitOptions.RemoveEmptyEntries);
                string color = input[0];
                for (int j = 1; j < input.Length; j++)
                {
                    string typeClotes = input[j];
                    if (!clothes.ContainsKey(color))
                    {
                        clothes.Add(color, new Dictionary<string, int>());
                    }
                    if (!clothes[color].ContainsKey(typeClotes))
                    {
                        clothes[color].Add(typeClotes, 0);
                    }
                    clothes[color][typeClotes]++;
                }
            }
            string[] findColorAndTypeClothes = Console.ReadLine().Split();
            string findColor = findColorAndTypeClothes[0];
            string findTypeClothes = findColorAndTypeClothes[1];
            StringBuilder output = new StringBuilder();
            foreach (var color in clothes.Keys)  //(color, typeClotes) in clothes
            {
                output.Append($"{color} clothes:{Environment.NewLine}");
                foreach (var typeClotes in clothes[color].Keys)
                {
                    output.Append($"* {typeClotes} - {clothes[color][typeClotes]}");
                    if (color == findColor && typeClotes == findTypeClothes)
                    {
                        output.Append(" (found!)");
                    }
                    output.Append(Environment.NewLine);
                }
            }
            Console.WriteLine(output);
        }
    }
}
