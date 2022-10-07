using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TennisRanklist
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumToutnaments = int.Parse(Console.ReadLine());
            int startPoints = int.Parse(Console.ReadLine());
            int sumWinPoints = 0;
            int winnTournaments = 0;
            for (int i = 0; i < sumToutnaments; i++)
            {
                string level = Console.ReadLine();
                switch (level)
                {
                    case "W":
                        sumWinPoints += 2000;
                        winnTournaments++;
                        break;
                    case "F":
                        sumWinPoints += 1200;
                        break;
                    case "SF":
                        sumWinPoints += 720;
                        break;
                }
            }
            double averagePoints = Math.Floor(sumWinPoints * 1.0 / sumToutnaments);
            double procentWinTournaments = 0.0;
            if (winnTournaments > 0)
            {
                procentWinTournaments = (winnTournaments * 1.0 / sumToutnaments) * 100.0;
            }
            Console.WriteLine($"Final points: {startPoints + sumWinPoints}");
            Console.WriteLine($"Average points: {averagePoints}");
            Console.WriteLine($"{procentWinTournaments:F2}%");
        }
    }
}
