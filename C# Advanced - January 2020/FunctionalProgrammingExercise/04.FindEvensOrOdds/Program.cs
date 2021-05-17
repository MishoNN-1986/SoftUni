using System;
using System.Linq;

namespace _04.FindEvensOrOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            var bounds = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int lowerBound = bounds[0];
            int upperBound = bounds[1];
            string command = Console.ReadLine();

            Predicate<int> predicate = command == "odd" ?
               new Predicate<int>((n) => n % 2 != 0)
               : new Predicate<int>((n) => n % 2 == 0); // може и с метод, койото връща Predicate<int>

            for (int i = lowerBound; i <= upperBound; i++)
            {
                if (predicate(i))
                {
                    Console.Write($"{i} "); // може и със stringBuilder
                }
            }
            Console.WriteLine();
        }
    }
}
