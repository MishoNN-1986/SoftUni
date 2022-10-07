using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasDecoration
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            int price = 0;
            int moneyLeft = budget;
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "Stop")
                {
                    Console.WriteLine($"Money left: {moneyLeft}");
                    break;
                }
                for (int i = 0; i < command.Length; i++)
                {
                    price += command[i];
                }
                if (price <= moneyLeft)
                {
                    Console.WriteLine("Item successfully purchased!");
                    moneyLeft -= price;
                    price = 0;
                }
                else
                {
                    Console.WriteLine("Not enough money!");
                    break;
                }
            }
        }
    }
}
