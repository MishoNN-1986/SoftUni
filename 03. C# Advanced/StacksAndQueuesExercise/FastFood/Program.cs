using System;
using System.Collections.Generic;
using System.Linq;

namespace FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantity = int.Parse(Console.ReadLine());
            Queue<int> orders = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            int biggestOrder = orders.Max();
            while (true)
            {
                if (!orders.Any())
                {
                    Console.WriteLine(biggestOrder);
                    Console.WriteLine("Orders complete");
                    return;
                }
                if (quantity - orders.Peek() < 0)
                {
                    Console.WriteLine(biggestOrder);
                    Console.WriteLine($"Orders left: {string.Join(" ", orders)}");
                    return;
                }
                int order = orders.Dequeue();
                quantity -= order;
            }
        }
    }
}
