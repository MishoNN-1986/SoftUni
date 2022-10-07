using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renovation
{
    class Program
    {
        static void Main(string[] args)
        {
            int height = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int percentNoColor = int.Parse(Console.ReadLine());
            double neededLiters = Math.Ceiling((height * 1.0 * width * 4.0 * (100.0 - percentNoColor) / 100.0));
            int allLiters = 0;
            string command = "";
            while (true)
            {
                command = Console.ReadLine();
                if (command == "Tired!")
                {
                    Console.WriteLine($"{neededLiters - allLiters} quadratic m left.");
                    break;
                }
                int liters = int.Parse(command);
                allLiters += liters;
                if (allLiters > neededLiters)
                {
                    Console.WriteLine($"All walls are painted and you have {allLiters - neededLiters} l paint left!");
                    break;
                }
                if (allLiters == neededLiters)
                {
                    Console.WriteLine("All walls are painted! Great job, Pesho!");
                    break;
                }
            }
        }
    }
}
