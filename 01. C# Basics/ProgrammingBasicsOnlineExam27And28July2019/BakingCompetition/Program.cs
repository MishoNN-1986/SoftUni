using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakingCompetition
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumPlayers = int.Parse(Console.ReadLine());
            int quantityCookies = 0;
            int quantityCakes = 0;
            int quantityWaffles = 0;
            int allQuantity = 0;
            double allPrice = 0;
            for (int i = 0; i < sumPlayers; i++)
            {
                string name = Console.ReadLine();
                while (true)
                {
                    string command = Console.ReadLine();
                    if (command == "Stop baking!")
                    {
                        Console.WriteLine($"{name} baked {quantityCookies} cookies, {quantityCakes} cakes and {quantityWaffles} waffles.");
                        break;
                    }
                    string typeProduct = command;
                    int quantityProduct = int.Parse(Console.ReadLine());
                    if (typeProduct == "cookies")
                    {
                        quantityCookies += quantityProduct;
                    }
                    else if (typeProduct == "cakes")
                    {
                        quantityCakes += quantityProduct;
                    }
                    else if (typeProduct == "waffles")
                    {
                        quantityWaffles += quantityProduct;
                    }
                }
                allPrice += quantityCookies * 1.5 + quantityCakes * 7.8 + quantityWaffles * 2.3;
                allQuantity += quantityCakes + quantityCookies + quantityWaffles;
                quantityCakes = 0;
                quantityCookies = 0;
                quantityWaffles = 0;
            }
            Console.WriteLine($"All bakery sold: {allQuantity}");
            Console.WriteLine($"Total sum for charity: {allPrice:F2} lv.");
        }
    }
}
