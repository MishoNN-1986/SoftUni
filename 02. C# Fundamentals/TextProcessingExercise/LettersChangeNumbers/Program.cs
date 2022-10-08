using System;
using System.Collections.Generic;
using System.Linq;

namespace LettersChangeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            double allSum = GetAllSum(input);
            Console.WriteLine($"{allSum:F2}");
        }

        private static double GetAllSum(string[] input)
        {
            double allSum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                string operation = input[i];
                char firstLetter = operation[0];
                char lastLetter = operation[operation.Length - 1];
                double sum = double.Parse(operation.Substring(1, operation.Length - 2));
                if (char.IsUpper(firstLetter))
                {
                    sum = sum / (firstLetter - 64);
                }
                else
                {
                    sum = sum * (firstLetter - 96);
                }
                if (char.IsUpper(lastLetter))
                {
                    sum = sum - (lastLetter - 64);
                }
                else
                {
                    sum = sum + (lastLetter - 96);
                }
                allSum += sum;
            }
            return allSum;
        }
    }
}
