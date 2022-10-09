using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Lootbox
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> firstLootBox = new Queue<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));
            Stack<int> secondLootBox = new Stack<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));
            int sum = 0;
            while (firstLootBox.Any() && secondLootBox.Any())
            {
                int firstElement = firstLootBox.Peek();
                int secondElement = secondLootBox.Peek();
                int sumOfElements = firstElement + secondElement;
                if (sumOfElements % 2 == 0)
                {
                    sum += sumOfElements;
                    firstLootBox.Dequeue();
                    secondLootBox.Pop();
                }
                else
                {
                    firstLootBox.Enqueue(secondLootBox.Pop());
                }
            }
            if (firstLootBox.Any())
            {
                Console.WriteLine("Second lootbox is empty");
            }
            else
            {
                Console.WriteLine("First lootbox is empty");
            }
            if (sum >= 100)
            {
                Console.WriteLine($"Your loot was epic! Value: {sum}");
            }
            else
            {
                Console.WriteLine($"Your loot was poor... Value: {sum}");
            }
        }
    }
}
