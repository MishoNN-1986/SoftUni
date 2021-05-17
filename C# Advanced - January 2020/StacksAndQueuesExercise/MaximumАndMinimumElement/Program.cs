using System;
using System.Collections.Generic;
using System.Linq;

namespace MaximumАndMinimumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Stack<int> numbers = new Stack<int>();
            for (int i = 0; i < num; i++)
            {
                int[] command = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int operation = command[0];
                switch (operation)
                {
                    case 1:
                        int element = command[1];
                        numbers.Push(element);
                        break;
                    case 2:
                        if (numbers.Any())
                        {
                            numbers.Pop();
                        }
                        break;
                    case 3:
                        if (numbers.Any())
                        {
                            int maxNum = int.MinValue;
                            foreach (var item in numbers)
                            {
                                if (item > maxNum)
                                {
                                    maxNum = item;
                                }
                            }
                            Console.WriteLine(maxNum);
                        }
                        break;
                    case 4:
                        if (numbers.Any())
                        {
                            int minNum = int.MaxValue;
                            foreach (var item in numbers)
                            {
                                if (item < minNum)
                                {
                                    minNum = item;
                                }
                            }
                            Console.WriteLine(minNum);
                        }
                        break;
                }
            }
            Console.Write(string.Join(", ", numbers));
            Console.WriteLine();
        }
    }
}
