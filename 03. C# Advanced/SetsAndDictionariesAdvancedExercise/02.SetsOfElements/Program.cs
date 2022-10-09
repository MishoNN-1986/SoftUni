using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.SetsOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lengths = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int firstSetQuantity = int.Parse(lengths[0].ToString());
            int secondSetQuantity = int.Parse(lengths[1].ToString());
            HashSet<int> firstSet = new HashSet<int>();
            HashSet<int> secondSet = new HashSet<int>();
            for (int i = 0; i < firstSetQuantity; i++)
            {
                int number = int.Parse(Console.ReadLine());
                firstSet.Add(number);
            }
            for (int i = 0; i < secondSetQuantity; i++)
            {
                int number = int.Parse(Console.ReadLine());
                secondSet.Add(number);
            }
            if (secondSet.Count > 0 && firstSet.Count > 0)
            {
                foreach (var number in firstSet)
                {
                    if (secondSet.Contains(number))
                    {
                        Console.Write($"{number} ");
                    }
                }
            }
        }
    }
}
