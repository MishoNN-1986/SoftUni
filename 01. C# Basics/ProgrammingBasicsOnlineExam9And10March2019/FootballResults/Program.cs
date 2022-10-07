using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballResults
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstMach = Console.ReadLine();
            string secondMach = Console.ReadLine();
            string thirdMach = Console.ReadLine();
            int won = 0;
            int lost = 0;
            int drawn = 0;

            int a = firstMach[0];
            int b = firstMach[2];
            if (a > b)
            {
                won++;
            }
            else if (a < b)
            {
                lost++;
            }
            else
            {
                drawn++;
            }
            a = secondMach[0];
            b = secondMach[2];
            if (a > b)
            {
                won++;
            }
            else if (a < b)
            {
                lost++;
            }
            else
            {
                drawn++;
            }
            a = thirdMach[0];
            b = thirdMach[2];
            if (a > b)
            {
                won++;
            }
            else if (a < b)
            {
                lost++;
            }
            else
            {
                drawn++;
            }
            Console.WriteLine($"Team won {won} games.");
            Console.WriteLine($"Team lost {lost} games.");
            Console.WriteLine($"Drawn games: {drawn}");
        }
    }
}
