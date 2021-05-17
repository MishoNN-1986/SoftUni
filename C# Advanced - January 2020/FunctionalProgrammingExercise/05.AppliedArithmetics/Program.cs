using System;
using System.Linq;

namespace _05.AppliedArithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<int[]> print = (arr) =>
            {
                Console.WriteLine(string.Join(" ", arr));
            };
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            string input = Console.ReadLine();
            while (input != "end")
            {
                if (input == "print")
                {
                    print(numbers);
                }
                else
                {
                    Func<int[], int[]> processor = GetProcessor(input);
                    numbers = processor(numbers);
                }
                input = Console.ReadLine();
            }
        }

        static Func<int[], int[]> GetProcessor(string command)
        {
            Func<int[], int[]> processor = null; // инициализираме го, защото ако не мине през нито 1 case, няма какво да върне
            switch (command)
            {
                case "add":
                    processor = new Func<int[], int[]>((arr) =>
                    {
                        return arr.Select(n => n + 1)
                        .ToArray();
                    });
                    break;
                case "multiply":
                    processor = new Func<int[], int[]>((arr) =>
                    {
                        return arr.Select(n => n * 2)
                        .ToArray();
                    });
                    break;
                case "subtract":
                    processor = new Func<int[], int[]>((arr) =>
                    {
                        return arr.Select(n => n - 1)
                        .ToArray();
                    });
                    break;
            }
            return processor;
        }
    }
}
