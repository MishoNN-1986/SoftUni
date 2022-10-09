using System;
using System.Linq;

namespace _08.CustomComparator
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, int> comparator = new Func<int, int, int>((a, b) =>
              {
                  if (a % 2 == 0 && b % 2 != 0)
                  {
                      return -1; // ако първото число е четно, а второто нечетно връщаме първото (-1)
                  }
                  else if (a % 2 != 0 && b % 2 == 0)
                  {
                      return 1; // ако второто число е четно, а първото нечетно, второто минава първо (1)
                  }
                  else
                  {
                      return a.CompareTo(b); // сравнява първото с второто, иначе е return 0
                  }
              });

            Comparison<int> comparison = new Comparison<int>(comparator); // в скобите чака делегат(функция, компаратор), който приема 2 стойности и връща int винаги
            // Comparison е като обвивка за компаратор
            var numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Array.Sort(numbers, comparison);

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
