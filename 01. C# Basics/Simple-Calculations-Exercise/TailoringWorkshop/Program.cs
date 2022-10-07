using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TailoringWorkshop
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfTables = int.Parse(Console.ReadLine());
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double allMoneyInUsd = (((length + 0.60) * (width + 0.60) * 7) + ((length / 2) * (length / 2) * 9)) * numberOfTables;
            double allMoneyInBgn = allMoneyInUsd * 1.85;
            Console.WriteLine($"{allMoneyInUsd:F2} USD");
            Console.WriteLine($"{allMoneyInBgn:F2} BGN");
        }
    }
}
