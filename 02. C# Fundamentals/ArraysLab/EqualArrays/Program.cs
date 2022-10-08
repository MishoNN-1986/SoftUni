using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstNumbers = Console.ReadLine();
            string[] firstNumbersToArray = firstNumbers.Split();
            int[] firstIntNumberToArray = new int[firstNumbersToArray.LongLength];
            string secondNumbers = Console.ReadLine();
            string[] secondNumbersToArray = secondNumbers.Split();
            int[] secondIntNumberToArray = new int[secondNumbersToArray.LongLength];
            int sum = 0;
            for (int i = 0; i < firstIntNumberToArray.Length; i++)
            {
                firstIntNumberToArray[i] = int.Parse(firstNumbersToArray[i]);
                for (int j = 0; j < secondIntNumberToArray.Length; j++)
                {
                    secondIntNumberToArray[j] = int.Parse(secondNumbersToArray[j]);
                    if (i == j)
                    {
                        if (firstIntNumberToArray[i] != secondIntNumberToArray[j])
                        {
                            Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                            return;
                        }
                    }
                }
                sum += firstIntNumberToArray[i];
            }
            Console.WriteLine($"Arrays are identical. Sum: {sum}");
        }
    }
}
