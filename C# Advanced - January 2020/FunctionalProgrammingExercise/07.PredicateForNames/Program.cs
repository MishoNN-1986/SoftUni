using System;
using System.Linq;

namespace _07.PredicateForNames
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string[]> print = (arr) =>
            {
                Console.WriteLine(string.Join("\n", arr));
            };

            int namesLength = int.Parse(Console.ReadLine());

            string[] names = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            Func<string[], string[]> func = FunctionForNames(namesLength);
            names = func(names);
            print(names);
        }

        static Func<string[], string[]> FunctionForNames(int namesLength)
        {
            Func<string[], string[]> func = null;
            func = new Func<string[], string[]>((arr) =>
           {
               return arr.Where(n => n.Length <= namesLength).ToArray();
           });
            return func;
        }
    }
}
