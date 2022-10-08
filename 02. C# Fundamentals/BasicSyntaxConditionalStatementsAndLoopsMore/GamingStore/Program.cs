using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamingStore
{
    class Program
    {
        static void Main(string[] args)
        {
            double currentBalance = double.Parse(Console.ReadLine());
            double price = 0;
            double totalSpent = 0;
            while (true)
            {
                string game = Console.ReadLine();
                switch (game)
                {
                    case "Game Time":
                        Console.WriteLine($"Total spent: ${totalSpent:F2}. Remaining: ${currentBalance - totalSpent:F2}");
                        return;
                    case "OutFall 4":
                        price = 39.99;
                        break;
                    case "CS: OG":
                        price = 15.99;
                        break;
                    case "Zplinter Zell":
                        price = 19.99;
                        break;
                    case "Honored 2":
                        price = 59.99;
                        break;
                    case "RoverWatch":
                        price = 29.99;
                        break;
                    case "RoverWatch Origins Edition":
                        price = 39.99;
                        break;
                    default:
                        Console.WriteLine("Not Found");
                        continue;
                }
                if (price > (currentBalance - totalSpent))
                {
                    Console.WriteLine("Too Expensive");
                    continue;
                }
                Console.WriteLine($"Bought {game}");
                if (price == (currentBalance - totalSpent))
                {
                    Console.WriteLine("Out of money!");
                    break;
                }
                totalSpent += price;
            }
        }
    }
}
