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
            string nameOfTheFirstPlayer = Console.ReadLine();
            string nameOfTheSecondPlayer = Console.ReadLine();
            int countFirstplayer = 0;
            int countSecondPlayer = 0;
            
            while (true)
            {
                int firstCard = int.Parse(Console.ReadLine());
                int secondCard = int.Parse(Console.ReadLine());
                if(firstCard > secondCard)
                {
                    countFirstplayer += firstCard - secondCard;
                }
                else if (secondCard > firstCard)
                {
                    countSecondPlayer += secondCard - firstCard;
                }
                else
                {
                    int card1 = int.Parse(Console.ReadLine());
                    int card2 = int.Parse(Console.ReadLine());
                    if (card1 > card2)
                    {
                        Console.WriteLine("Number wars!");
                        Console.WriteLine($"{nameOfTheFirstPlayer} is winner with {countFirstplayer} points");
                        break;
                    }
                    else if (card2 > card1)
                    {
                        Console.WriteLine("Number wars!");
                        Console.WriteLine($"{nameOfTheSecondPlayer} is winner with {countSecondPlayer} points");
                        break;
                    }
                }
            }
            

            
        }
    }
}
