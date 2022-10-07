using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasSweets
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceBaklavaForOneKilogram = double.Parse(Console.ReadLine());
            double priceMuffinsForOneKilogram = double.Parse(Console.ReadLine());
            double kilogramsShtolen = double.Parse(Console.ReadLine());
            double kilogramsCandy = double.Parse(Console.ReadLine());
            int kilogramsBiscuits = int.Parse(Console.ReadLine());
            double allPrice = (kilogramsBiscuits * 7.50) + kilogramsCandy * (priceMuffinsForOneKilogram * 1.8) + kilogramsShtolen * (priceBaklavaForOneKilogram * 1.6);
            Console.WriteLine($"{allPrice:F2}");
        }
    }
}
