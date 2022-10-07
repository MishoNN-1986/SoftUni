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
            int countJury = int.Parse(Console.ReadLine());

            string presentation = Console.ReadLine();
            double sumAllGrades = 0;
            int countAllGrade = 0;
            while (presentation != "Finish")
            {
                double sum = 0;                       // slagame q tuk, za da se nulira, ako e gore shte se trupa
                for (int i = 1; i <= countJury; i++)
                {
                    double grade = double.Parse(Console.ReadLine());
                    sum += grade;

                    sumAllGrades += grade;
                    countAllGrade++;
                }
                double average = sum / countJury;
                Console.WriteLine($"{presentation} - {average:F2}.");

                presentation = Console.ReadLine();
            }
            double averageAllGrades = sumAllGrades / countAllGrade;
            Console.WriteLine($"Student's final assessment is {averageAllGrades:F2}.");
        }
    }
}
