using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoolDay
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumPeople = int.Parse(Console.ReadLine());
            double enterTax = double.Parse(Console.ReadLine());
            double sunbed = double.Parse(Console.ReadLine());
            double priceForOneUmbrella = double.Parse(Console.ReadLine());
            double allSum = (double)(sumPeople * enterTax) + Math.Ceiling(sumPeople / 2.0) * priceForOneUmbrella + Math.Ceiling(sumPeople * 0.75) * sunbed;
            Console.WriteLine($"{allSum:F2} lv.");
        }
    }
}
