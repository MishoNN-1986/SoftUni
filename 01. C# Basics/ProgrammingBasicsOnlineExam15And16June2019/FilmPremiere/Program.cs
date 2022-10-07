using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmPremiere
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameMoovie = Console.ReadLine();
            string food = Console.ReadLine();
            int sumTickets = int.Parse(Console.ReadLine());
            double price = 0;
            switch (nameMoovie)
            {
                case "John Wick":
                    switch (food)
                    {
                        case "Drink":
                            price = 12;
                            break;
                        case "Popcorn":
                            price = 15;
                            break;
                        case "Menu":
                            price = 19;
                            break;
                    }
                    break;
                case "Star Wars":
                    switch (food)
                    {
                        case "Drink":
                            price = 18;
                            break;
                        case "Popcorn":
                            price = 25;
                            break;
                        case "Menu":
                            price = 30;
                            break;
                    }
                    break;
                case "Jumanji":
                    switch (food)
                    {
                        case "Drink":
                            price = 9;
                            break;
                        case "Popcorn":
                            price = 11;
                            break;
                        case "Menu":
                            price = 14;
                            break;
                    }
                    break;
            }
            if (nameMoovie == "Star Wars" && sumTickets >= 4)
            {
                price *= 0.7;
            }
            else if (nameMoovie == "Jumanji" && sumTickets == 2)
            {
                price *= 0.85;
            }
            double allSum = price * sumTickets;
            Console.WriteLine($"Your bill is {allSum:F2} leva.");
        }
    }
}
