using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainTheTrainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumJury = int.Parse(Console.ReadLine());
            double sumGrade = 0.0;
            double avarageGrade = 0.0;
            double allAvarageGrade = 0.0;
            double finalAllAvarageGrade = 0.0;
            int sumCommand = 0;
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "Finish")
                {
                    finalAllAvarageGrade = allAvarageGrade / sumCommand;
                    Console.WriteLine($"Student's final assessment is {finalAllAvarageGrade:F2}.");
                    break;
                }
                for (int i = 0; i < sumJury; i++)
                {
                    double grade = double.Parse(Console.ReadLine());
                    sumGrade += grade;
                }
                avarageGrade = sumGrade / sumJury;
                Console.WriteLine($"{command} - {avarageGrade:F2}.");
                allAvarageGrade += avarageGrade;
                sumGrade = 0;
                avarageGrade = 0;
                sumCommand++;
            }
        }
    }
}
