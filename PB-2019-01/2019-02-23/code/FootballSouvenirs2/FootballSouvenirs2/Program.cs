using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballSouvenirs2
{
    class Program
    {
        static void Main(string[] args)
        {
            string footballTeam = Console.ReadLine();
            string stockType = Console.ReadLine();
            int purchasedStockCount = int.Parse(Console.ReadLine());
            double price = 0;
            bool isTeamNameValid = true;
            bool isStockNameValid = true;
            switch (footballTeam)
            {
                case "Argentina":
                    switch (stockType)
                    {
                        case "flags":
                            price = 3.25;
                            break;
                        case "caps":
                            price = 7.20;
                            break;
                        case "posters":
                            price = 5.10;
                            break;
                        case "stickers":
                            price = 1.25;
                            break;
                        default:
                            Console.WriteLine($"Invalid stock!");
                            isStockNameValid = false;
                            break;
                    }
                    break;
                case "Brazil":
                    switch (stockType)
                    {
                        case "flags":
                            price = 4.20;
                            break;
                        case "caps":
                            price = 8.50;
                            break;
                        case "posters":
                            price = 5.35;
                            break;
                        case "stickers":
                            price = 1.20;
                            break;
                        default:
                            Console.WriteLine($"Invalid stock!");
                            isStockNameValid = false;
                            break;
                    }
                    break;
                case "Croatia":
                    switch (stockType)
                    {
                        case "flags":
                            price = 2.75;
                            break;
                        case "caps":
                            price = 6.90;
                            break;
                        case "posters":
                            price = 4.95;
                            break;
                        case "stickers":
                            price = 1.10;
                            break;
                        default:
                            Console.WriteLine($"Invalid stock!");
                            isStockNameValid = false;
                            break;
                    }
                    break;
                case "Denmark":
                    switch (stockType)
                    {
                        case "flags":
                            price = 3.10;
                            break;
                        case "caps":
                            price = 6.50;
                            break;
                        case "posters":
                            price = 4.80;
                            break;
                        case "stickers":
                            price = 0.90;
                            break;
                        default:
                            Console.WriteLine($"Invalid stock!");
                            isStockNameValid = false;
                            break;
                    }
                    break;
                default:
                    Console.WriteLine($"Invalid country!");
                    isTeamNameValid = false;
                    break;

            }
            if (isTeamNameValid && isStockNameValid)
            {
                double totalAmount = price * purchasedStockCount;

                Console.WriteLine($"Pepi bought {purchasedStockCount} {stockType} of {footballTeam} for {totalAmount:F2} lv.");
            }
        }
    }
}
