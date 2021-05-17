using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.ListOfPredicates
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<List<int>> print = (list) =>
            {
                Console.WriteLine(string.Join(" ", list));
            };

            int num = int.Parse(Console.ReadLine());
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Func<int, List<int>> listOfPredicates = Predicates(numbers);
            List<int> outputPredicates = listOfPredicates(num);
            print(outputPredicates);
        }

        static Func<int, List<int>> Predicates(int[] numbers)
        {
            Func<int, List<int>> func = null;
            List<int> list = new List<int>();
            bool isDivisible = true;

            func = new Func<int, List<int>>((num) =>
            {
                for (int i = 1; i <= num; i++)
                {
                    for (int j = 0; j < numbers.Length; j++)
                    {
                        if (i % numbers[j] != 0)
                        {
                            isDivisible = false;
                        }
                    }
                    if (isDivisible)
                    {
                        list.Add(i);
                    }
                    isDivisible = true;
                }
                return list;
            });
            return func;
        }
    }
}
