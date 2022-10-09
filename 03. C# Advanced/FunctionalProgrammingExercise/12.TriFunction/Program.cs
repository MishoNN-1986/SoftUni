using System;
using System.Linq;

namespace _12.TriFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            Func<string, int> sumOfChars = ((name) =>
             {
                 int allSum;
                 return allSum = name.Select(x => (int)x).Sum();
             });
            Func<Func<string, int>, int, string, bool> func = ((sumOfAllChars, num, name) =>
                 {
                     if (sumOfAllChars(name) >= num)
                     {
                         return true;
                     }
                     else
                     {
                         return false;
                     }
                 });
            foreach (var name in names)
            {
                if (func(sumOfChars, sum, name))
                {
                    Console.WriteLine(name);
                    return;
                }
            }
        }
    }
}
