using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousThreat
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().ToList();
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "3:1")
            {
                string[] commandParams = command.Split();
                string commandName = commandParams[0];
                int firstArg = int.Parse(commandParams[1]);
                int secondArg = int.Parse(commandParams[2]);
                switch (commandName)
                {
                    case "merge":
                        input = Merge(input, firstArg, secondArg);
                        break;
                    case "divide":
                        input = Divide(input, firstArg, secondArg);
                        break;
                }
            }
            Console.WriteLine(string.Join(" ", input));
        }

        static List<string> Merge(List<string> input, int startIndex, int endIndex)
        {
            startIndex = Math.Max(startIndex, 0);
            endIndex = Math.Min(endIndex, input.Count() - 1);

            List<string> newList = new List<string>();

            for (int i = 0; i < input.Count; i++)
            {
                if (i == startIndex)
                {
                    newList.Add(string.Empty);
                }

                if (i >= startIndex && i <= endIndex)
                {
                    newList[startIndex] += input[i];
                }
                else
                {
                    newList.Add(input[i]);
                }
            }

            return newList;
        }

        static List<string> Divide(List<string> input, int index, int partitions)
        {
            List<string> newList = new List<string>();

            for (int i = 0; i < input.Count; i++)
            {
                if (i == index)
                {
                    int length = input[i].Length / partitions;
                    for (int j = 0; j < partitions; j++)
                    {
                        var element = string.Empty;
                        if (input[i].Length % partitions != 0 && j == partitions - 1)
                        {
                            int rest = input[i].Length % partitions;
                            element = input[i].Substring(length * j, length + rest);
                        }
                        else
                        {
                            element = input[i].Substring(length * j, length);
                        }
                        newList.Add(element);
                    }
                }
                else
                {
                    newList.Add(input[i]);
                }
            }
            return newList;
        }
    }
}
