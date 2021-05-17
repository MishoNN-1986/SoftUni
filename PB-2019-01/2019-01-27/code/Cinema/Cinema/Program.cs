using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeProjection = Console.ReadLine();
            int numberOfRows = int.Parse(Console.ReadLine());
            int numberOfColumn = int.Parse(Console.ReadLine());
            double income = 0.00;
            if (typeProjection == "Premiere")
            {
                income = numberOfRows * numberOfColumn * 12.00;
            }
            else if (typeProjection == "Normal")
            {
                income = numberOfRows * numberOfColumn * 7.50;
            }
            else if (typeProjection == "Discount")
            {
                income = numberOfRows * numberOfColumn * 5.00;
            }
            Console.WriteLine($"{income:F2} leva");
        }
    }
}
