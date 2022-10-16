using System;
using System.Linq;

namespace _01SumAndAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputNumbers = Console.ReadLine()
                 .Split(new char[] { }, StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToList();
            int sum = inputNumbers.Sum();
            double average = inputNumbers.Average();
            Console.WriteLine($"Sum={sum}; Average={average:F2}");
        }
    }
}
