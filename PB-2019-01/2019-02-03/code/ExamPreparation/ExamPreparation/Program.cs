using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputOfBadGrades = int.Parse(Console.ReadLine());
            int counterOfBadGrades = 0;
            double sumGrades = 0.0;
            int counterForGrades = 0;
            string lastProblem = string.Empty;
            double averageScore = 0.0;
            while (counterOfBadGrades < inputOfBadGrades)
            {
                string taskName = Console.ReadLine();
              

                if (taskName == "Enough")
                {
                    
                    Console.WriteLine($"Average score: {averageScore:F2}");
                    Console.WriteLine($"Number of problems: {counterForGrades}");
                    Console.WriteLine($"Last problem: {lastProblem}");
                    break;
                }
                else
                {
                    int grade = int.Parse(Console.ReadLine());
                    sumGrades += grade*1.0;
                    counterForGrades += 1;
                    lastProblem = taskName;
                    averageScore = sumGrades * 1.0 / counterForGrades;
                    if (grade <= 4)
                    {
                        counterOfBadGrades++;
                    }
                }
            }
            if (counterOfBadGrades == inputOfBadGrades)
            {
                Console.WriteLine($"You need a break, {counterOfBadGrades} poor grades.");
            }
        }
    }
}
