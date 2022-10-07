using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumChickenMenu = int.Parse(Console.ReadLine());
            int sumFishMenu = int.Parse(Console.ReadLine());
            int sumVeganMenu = int.Parse(Console.ReadLine());
            double allSum = (sumChickenMenu * 10.35 + sumFishMenu * 12.4 + sumVeganMenu * 8.15) * 1.2 + 2.5;
            Console.WriteLine($"Total: {allSum:F2}");
        }
    }
}
