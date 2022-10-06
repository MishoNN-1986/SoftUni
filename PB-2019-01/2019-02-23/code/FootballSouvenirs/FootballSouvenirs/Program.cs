using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballSouvenirs
{
    class Program
    {
        static void Main(string[] args)
        {
            string team = Console.ReadLine();
            string typeSouvenir = Console.ReadLine();
            int numberSouvenirs = int.Parse(Console.ReadLine());
            double priceForOneSouvenir = 0;
                     
            if (team == "Argentina")
            {
                if (typeSouvenir == "flags")
                {
                    priceForOneSouvenir = 3.25;
                    double PriceForAllSouvenir = numberSouvenirs * priceForOneSouvenir;
                    Console.WriteLine($"Pepi bought {numberSouvenirs} {typeSouvenir} of {team} for {PriceForAllSouvenir:F2} lv.");
                }
                else if (typeSouvenir == "caps")
                {
                    priceForOneSouvenir = 7.20;
                    double PriceForAllSouvenir = numberSouvenirs * priceForOneSouvenir;
                    Console.WriteLine($"Pepi bought {numberSouvenirs} {typeSouvenir} of {team} for {PriceForAllSouvenir:F2} lv.");
                }
                else if (typeSouvenir == "posters")
                {
                    priceForOneSouvenir = 5.10;
                    double PriceForAllSouvenir = numberSouvenirs * priceForOneSouvenir;
                    Console.WriteLine($"Pepi bought {numberSouvenirs} {typeSouvenir} of {team} for {PriceForAllSouvenir:F2} lv.");
                }
                else if (typeSouvenir == "stickers")
                {
                    priceForOneSouvenir = 1.25;
                    double PriceForAllSouvenir = numberSouvenirs * priceForOneSouvenir;
                    Console.WriteLine($"Pepi bought {numberSouvenirs} {typeSouvenir} of {team} for {PriceForAllSouvenir:F2} lv.");
                }
                else
                {
                    Console.WriteLine("Invalid stock!");
                }

            }
            else if (team == "Brazil")
            {
                if (typeSouvenir == "flags")
                {
                    priceForOneSouvenir = 4.20;
                    double PriceForAllSouvenir = numberSouvenirs * priceForOneSouvenir;
                    Console.WriteLine($"Pepi bought {numberSouvenirs} {typeSouvenir} of {team} for {PriceForAllSouvenir:F2} lv.");
                }
                else if (typeSouvenir == "caps")
                {
                    priceForOneSouvenir = 8.50;
                    double PriceForAllSouvenir = numberSouvenirs * priceForOneSouvenir;
                    Console.WriteLine($"Pepi bought {numberSouvenirs} {typeSouvenir} of {team} for {PriceForAllSouvenir:F2} lv.");
                }
                else if (typeSouvenir == "posters")
                {
                    priceForOneSouvenir = 5.35;
                    double PriceForAllSouvenir = numberSouvenirs * priceForOneSouvenir;
                    Console.WriteLine($"Pepi bought {numberSouvenirs} {typeSouvenir} of {team} for {PriceForAllSouvenir:F2} lv.");
                }
                else if (typeSouvenir == "stickers")
                {
                    priceForOneSouvenir = 1.20;
                    double PriceForAllSouvenir = numberSouvenirs * priceForOneSouvenir;
                    Console.WriteLine($"Pepi bought {numberSouvenirs} {typeSouvenir} of {team} for {PriceForAllSouvenir:F2} lv.");
                }
                else
                {
                    Console.WriteLine("Invalid stock!");
                }
            }
            else if (team == "Croatia")
            {
                if (typeSouvenir == "flags")
                {
                    priceForOneSouvenir = 2.75;
                    double PriceForAllSouvenir = numberSouvenirs * priceForOneSouvenir;
                    Console.WriteLine($"Pepi bought {numberSouvenirs} {typeSouvenir} of {team} for {PriceForAllSouvenir:F2} lv.");
                }
                else if (typeSouvenir == "caps")
                {
                    priceForOneSouvenir = 6.90;
                    double PriceForAllSouvenir = numberSouvenirs * priceForOneSouvenir;
                    Console.WriteLine($"Pepi bought {numberSouvenirs} {typeSouvenir} of {team} for {PriceForAllSouvenir:F2} lv.");
                }
                else if (typeSouvenir == "posters")
                {
                    priceForOneSouvenir = 4.95;
                    double PriceForAllSouvenir = numberSouvenirs * priceForOneSouvenir;
                    Console.WriteLine($"Pepi bought {numberSouvenirs} {typeSouvenir} of {team} for {PriceForAllSouvenir:F2} lv.");
                }
                else if (typeSouvenir == "stickers")
                {
                    priceForOneSouvenir = 1.10;
                    double PriceForAllSouvenir = numberSouvenirs * priceForOneSouvenir;
                    Console.WriteLine($"Pepi bought {numberSouvenirs} {typeSouvenir} of {team} for {PriceForAllSouvenir:F2} lv.");
                }
                else
                {
                    Console.WriteLine("Invalid stock!");
                }
            }
            else if (team == "Denmark")
            {
                if (typeSouvenir == "flags")
                {
                    priceForOneSouvenir = 3.10;
                    double PriceForAllSouvenir = numberSouvenirs * priceForOneSouvenir;
                    Console.WriteLine($"Pepi bought {numberSouvenirs} {typeSouvenir} of {team} for {PriceForAllSouvenir:F2} lv.");
                }
                else if (typeSouvenir == "caps")
                {
                    priceForOneSouvenir = 6.50;
                    double PriceForAllSouvenir = numberSouvenirs * priceForOneSouvenir;
                    Console.WriteLine($"Pepi bought {numberSouvenirs} {typeSouvenir} of {team} for {PriceForAllSouvenir:F2} lv.");
                }
                else if (typeSouvenir == "posters")
                {
                    priceForOneSouvenir = 4.80;
                    double PriceForAllSouvenir = numberSouvenirs * priceForOneSouvenir;
                    Console.WriteLine($"Pepi bought {numberSouvenirs} {typeSouvenir} of {team} for {PriceForAllSouvenir:F2} lv.");
                }
                else if (typeSouvenir == "stickers")
                {
                    priceForOneSouvenir = 0.90;
                    double PriceForAllSouvenir = numberSouvenirs * priceForOneSouvenir;
                    Console.WriteLine($"Pepi bought {numberSouvenirs} {typeSouvenir} of {team} for {PriceForAllSouvenir:F2} lv.");
                }
                else
                {
                    Console.WriteLine("Invalid stock!");
                }
            }
            else
            {
                Console.WriteLine("Invalid country!");
            }
            
            
        }
    }
}
