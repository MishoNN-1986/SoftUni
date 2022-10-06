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
            int numberOfTournaments = int.Parse(Console.ReadLine());  // broi turniri v koito e uchastval
            int numberOfPointsInTheRankings = int.Parse(Console.ReadLine());  // nachalen broi tochki v ranglistata
            int countPoints = 0;
            int countWinTournament = 0;
            double averagePoints = 0.0;

            for (int i = 0; i < numberOfTournaments; i++)
            {
                string position = Console.ReadLine();
                if (position == "W")
                {
                    countPoints += 2000;
                    countWinTournament++;
                }
                else if (position == "F")
                {
                    countPoints += 1200;
                }
                else
                {
                    countPoints += 720;
                }
            }
            int allPoints = countPoints + numberOfPointsInTheRankings;
            averagePoints = (countPoints / numberOfTournaments);
            double percentageOfWonTournaments = countWinTournament*1.0 / numberOfTournaments * 100.0;
            Console.WriteLine($"Final points: {allPoints}");
            Console.WriteLine($"Average points: {Math.Floor(averagePoints)}");
            Console.WriteLine($"{percentageOfWonTournaments:F2}%");
        }
    }
}
