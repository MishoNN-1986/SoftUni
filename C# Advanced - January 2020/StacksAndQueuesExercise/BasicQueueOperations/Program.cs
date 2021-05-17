using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicQueueOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> input = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            int[] elements = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> numbers = new Queue<int>();
            int enqueueElements = input.Dequeue();
            int dequeueElements = input.Dequeue();
            int findElement = input.Dequeue();
            int minNum = int.MaxValue;

            for (int i = 0; i < enqueueElements; i++)
            {
                numbers.Enqueue(elements[i]);
            }
            for (int i = 0; i < dequeueElements; i++)
            {
                numbers.Dequeue();
            }
            if (!numbers.Any())
            {
                Console.WriteLine(0);
                return;
            }
            else
            {
                foreach (var number in numbers)
                {
                    if (number < minNum)
                    {
                        minNum = number;
                    }
                    if (findElement == number)
                    {
                        Console.WriteLine("true");
                        return;
                    }
                }
                Console.WriteLine(minNum);
            }
        }
    }
}
