using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DartsTournament
{
    class Program
    {
        static void Main(string[] args)
        {
            int initialNumberOfPoints = int.Parse(Console.ReadLine());
            int count = 0;
            while (initialNumberOfPoints > 0)
            {
                string sector = Console.ReadLine();
                count++;
                if (sector == "bullseye")
                {
                    Console.WriteLine($"Congratulations! You won the game with a bullseye in {count} moves!");
                    break;
                }
                int sumPoints = int.Parse(Console.ReadLine());
                if (sector == "double ring")
                {
                    sumPoints *= 2;
                }
                else if (sector == "triple ring")
                {
                    sumPoints *= 3;
                }
                initialNumberOfPoints -= sumPoints;
            }
            if (initialNumberOfPoints == 0)
            {
                Console.WriteLine($"Congratulations! You won the game in {count} moves!");
            }
            else if (initialNumberOfPoints < 0)
            {
                Console.WriteLine($"Sorry, you lost. Score difference: {Math.Abs(initialNumberOfPoints)}.");
            }
        }
    }
}
