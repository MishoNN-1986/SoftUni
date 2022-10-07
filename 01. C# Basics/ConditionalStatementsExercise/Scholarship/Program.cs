using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            double salary = double.Parse(Console.ReadLine());
            double average = double.Parse(Console.ReadLine());
            double minSalary = double.Parse(Console.ReadLine());
            double socialScholarship = 0.0;
            double scholarshipForExcelentResults = 0.0;

            if (salary < minSalary && average > 4.50)
            {
                socialScholarship = Math.Floor(minSalary * 0.35);
            }
            if (average >= 5.50)
            {
                scholarshipForExcelentResults = Math.Floor(average * 25.0);
            }
            if (socialScholarship == 0.0 && scholarshipForExcelentResults == 0.0)
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
            else if (socialScholarship > scholarshipForExcelentResults)
            {
                Console.WriteLine($"You get a Social scholarship {socialScholarship} BGN");
            }
            else
            {
                Console.WriteLine($"You get a scholarship for excellent results {scholarshipForExcelentResults} BGN");
            }

        }
    }
}
