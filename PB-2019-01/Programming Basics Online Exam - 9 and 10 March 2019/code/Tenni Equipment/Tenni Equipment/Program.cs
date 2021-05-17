using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tenni_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceOfATennisRacket = double.Parse(Console.ReadLine());  //cenata na 1 tenis raketa
            int numberOfTennisRackets = int.Parse(Console.ReadLine());  // broi tenis raketi
            int numberOfSneakers = int.Parse(Console.ReadLine());  // broi chiftove maratonki
            double priceOfSneaker = priceOfATennisRacket * 1.0 / 6;  // cenata na 1 chift maratonki
            double allPrice = (priceOfATennisRacket * 1.0 * numberOfTennisRackets + numberOfSneakers * 1.0 * priceOfSneaker) * 1.2;

            Console.WriteLine($"Price to be paid by Djokovic {Math.Floor(allPrice / 8)}");
            Console.WriteLine($"Price to be paid by sponsors {Math.Ceiling(allPrice * 7 / 8)}");
        }
    }
}
