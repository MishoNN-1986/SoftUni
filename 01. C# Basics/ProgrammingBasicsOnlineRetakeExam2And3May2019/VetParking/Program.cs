using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetParking
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumDays = int.Parse(Console.ReadLine());
            int sumHours = int.Parse(Console.ReadLine());
            double priceForOneHour = 0;
            double totalPrice = 0;
            double allSum = 0;
            for (int i = 1; i <= sumDays; i++)
            {
                for (int j = 1; j <= sumHours; j++)
                {
                    if (i % 2 == 0 && j % 2 == 1)
                    {
                        priceForOneHour = 2.50;
                    }
                    else if (i % 2 == 1 && j % 2 == 0)
                    {
                        priceForOneHour = 1.25;
                    }
                    else
                    {
                        priceForOneHour = 1.0;
                    }
                    totalPrice += priceForOneHour;
                }
                Console.WriteLine($"Day: {i} - {totalPrice:F2} leva");
                allSum += totalPrice;
                totalPrice = 0;
            }
            Console.WriteLine($"Total: {allSum:F2} leva");
        }
    }
}
