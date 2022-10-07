using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasterCompetition
{
    class Program
    {
        static void Main(string[] args)
        {
            int EasterBake = int.Parse(Console.ReadLine());
            int countPoint = 0;
            int winPoints = 0;
            string winName = "";
            for (int i = 0; i < EasterBake; i++)
            {
                string name = Console.ReadLine();
                while (true)
                {
                    string command = Console.ReadLine();
                    if (command == "Stop")
                    {
                        Console.WriteLine($"{name} has {countPoint} points.");
                        if (countPoint > winPoints)
                        {
                            Console.WriteLine($"{name} is the new number 1!");
                            winPoints = countPoint;
                            winName = name;
                        }
                        countPoint = 0;
                        break;
                    }
                    int rating = int.Parse(command);
                    countPoint += rating;
                }
            }
            Console.WriteLine($"{winName} won competition with {winPoints} points!");
        }
    }
}
