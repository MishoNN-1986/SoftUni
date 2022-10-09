using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicStackOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> input = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            int[] elements = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> numbers = new Stack<int>();
            int findElement = input.Pop();
            int popElements = input.Pop();
            int pushElements = input.Pop();
            int minNum = int.MaxValue;

            for (int i = 0; i < pushElements; i++)
            {
                numbers.Push(elements[i]);
            }
            for (int i = 0; i < popElements; i++)
            {
                numbers.Pop();
            }
            if (!numbers.Any())
            {
                Console.WriteLine(0);
                return;
            }
            else
            {
                foreach (var number in numbers)
                {
                    if (number < minNum)
                    {
                        minNum = number;
                    }
                    if (findElement == number)
                    {
                        Console.WriteLine("true");
                        return;
                    }
                }
                Console.WriteLine(minNum);
            }
        }
    }
}
