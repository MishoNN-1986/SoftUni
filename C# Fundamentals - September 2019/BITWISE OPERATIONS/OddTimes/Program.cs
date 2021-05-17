using System;
using System.Linq;

namespace OddTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int count = 1;
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        count++;
                    }
                }
                if (count % 2 == 1)
                {
                    Console.WriteLine(numbers[i]);
                    return;
                }
                count = 1;
            }
        }
    }
}
