using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcGameShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantitySoldGames = int.Parse(Console.ReadLine());
            int quantityHearthstone = 0;
            int quantityFornite = 0;
            int quantityOverwatch = 0;
            int quantityOthers = 0;
            for (int i = 0; i < quantitySoldGames; i++)
            {
                string product = Console.ReadLine();
                if (product == "Hearthstone")
                {
                    quantityHearthstone++;
                }
                else if (product == "Fornite")
                {
                    quantityFornite++;
                }
                else if (product == "Overwatch")
                {
                    quantityOverwatch++;
                }
                else
                {
                    quantityOthers++;
                }
            }
            Console.WriteLine($"Hearthstone - {(quantityHearthstone * 1.0 / quantitySoldGames) * 100.0:F2}%");
            Console.WriteLine($"Fornite - {(quantityFornite * 1.0 / quantitySoldGames) * 100.0:F2}%");
            Console.WriteLine($"Overwatch - {(quantityOverwatch * 1.0 / quantitySoldGames) * 100.0:F2}%");
            Console.WriteLine($"Others - {(quantityOthers * 1.0 / quantitySoldGames) * 100.0:F2}%");
        }
    }
}
