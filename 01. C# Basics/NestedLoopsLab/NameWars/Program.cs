using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameWars
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int allSum = 0;
            int winner = 0;
            string winnerName = "";
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "STOP")
                {
                    break;
                }
                for (int i = 0; i < command.Length; i++)
                {
                    sum = command[i];
                    allSum += sum;
                    
                    // sum = (int)i;
                }
                if (allSum > winner)
                {
                    winner = allSum;
                    winnerName = command;
                }
                allSum = 0;
            }
                Console.WriteLine($"Winner is {winnerName} - {winner}!");
        }
    }
}
