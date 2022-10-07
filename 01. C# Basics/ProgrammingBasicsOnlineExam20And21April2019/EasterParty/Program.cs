using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasterParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumGuests = int.Parse(Console.ReadLine());
            double priceForOneGuest = double.Parse(Console.ReadLine());
            double buget = double.Parse(Console.ReadLine());
            if (sumGuests >= 10 && sumGuests <= 15)
            {
                priceForOneGuest *= 0.85;
            }
            else if (sumGuests > 15 && sumGuests <= 20)
            {
                priceForOneGuest *= 0.8;
            }
            else if (sumGuests > 20)
            {
                priceForOneGuest *= 0.75;
            }
            double allSum = sumGuests * priceForOneGuest + buget * 0.1;
            if (buget >= allSum)
            {
                Console.WriteLine($"It is party time! {buget - allSum:F2} leva left.");
            }
            else
            {
                Console.WriteLine($"No party! {allSum - buget:F2} leva needed.");
            }
        }
    }
}
