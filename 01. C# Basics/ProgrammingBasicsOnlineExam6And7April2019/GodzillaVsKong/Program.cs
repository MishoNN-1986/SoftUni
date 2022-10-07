using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GodzillaVsKong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int people = int.Parse(Console.ReadLine());
            double priceForOneHuman = double.Parse(Console.ReadLine());
            double sum = (budget * 0.1) + (people * priceForOneHuman);
            if (people > 150)
            {
                sum = (budget * 0.1) + (people * priceForOneHuman * 0.9);
            }
            if (sum > budget)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {sum - budget:F2} leva more.");
            }
            else
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {budget - sum:F2} leva left.");
            }
        }
    }
}
