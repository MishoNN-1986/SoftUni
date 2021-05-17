using System;
using System.Collections.Generic;
using System.Linq;

namespace Weaponsmith
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split("|").ToList();
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "Done")
            {
                string[] commandParams = command.Split();
                switch (commandParams[0])
                {
                    case "Move":
                        string direction = commandParams[1].ToString();
                        int index = int.Parse(commandParams[2].ToString());
                        Move(input, direction, index);
                        //Console.WriteLine(string.Join(" ", input));
                        break;
                    case "Check":
                        string typePosition = commandParams[1].ToString();
                        Check(input, typePosition);
                        break;
                }

            }
            string weaponName = string.Empty;
            foreach (var item in input)
            {
                weaponName += "" + item;
            }
            Console.WriteLine($"You crafted {weaponName}!");
        }

        private static void Check(List<string> input, string typePosition)
        {
            if (typePosition == "Odd")
            {
                for (int i = 0; i < input.Count; i++)
                {
                    if (i % 2 == 1)
                    {
                        Console.Write($"{input[i]} ");
                    }
                }
                Console.WriteLine();
            }
            else if (typePosition == "Even")
            {
                for (int i = 0; i < input.Count; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write($"{input[i]} ");
                    }
                }
                Console.WriteLine();
            }
        }

        private static void Move(List<string> input, string direction, int index)
        {
            if (direction == "Left")
            {
                if (index < 1 || index >= input.Count)
                {
                    return;
                }
                input.Insert(index - 1, input[index]);
                input.RemoveAt(index + 1);
            }
            else if (direction == "Right")
            {
                if (index < 0 || index >= input.Count - 1)
                {
                    return;
                }
                input.Insert(index, input[index + 1]);
                input.RemoveAt(index + 2);
            }
        }
    }
}
