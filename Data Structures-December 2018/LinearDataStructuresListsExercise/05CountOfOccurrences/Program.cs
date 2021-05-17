using System;
using System.Collections.Generic;
using System.Linq;

namespace _05CountOfOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputNumbers = Console.ReadLine()
                .Split(new char[] { }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            var sortedDictionary = new SortedDictionary<int, int>();
            CountOfOccurrences(inputNumbers, sortedDictionary);

            PrintSortedDictionary(sortedDictionary);
        }

        private static void PrintSortedDictionary(SortedDictionary<int, int> sortedDictionary)
        {
            foreach (var item in sortedDictionary)
            {
                Console.WriteLine($"{item.Key} -> {item.Value} times");
            }
        }

        private static SortedDictionary<int, int> CountOfOccurrences(List<int> inputNumbers, SortedDictionary<int, int> sortedDictionary)
        {
            for (int i = 0; i < inputNumbers.Count; i++)
            {
                int currentNumber = inputNumbers[i];
                if (!sortedDictionary.ContainsKey(currentNumber))
                {
                    sortedDictionary.Add(currentNumber, 0);
                }
                sortedDictionary[currentNumber]++;
            }
            return sortedDictionary;
        }
    }
}
