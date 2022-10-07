using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketballTournament
{
    class Program
    {
        static void Main(string[] args)
        {
            int countGames = 0;
            int countWinGame = 0;
            int countLostGame = 0;
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "End of tournaments")
                {
                    double percentWinGame = (countWinGame * 1.0 / countGames) * 100.0;
                    double percentLostGame = (countLostGame * 1.0 / countGames) * 100.0;
                    Console.WriteLine($"{percentWinGame:F2}% matches win");
                    Console.WriteLine($"{percentLostGame:F2}% matches lost");
                    break;
                }
                string nameOfTournament = command;
                int sumGames = int.Parse(Console.ReadLine());
                for (int i = 1; i <= sumGames; i++)
                {
                    int sumPointsDesi = int.Parse(Console.ReadLine());
                    int sumPointsOpponent = int.Parse(Console.ReadLine());
                    int diff = Math.Abs(sumPointsDesi - sumPointsOpponent);
                    countGames++;
                    if (sumPointsDesi > sumPointsOpponent)
                    {
                        countWinGame++;
                        Console.WriteLine($"Game {i} of tournament {nameOfTournament}: win with {diff} points.");
                    }
                    else if (sumPointsOpponent > sumPointsDesi)
                    {
                        countLostGame++;
                        Console.WriteLine($"Game {i} of tournament {nameOfTournament}: lost with {diff} points.");
                    }
                }
            }
        }
    }
}
