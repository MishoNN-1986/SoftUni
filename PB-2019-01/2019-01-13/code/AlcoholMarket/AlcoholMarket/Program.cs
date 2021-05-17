using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlcoholMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double whiskyPrice = double.Parse(Console.ReadLine());
            double beerLiters = double.Parse(Console.ReadLine());
            double wineLiters = double.Parse(Console.ReadLine());
            double rakiqLiters = double.Parse(Console.ReadLine());
            double whiskyLiters = double.Parse(Console.ReadLine());
            double rakiqPrice = whiskyPrice / 2;
            double winePrice = rakiqPrice * 0.6;
            double beerPrice = rakiqPrice * 0.2;
            double allRakiqPrice = rakiqPrice * rakiqLiters;
            double allWinePrice = winePrice * wineLiters;
            double allBeerPrice = beerPrice * beerLiters;
            double allWhiskyPrice = whiskyPrice * whiskyLiters;
            double allPrice = allRakiqPrice + allWinePrice + allBeerPrice + allWhiskyPrice;
            Console.WriteLine($"{allPrice:F2}");


        }
    }
}
