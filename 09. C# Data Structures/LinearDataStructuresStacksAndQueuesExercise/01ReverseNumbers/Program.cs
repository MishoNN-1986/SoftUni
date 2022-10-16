using System;
using System.Collections.Generic;
using System.Linq;

namespace _01ReverseNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(new char[] { }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            Stack<int> output = new Stack<int>();
            for (int i = 0; i < input.Length; i++)
            {
                int num;
                bool isNum = int.TryParse(input[i], out num);
                if (!isNum)
                {
                    Console.WriteLine(string.Join(" ", input));
                    return;
                }
                output.Push(num);
            }
            Console.WriteLine(string.Join(" ", output));
        }
    }
}
