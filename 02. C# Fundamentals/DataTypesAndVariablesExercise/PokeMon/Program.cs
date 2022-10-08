using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeMon
{
    class Program
    {
        static void Main(string[] args)
        {
            int pokePower = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());
            int countOfTargets = 0;
            int secondPokerPower = pokePower;
            decimal halfPower = pokePower * 0.5m;
            for (int i = pokePower; i >= distance; i -= distance)
            {
                if (i == halfPower && exhaustionFactor > 0)
                {
                    i = secondPokerPower / exhaustionFactor;
                    secondPokerPower /= exhaustionFactor;
                    if (secondPokerPower < distance)
                    {
                        break;
                    }
                }
                countOfTargets++;
                secondPokerPower -= distance;
            }
            Console.WriteLine(secondPokerPower);
            Console.WriteLine(countOfTargets);
        }
    }
}

