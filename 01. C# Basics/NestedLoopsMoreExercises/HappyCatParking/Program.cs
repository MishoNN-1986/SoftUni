using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyCatParking
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            double sumForDay = 0.0;
            double total = 0;
            for (int i = 1; i <= days; i++)
            {
                for (int j = 1; j <= hours; j++)
                {
                    if (i % 2 == 0 && j % 2 != 0)
                    {
                        sumForDay += 2.50;
                    }
                    else if (i % 2 != 0 && j % 2 == 0)
                    {
                        sumForDay += 1.25;
                    }
                    else
                    {
                        sumForDay += 1.0;
                    }
                }
                total += sumForDay;
                Console.WriteLine($"Day: {i} - {sumForDay:F2} leva");
                sumForDay = 0;
            }
            Console.WriteLine($"Total: {total:F2} leva");
        }
    }
}
