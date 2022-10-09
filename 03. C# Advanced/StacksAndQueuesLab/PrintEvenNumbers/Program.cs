using System;
using System.Collections.Generic;
using System.Linq;

namespace PrintEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> numbers = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            Queue<int> result = new Queue<int>(numbers.Where(n => n % 2 == 0));
            //for (int i = 0; i < result.Count; i++)
            //{
            //    int number = result.Dequeue();
            //    if (i == result.Count)
            //    {
            //        Console.Write(number);
            //    }
            //    else
            //    {
            //        Console.Write($"{number}, ");
            //    }
            //    i--;
            //}
            //Console.WriteLine();
            Console.WriteLine(string.Join(", ", result));
        }
    }
}
