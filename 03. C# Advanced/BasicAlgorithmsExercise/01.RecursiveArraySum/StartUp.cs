using System;
using System.Linq;

namespace _01.RecursiveArraySum
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries).
                Select(int.Parse)
                .ToArray();
            Console.WriteLine(Sum(input));
        }

        static int Sum(int[] arr, int index = 0)
        {
            if (index == arr.Length - 1) // базов случай(дъното на рекурсията)
            {
                return arr[index];
            }
            return arr[index] + Sum(arr, index + 1);
        }
    }
}
