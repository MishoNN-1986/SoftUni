using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Darts
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int start = 301;
            int badShoot = 0;
            int goodShoot = 0;
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "Retire")
                {
                    Console.WriteLine($"{name} retired after {badShoot} unsuccessful shots.");
                    break;
                }
                string zone = command;
                int points = int.Parse(Console.ReadLine());
                switch (zone)
                {
                    case "Double":
                        points *= 2;
                        break;
                    case "Triple":
                        points *= 3;
                        break;
                }
                if (points > start)
                {
                    badShoot++;
                    continue;
                }
                else if (points < start)
                {
                    goodShoot++;
                    start -= points;
                    continue;
                }
                else
                {
                    goodShoot++;
                    Console.WriteLine($"{name} won the leg with {goodShoot} shots.");
                    break;
                }
            }
        }
    }
}
