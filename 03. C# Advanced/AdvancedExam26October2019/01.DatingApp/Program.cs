using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.DatingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> males = new Stack<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));
            Queue<int> females = new Queue<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));
            int matchesCount = 0;
            while (males.Any() && females.Any())
            {
                if (males.Peek() <= 0)
                {
                    males.Pop();
                    continue;
                }
                if (females.Peek() <= 0)
                {
                    females.Dequeue();
                    continue;
                }
                if (males.Peek() % 25 == 0)
                {
                    males.Pop();
                    if (males.Any())
                    {
                        males.Pop();
                    }
                    continue;
                }
                if (females.Peek() % 25 == 0)
                {
                    females.Dequeue();
                    if (males.Any())
                    {
                        females.Dequeue();
                    }
                    continue;
                }

                int male = males.Pop();
                int female = females.Dequeue();
                if (male == female)
                {
                    matchesCount++;
                }
                else
                {
                    male -= 2;
                    if (male > 0)
                    {
                        males.Push(male);
                    }
                    //else
                    //{
                    //    matchesCount++;
                    //}
                }
            }
            Console.WriteLine($"Matches: {matchesCount}");
            if (males.Any())
            {
                Console.Write($"Males left: {string.Join(", ", males)}");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Males left: none");
            }
            if (females.Any())
            {
                Console.Write($"Females left: {string.Join(", ", females)}");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Females left: none");
            }
        }
    }
}
