using System;
using System.Collections.Generic;
using System.Linq;
namespace Largest3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] sorted = numbers.OrderBy(n => n).ToArray();
            int count = 0;
            for (int i = sorted.Length - 1; i >= 0; i--) // може и с .Take(3); (ако са по-малко не гърми)
            {
                if (count == 3)
                {
                    return;
                }
                Console.Write($"{sorted[i]} ");
                count++;
            }
        }
    }
}
