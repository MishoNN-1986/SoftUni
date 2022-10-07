using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OscarsCeremony
{
    class Program
    {
        static void Main(string[] args)
        {
            int rent = int.Parse(Console.ReadLine());
            double sum = rent + (rent * 0.7) + (rent * 0.7 * 0.85) + (rent * 0.7 * 0.85 * 0.5);
            Console.WriteLine($"{sum:F2}");
        }
    }
}
