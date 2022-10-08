using System;
using System.Collections.Generic;
using System.Linq;

namespace TreasureHunt
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split("|").ToList();
            List<string> outputSteal = new List<string>();
            string[] command = Console.ReadLine().Split();
            while (command[0] != "Yohoho!")
            {
                switch (command[0])
                {
                    case "Loot":
                        Loot(input, command);
                        break;
                    case "Drop":
                        Drop(input, int.Parse(command[1]));
                        break;
                    case "Steal":
                        Steal(input, outputSteal, int.Parse(command[1]));
                        Console.WriteLine(string.Join(", ", outputSteal));
                        break;
                }
                //if (command[0] == "Steal")
                //{
                //    break;
                //}
                outputSteal.Clear();
                command = Console.ReadLine().Split();
            }

            if (input.Count == 0)
            {
                Console.WriteLine("Failed treasure hunt.");
            }
            else
            {
                int sum = 0;
                for (int i = 0; i < input.Count; i++)
                {
                    sum += input[i].Length;
                }
                double averageTreasure = sum * 1.0 / input.Count * 1.0;
                Console.WriteLine($"Average treasure gain: {averageTreasure:F2} pirate credits.");
            }
            //Console.WriteLine(string.Join(", ", input));
        }

        static void Loot(List<string> input, string[] lootTreasure)
        {
            if (lootTreasure.Length == 1)
            {
                return;
            }
            bool checkTreasure = true;
            for (int i = 1; i < lootTreasure.Length; i++)
            {
                checkTreasure = input.Contains(lootTreasure[i]);
                if (checkTreasure == false)
                {
                    input.Insert(0, lootTreasure[i]);
                }
            }
        }

        static void Drop(List<string> input, int position)
        {
            if (position < 0 || position >= input.Count)
            {
                return;
            }
            input.Insert(input.Count, input[position]);
            input.RemoveAt(position);
        }

        static void Steal(List<string> input, List<string> outputSteal, int count)
        {
            if (count < 0)
            {
                return;
            }
            if (count > input.Count)
            {
                count = input.Count;
            }
            for (int i = 0; i < count; i++)
            {
                outputSteal.Insert(0, input[input.Count - 1]);
                input.RemoveAt(input.Count - 1);
            }
        }
    }
}
