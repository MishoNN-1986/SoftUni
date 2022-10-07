using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasterShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantityEggs = int.Parse(Console.ReadLine());
            int buyEggs = 0;
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "Close")
                {
                    Console.WriteLine("Store is closed!");
                    Console.WriteLine($"{buyEggs} eggs sold.");
                    break;
                }
                int sumEggs = int.Parse(Console.ReadLine());
                if (command == "Buy")
                {
                    if (quantityEggs < sumEggs)
                    {
                        Console.WriteLine("Not enough eggs in store!");
                        Console.WriteLine($"You can buy only {quantityEggs}.");
                        break;
                    }
                    quantityEggs -= sumEggs;
                    buyEggs += sumEggs;
                }
                else if (command == "Fill")
                {
                    quantityEggs += sumEggs;
                }
            }
        }
    }
}
