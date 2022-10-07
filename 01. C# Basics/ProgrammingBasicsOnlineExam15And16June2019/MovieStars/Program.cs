using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStars
{
    class Program
    {
        static void Main(string[] args)
        {
            double buget = double.Parse(Console.ReadLine());
            while (buget >= 0)
            {
                string command = Console.ReadLine();
                if (command == "ACTION")
                {
                    break;
                }
                string name = command;
                if (name.Length > 15)
                {
                    buget *= 0.8;
                    continue;
                }
                double salary = double.Parse(Console.ReadLine());
                buget -= salary;
            }
            if (buget >= 0)
            {
                Console.WriteLine($"We are left with {buget:F2} leva.");
            }
            else
            {
                Console.WriteLine($"We need {Math.Abs(buget):F2} leva for our actors.");
            }
        }
    }
}
