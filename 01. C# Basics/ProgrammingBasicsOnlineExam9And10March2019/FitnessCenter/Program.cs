using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessCenter
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumPeople = int.Parse(Console.ReadLine());
            int back = 0;
            int chest = 0;
            int legs = 0;
            int abs = 0;
            int proteinShake = 0;
            int proteinBar = 0;
            int sumExercisePeople = 0;
            int sumCustomers = 0;
            for (int i = 0; i < sumPeople; i++)
            {
                string movement = Console.ReadLine();
                switch (movement)
                {
                    case "Back":
                        back++;
                        sumExercisePeople++;
                        break;
                    case "Chest":
                        chest++;
                        sumExercisePeople++;
                        break;
                    case "Legs":
                        legs++;
                        sumExercisePeople++;
                        break;
                    case "Abs":
                        abs++;
                        sumExercisePeople++;
                        break;
                    case "Protein shake":
                        proteinShake++;
                        sumCustomers++;
                        break;
                    case "Protein bar":
                        proteinBar++;
                        sumCustomers++;
                        break;
                }
            }
            double percentExercisePeople = sumExercisePeople * 1.0 / sumPeople * 100.0;
            double percentCustomers = sumCustomers * 1.0 / sumPeople * 100.0;
            Console.WriteLine($"{back} - back");
            Console.WriteLine($"{chest} - chest");
            Console.WriteLine($"{legs} - legs");
            Console.WriteLine($"{abs} - abs");
            Console.WriteLine($"{proteinShake} - protein shake");
            Console.WriteLine($"{proteinBar} - protein bar");
            Console.WriteLine($"{percentExercisePeople:F2}% - work out");
            Console.WriteLine($"{percentCustomers:F2}% - protein");
        }
    }
}
