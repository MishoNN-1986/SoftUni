using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.CountSameValuesInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] input = Console.ReadLine().Split().Select(double.Parse).ToArray();
            Dictionary<double, int> numbers = new Dictionary<double, int>();
            for (int i = 0; i < input.Length; i++)
            {
                double number = input[i];
                if (!numbers.ContainsKey(number))
                {
                    numbers.Add(number, 0);
                }
                numbers[number]++;
            }
            foreach (var (key, value) in numbers)
            {
                Console.WriteLine($"{key} - {value} times");
            }
        }
    }
}
