using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasterEggsBattle
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantityEggsFirstPlayer = int.Parse(Console.ReadLine());
            int quantityEggsSecondPlayer = int.Parse(Console.ReadLine());
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "End of battle")
                {
                    Console.WriteLine($"Player one has {quantityEggsFirstPlayer} eggs left.");
                    Console.WriteLine($"Player two has {quantityEggsSecondPlayer} eggs left.");
                    break;
                }
                if (command == "one")
                {
                    quantityEggsSecondPlayer--;
                    if (quantityEggsSecondPlayer == 0)
                    {
                        Console.WriteLine($"Player two is out of eggs. Player one has {quantityEggsFirstPlayer} eggs left.");
                        break;
                    }
                }
                else if (command == "two")
                {
                    quantityEggsFirstPlayer--;
                    if (quantityEggsFirstPlayer == 0)
                    {
                        Console.WriteLine($"Player one is out of eggs. Player two has {quantityEggsSecondPlayer} eggs left.");
                        break;
                    }
                }
            }
        }
    }
}
