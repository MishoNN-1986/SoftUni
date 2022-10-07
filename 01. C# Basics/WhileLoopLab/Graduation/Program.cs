using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int numClass = 1;
            double sumEvaluation = 0;
            double averageSuccess = 0;
            while (numClass <= 12)
            {
                double evaluation = double.Parse(Console.ReadLine());
                if (evaluation < 4.00)
                {
                    continue;
                }
                sumEvaluation += evaluation;
                numClass++;
            }
            averageSuccess = sumEvaluation / 12.0;
            Console.WriteLine($"{name} graduated. Average grade: {averageSuccess:F2}");
        }
    }
}
