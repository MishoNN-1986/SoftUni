using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Froggy
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            Lake<int> lake = new Lake<int>(numbers.ToArray());
            Console.Write(string.Join(", ", lake));
            Console.WriteLine();
        }
    }
}
