using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeYear = Console.ReadLine();
            int holidaysInYear = int.Parse(Console.ReadLine());
            int weekendsOutSofiq = int.Parse(Console.ReadLine());
            double gamesInSofiq = 0;
            double gamesOutSofiq = 0;
            double allGames = 0;

            gamesInSofiq =(48 - weekendsOutSofiq) * 0.75 + (holidaysInYear * 2.0 / 3);
            gamesOutSofiq = weekendsOutSofiq;
            allGames = (double)(gamesInSofiq + gamesOutSofiq);
            if (typeYear == "leap")
            {
                allGames *= 1.15;
            }
            allGames = Math.Floor(allGames);
            Console.WriteLine(allGames);
        }
    }
}
