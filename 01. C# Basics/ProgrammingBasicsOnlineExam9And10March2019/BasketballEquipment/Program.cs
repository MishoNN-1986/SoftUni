using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketballEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            int yearsCharge = int.Parse(Console.ReadLine());
            double needMoney = yearsCharge + (yearsCharge * 0.6) + (yearsCharge * 0.6 * 0.8) + (yearsCharge * 0.6 * 0.8 * 0.25) + (yearsCharge * 0.6 * 0.8 * 0.25 * 0.20);
            Console.WriteLine($"{needMoney:F2}");
        }
    }
}
