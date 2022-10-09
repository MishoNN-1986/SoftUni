using System;
using System.Collections.Generic;
using System.Linq;

namespace CupsAndBottles
{
    class Program
    {
        static void Main(string[] args)
        {
            var cups = new Queue<short>(Console.ReadLine().Split().Select(short.Parse));
            var bottles = new Stack<short>(Console.ReadLine().Split().Select(short.Parse));

            int wastedLittersOfWater = 0;
            short cup = 0;

            while(cups.Any() && bottles.Any())
            {
                cup = cups.Dequeue();

                while (cup > 0 && bottles.Any())
                {
                    var bottle = bottles.Pop();
                    if (bottle > cup)
                    {
                        wastedLittersOfWater += bottle - cup;
                    }
                    cup -= bottle;
                }
            }

            if (bottles.Any())
            {
                Console.WriteLine($"Bottles: {string.Join(" ", bottles)}");
            }
            else
            {
                Console.Write("Cups: ");
                if (cup > 0)
                {
                    Console.Write($"{cup} ");
                }
                Console.WriteLine(string.Join(" ", cups));
            }

            Console.WriteLine($"Wasted litters of water: {wastedLittersOfWater}");

            /*
            for (int i = 0; i < bottles.Count; i++)
            {
                int quantityBottle = bottles.Pop();
                int quantityCup = cups.Peek();
                if (quantityBottle >= quantityCup)
                {
                    wastedLittersOfWater += (quantityBottle - quantityCup);
                    cups.Dequeue();
                }
                else
                {
                    quantityCup -= quantityBottle;
                    for (int j = 0; j < bottles.Count; j++)
                    {
                        quantityBottle = bottles.Pop();
                        quantityCup -= quantityBottle;
                        j--;
                        if (quantityCup <= 0)
                        {
                            wastedLittersOfWater -= quantityCup;
                            cups.Dequeue();
                            break;
                        }
                    }
                }
                if (!cups.Any())
                {
                    Console.WriteLine($"Bottles: {string.Join(" ", bottles)}");
                    break;
                }
                i--;
            }
            if (!bottles.Any())
            {
                Console.WriteLine($"Cups: {string.Join(" ", cups)}");
            }
            Console.WriteLine($"Wasted litters of water: {wastedLittersOfWater}");
            */
        }
    }
}
