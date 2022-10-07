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
            int badScores = int.Parse(Console.ReadLine());
            int count = 1;
            double averageScore = 0.0;
            int score = 0;
            string lastProblem = "";
            int sumBadScores = 0;
            int sumOfScore = 0;
            while (sumBadScores < badScores)
            {
                string nameOfProblem = Console.ReadLine();
                if (nameOfProblem == "Enough")
                {
                    Console.WriteLine($"Average score: {averageScore:F2}");
                    Console.WriteLine($"Number of problems: {count - 1}");
                    Console.WriteLine($"Last problem: {lastProblem}");
                    break;
                }
                score = int.Parse(Console.ReadLine());
                sumOfScore += score;
                averageScore = (double)sumOfScore / count; //*1.0
                lastProblem = nameOfProblem;
                if (score <= 4)
                {
                    sumBadScores++;
                }
                count++;
            }
            if (sumBadScores == badScores)
            {
                Console.WriteLine($"You need a break, {badScores} poor grades.");
            }
        }
    }
}
