using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oscars
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double pointsFromAcademy = double.Parse(Console.ReadLine());
            int sumJury = int.Parse(Console.ReadLine());
            double allPoints = pointsFromAcademy;
            for (int i = 0; i < sumJury; i++)
            {
                string nameJury = Console.ReadLine();
                double pointsJury = double.Parse(Console.ReadLine());
                allPoints += nameJury.Length * pointsJury / 2.0;
                if (allPoints > 1250.5)
                {
                    Console.WriteLine($"Congratulations, {name} got a nominee for leading role with {allPoints:F1}!");
                    return;
                }
            }
            Console.WriteLine($"Sorry, {name} you need {1250.5 - allPoints:F1} more!");
        }
    }
}
