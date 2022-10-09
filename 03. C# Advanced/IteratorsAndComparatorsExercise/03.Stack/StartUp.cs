using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Stack
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            string commands = Console.ReadLine();
            while (commands != "END")
            {
                List<string> list = commands
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                string command = list[0];
                switch (command)
                {
                    case "Push":
                        stack.Push(list.Skip(1)
                            .Select(i => i.Split(',').First())
                            .Select(int.Parse)
                            .ToArray());
                        break;
                    case "Pop":
                        try
                        {
                            stack.Pop();
                        }
                        catch (InvalidOperationException ioe)
                        {
                            Console.WriteLine(ioe.Message);
                        }
                        break;
                }
                commands = Console.ReadLine();
            }
            foreach (var item in stack) // може метод, или string.Join
            {
                Console.WriteLine(item);
            }
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
