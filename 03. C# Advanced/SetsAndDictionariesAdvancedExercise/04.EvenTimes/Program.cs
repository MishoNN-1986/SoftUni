using System;
using System.Collections.Generic;

namespace _04.EvenTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantityNumbers = int.Parse(Console.ReadLine());
            Dictionary<int, int> numbers = new Dictionary<int, int>();
            for (int i = 0; i < quantityNumbers; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (!numbers.ContainsKey(number))
                {
                    numbers.Add(number, 0); // numbers[number] = 0;
                }
                numbers[number]++;
            }
            foreach (var number in numbers)
            {
                if (number.Key % 2 == 0)
                {
                    Console.WriteLine(number.Key);
                }
            }
        }
    }
}
