using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameNumberWars
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameFirstPlayer = Console.ReadLine();
            string nameSecondPlayer = Console.ReadLine();

            int pointsForFirstPlayer = 0;
            int pointsSecondPlayer = 0;
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "End of game")
                {
                    Console.WriteLine($"{nameFirstPlayer} has {pointsForFirstPlayer} points");
                    Console.WriteLine($"{nameSecondPlayer} has {pointsSecondPlayer} points");
                    break;
                }
                int cardFirstPlayer = int.Parse(command);
                int cardSecondPlayer = int.Parse(Console.ReadLine());
                int diff = Math.Abs(cardFirstPlayer - cardSecondPlayer);
                if (cardFirstPlayer > cardSecondPlayer)
                {
                    pointsForFirstPlayer += diff;
                }
                else if (cardSecondPlayer > cardFirstPlayer)
                {
                    pointsSecondPlayer += diff;
                }
                else
                {
                    int newCardFirstPlayer = int.Parse(Console.ReadLine());
                    int newCardSecondPlayer = int.Parse(Console.ReadLine());
                    Console.WriteLine("Number wars!");
                    if (newCardFirstPlayer > newCardSecondPlayer)
                    {
                        Console.WriteLine($"{nameFirstPlayer} is winner with {pointsForFirstPlayer} points");
                    }
                    else if (newCardSecondPlayer > newCardFirstPlayer)
                    {
                        Console.WriteLine($"{nameSecondPlayer} is winner with {pointsSecondPlayer} points");
                    }
                    break;
                }
            }
        }
    }
}
