using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripExpenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double priceForAllDay = 0;
            int quantityProducts = 0;
            for (int i = 0; i < days; i++)
            {
                while (true)
                {
                    string command = Console.ReadLine();
                    if (command == "Day over")
                    {
                        Console.WriteLine($"Money left from today: {60.0 - priceForAllDay:F2}. You've bought {quantityProducts} products.");
                        break;
                    }
                    double price = double.Parse(command);
                    if (price > (60 - priceForAllDay))
                    {
                        continue;
                    }
                    priceForAllDay += price;
                    quantityProducts++;
                    if (priceForAllDay == 60)
                    {
                        Console.WriteLine($"Daily limit exceeded! You've bought {quantityProducts} products.");
                        break;
                    }
                }
                priceForAllDay = priceForAllDay - 60;
                quantityProducts = 0;
            }
        }
    }
}
