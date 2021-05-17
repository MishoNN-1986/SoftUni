using System;
using System.Linq;

namespace _03.CustomMinFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            //Func<int[], int> minFunction = MinNumber;
            //int minNumber = minFunction(Console.ReadLine()
            //    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            //    .Select(int.Parse)
            //    .ToArray());
            //Console.WriteLine(minNumber);
            Func<int[], int> minFunc = (arr) =>
            {
                int minValue = int.MaxValue;
                for (int i = 0; i < arr.Length; i++)
                {
                    int number = arr[i];
                    if (number < minValue)
                    {
                        minValue = number;
                    }
                }
                return minValue;
            };
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            Console.WriteLine(minFunc(numbers));
        }

        //static int MinNumber(int[] numbers)
        //{
        //    int min = int.MaxValue;
        //    for (int i = 0; i < numbers.Length; i++)
        //    {
        //        int number = numbers[i];
        //        if (number < min)
        //        {
        //            min = number;
        //        }
        //    }
        //    return min;
        //}
    }
}
