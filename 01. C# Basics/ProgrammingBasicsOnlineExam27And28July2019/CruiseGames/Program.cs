using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CruiseGames
{
    class Program
    {
        static void Main(string[] args)
        {
            string namePlayer = Console.ReadLine();
            int quantityGames = int.Parse(Console.ReadLine());
            double volleyballPoints = 0;
            double tennisPoints = 0;
            double badmintonPoints = 0;
            int countVolleyball = 0;
            int countTennis = 0;
            int countBadminton = 0;
            for (int i = 0; i < quantityGames; i++)
            {
                string gameName = Console.ReadLine();
                int points = int.Parse(Console.ReadLine());
                if (gameName == "volleyball")
                {
                    volleyballPoints += points;
                    countVolleyball++;
                }
                else if (gameName == "tennis")
                {
                    tennisPoints += points;
                    countTennis++;
                }
                else if (gameName == "badminton")
                {
                    badmintonPoints += points;
                    countBadminton++;
                }
            }

            volleyballPoints = (volleyballPoints * 1.07);
            tennisPoints = (tennisPoints * 1.05);
            badmintonPoints = (badmintonPoints * 1.02);
            double allPoints = Math.Floor(volleyballPoints + tennisPoints + badmintonPoints);
            volleyballPoints /= countVolleyball * 1.0;
            tennisPoints /= countTennis * 1.0;
            badmintonPoints /= countBadminton * 1.0;
            if (volleyballPoints >= 75 && tennisPoints >= 75 && badmintonPoints >= 75)
            {
                Console.WriteLine($"Congratulations, {namePlayer}! You won the cruise games with {allPoints} points.");
            }
            else
            {
                Console.WriteLine($"Sorry, {namePlayer}, you lost. Your points are only {allPoints}.");
            }
        }
    }
}
