using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasterGuests
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumGuests = int.Parse(Console.ReadLine());
            int buget = int.Parse(Console.ReadLine());
            double easterBread = Math.Ceiling(sumGuests / 3.0);
            double allSum = easterBread * 4.0 + sumGuests * 0.45 * 2.0;
            if (buget >= allSum)
            {
                Console.WriteLine($"Lyubo bought {easterBread} Easter bread and {sumGuests * 2} eggs.");
                Console.WriteLine($"He has {buget - allSum:F2} lv. left.");
            }
            else
            {
                Console.WriteLine("Lyubo doesn't have enough money.");
                Console.WriteLine($"He needs {allSum - buget:F2} lv. more.");
            }
        }
    }
}
