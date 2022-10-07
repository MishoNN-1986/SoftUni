using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxPoints = 0;
            string nameMaxPoints = "";
            int sumPointPlayer = 0;
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "Stop")
                {
                    break;
                }
                string name = command;
                for (int i = 0; i < name.Length; i++)
                {
                    int num = int.Parse(Console.ReadLine());
                    if (num == (int)name[i])
                    {
                        sumPointPlayer += 10;
                    }
                    else
                    {
                        sumPointPlayer += 2;
                    }
                }
                if (sumPointPlayer >= maxPoints)
                {
                    maxPoints = sumPointPlayer;
                    nameMaxPoints = name;
                }
                sumPointPlayer = 0;
            }
            Console.WriteLine($"The winner is {nameMaxPoints} with {maxPoints} points!");
        }
    }
}
