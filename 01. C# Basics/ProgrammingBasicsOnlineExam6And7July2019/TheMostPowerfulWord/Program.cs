using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMostPowerfulWord
{
    class Program
    {
        static void Main(string[] args)
        {
            string maxName = "";
            double maxPoints = 0;
            double points = 0;
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "End of words")
                {
                    break;
                }
                for (int i = 0; i < command.Length; i++)
                {
                    points += (int)command[i];
                }
                if ((int)command[0] == 97 || (int)command[0] == 101 || (int)command[0] == 105 || (int)command[0] == 111 || (int)command[0] == 117 || (int)command[0] == 121 || (int)command[0] == 65 || (int)command[0] == 69 || (int)command[0] == 73 || (int)command[0] == 79 || (int)command[0] == 85 || (int)command[0] == 89)
                {
                    points *= command.Length * 1.0;
                }
                else
                {
                    points = Math.Floor(points / command.Length * 1.0);
                }
                if (points > maxPoints)
                {
                    maxPoints = points;
                    maxName = command;
                }
                points = 0;
            }
            Console.WriteLine($"The most powerful word is {maxName} - {maxPoints}");
        }
    }
}
