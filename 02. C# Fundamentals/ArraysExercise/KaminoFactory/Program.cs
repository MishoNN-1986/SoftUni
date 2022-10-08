using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaminoFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int lengthOfSequences = int.Parse(Console.ReadLine());
            int count = 1;
            int maxCount = 0;
            int sum = 0;
            int maxSum = 0;
            int countIndex = 0; //??
            int maxCountIndex = 0;
            int minIndex = lengthOfSequences;
            int index = lengthOfSequences;
            byte[] maxArr = new byte[lengthOfSequences];
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "Clone them!")
                {
                    Console.WriteLine($"Best DNA sample {maxCountIndex} with sum: {maxSum}.");
                    Console.WriteLine(string.Join(" ", maxArr));
                    break;
                }
                byte[] arr = command.Split('!').Select(byte.Parse).ToArray();
                countIndex++;
                sum = arr[arr.Length - 1];
                for (int i = arr.Length - 1; i > 0; i--)
                {
                    sum += arr[i - 1];
                    if (arr[i - 1] == 0 && arr[i] == 0)
                    {
                        continue;
                    }
                    if (arr[i] == arr[i - 1])
                    {
                        index = i - 1;
                        count++;
                        if (count > maxCount)
                        {
                            maxCount = count;
                            maxArr = arr;
                            maxSum = sum;
                            maxCountIndex = countIndex;
                            if (index < minIndex)
                            {
                                minIndex = index;
                            }
                        }
                        else if (count == maxCount)
                        {
                            if (index < minIndex)
                            {
                                maxCount = count;
                                maxArr = arr;
                                maxSum = sum;
                                maxCountIndex = countIndex;
                                minIndex = index;
                            }
                            else if (index == minIndex)
                            {
                                if (sum > maxSum)
                                {
                                    maxCount = count;
                                    maxArr = arr;
                                    maxSum = sum;
                                    maxCountIndex = countIndex;
                                    minIndex = index;
                                }
                            }
                        }
                    }
                    else
                    {
                        count = 1;
                    }
                }
                sum = 0;
                count = 1;
                index = lengthOfSequences;
            }
        }
    }
}
