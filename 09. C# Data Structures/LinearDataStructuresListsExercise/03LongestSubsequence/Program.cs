using System;
using System.Collections.Generic;
using System.Linq;

namespace _03LongestSubsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputNumbers = Console.ReadLine()
                .Split(new char[] { }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            Console.WriteLine(string.Join(" ", LongestSubsequence(inputNumbers)));
        }

        private static List<int> LongestSubsequence(List<int> inputNumbers)
        {
            int count = 1;
            int num = inputNumbers[0];
            int maxCount = 1;
            int maxNum = inputNumbers[0];
            for (int i = 1; i < inputNumbers.Count; i++)
            {
                int currentNum = inputNumbers[i];
                if (currentNum == num)
                {
                    count++;
                    num = currentNum;
                    if (count > maxCount)
                    {
                        maxCount = count;
                        maxNum = currentNum;
                    }
                }
                else
                {
                    if (count > maxCount)
                    {
                        maxCount = count;
                        maxNum = inputNumbers[i - 1];
                    }
                    count = 1;
                    num = currentNum;
                }
            }
            var newList = new List<int>();
            for (int i = 0; i < maxCount; i++)
            {
                newList.Add(maxNum);
            }
            return newList;
        }
    }
}
