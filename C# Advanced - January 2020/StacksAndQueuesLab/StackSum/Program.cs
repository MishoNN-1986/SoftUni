using System;
using System.Collections.Generic;
using System.Linq;

namespace StackSum
{
    class Program
    {
        static void Main(string[] args)
        {
            string numbers = Console.ReadLine();
            int[] splitNumbers = numbers.Split().Select(int.Parse).ToArray();
            var input = new Stack<int>(splitNumbers);
            string commands = Console.ReadLine().ToLower();
            while (commands != "end")
            {
                string[] command = commands.Split();
                string operation = command[0].ToString();
                if (operation == "add")
                {
                    int firstNumber = int.Parse(command[1].ToString());
                    int secondNumber = int.Parse(command[2].ToString());
                    input.Push(firstNumber);
                    input.Push(secondNumber);
                }
                else if (operation == "remove")
                {
                    int count = int.Parse(command[1].ToString());
                    if (input.Count >= count)
                    {
                        for (int i = 0; i < count; i++)
                        {
                            input.Pop();
                        }
                    }
                }
                commands = Console.ReadLine().ToLower();
            }
            int sum = 0;
            foreach (var item in input)
            {
                sum += item;
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
