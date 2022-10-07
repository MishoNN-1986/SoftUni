using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballTournament
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int sumGames = int.Parse(Console.ReadLine());
            string result = "";
            int allPoints = 0;
            int w = 0;
            int d = 0;
            int l = 0;
            if (sumGames == 0)
            {
                Console.WriteLine($"{name} hasn't played any games during this season.");
                return;
            }
            for (int i = 0; i < sumGames; i++)
            {
                result = Console.ReadLine();
                if (result == "W")
                {
                    w++;
                    allPoints += 3;
                }
                else if (result == "D")
                {
                    d++;
                    allPoints += 1;
                }
                else
                {
                    l++;
                }
            }
            Console.WriteLine($"{name} has won {allPoints} points during this season.");
            Console.WriteLine("Total stats:");
            Console.WriteLine($"## W: {w}");
            Console.WriteLine($"## D: {d}");
            Console.WriteLine($"## L: {l}");
            Console.WriteLine($"Win rate: {(w * 1.0 / sumGames) * 100.0:F2}%");
        }
    }
}
