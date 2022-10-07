using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            double buget = double.Parse(Console.ReadLine());
            int sumNights = int.Parse(Console.ReadLine());
            double sumForOneNight = double.Parse(Console.ReadLine());
            int percentAdditionalCosts = int.Parse(Console.ReadLine());
            if (sumNights > 7)
            {
                sumForOneNight *= 0.95;
            }
            double allSum = sumNights * sumForOneNight + buget * percentAdditionalCosts / 100.0;
            if (buget >= allSum)
            {
                Console.WriteLine($"Ivanovi will be left with {buget - allSum:F2} leva after vacation.");
            }
            else
            {
                Console.WriteLine($"{allSum - buget:F2} leva needed.");
            }
        }
    }
}
