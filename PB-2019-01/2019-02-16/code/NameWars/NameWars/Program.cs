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
            int maxLettersSum = 0;
            string winnerName = "";
            while (true)
            {
                string name = Console.ReadLine();
                if (name == "STOP")
                {
                    break;
                }
                
                int currentNameCharSum = 0;
                for (int i = 0; i < name.Length; i++)
                {
                    int letterValue = name[i];
                    currentNameCharSum += letterValue;
                }
                if (currentNameCharSum > maxLettersSum)
                {
                    maxLettersSum = currentNameCharSum;
                    winnerName = name;
                }
                
            }
            Console.WriteLine($"Winner is {winnerName} - {maxLettersSum}!");
        }
    }
}
