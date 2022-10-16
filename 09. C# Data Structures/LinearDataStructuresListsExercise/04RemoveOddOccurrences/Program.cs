using System;
using System.Collections.Generic;
using System.Linq;

namespace _04RemoveOddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputNumbers = Console.ReadLine()
                .Split(new char[] { }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            Console.WriteLine(string.Join(" ", RemoveOddOccurrences(inputNumbers)));
        }

        private static List<int> RemoveOddOccurrences(List<int> inputNumbers)
        {
            for (int i = 0; i < inputNumbers.Count; i++)
            {
                int current = inputNumbers[i];

                int count = 0;

                for (int j = 0; j < inputNumbers.Count; j++)
                {
                    if (inputNumbers[j] == current)
                    {
                        count++;
                    }
                }

                if (count % 2 == 1)
                {
                    inputNumbers.RemoveAll(n => n == current);
                    i--;
                }
            }
            return inputNumbers;
        }
    }
}
