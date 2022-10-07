using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            double levaForOnePeopleOfFamily = double.Parse(Console.ReadLine());
            double averageSuccess = double.Parse(Console.ReadLine());
            double minimumSalary = double.Parse(Console.ReadLine());
            double socialScholarship = Math.Floor(minimumSalary * 0.35);
            double excellentScholarship = Math.Floor(averageSuccess * 25);
            if (levaForOnePeopleOfFamily >= minimumSalary)
            {
                Console.WriteLine("You cannot get a scholarship!");
            }

            else if (averageSuccess <= 4.50)
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
            if (levaForOnePeopleOfFamily < minimumSalary)
            {

            }

            else if (socialScholarship > excellentScholarship)
            {

            }

            Console.WriteLine($"You get a Social scholarship {socialScholarship} BGN");

            if (averageSuccess >= 5.50)
            {

            }
            else if (excellentScholarship >= socialScholarship)
            {

            }
            Console.WriteLine($"You get a scholarship for excellent results {excellentScholarship} BGN");
        }
    }
}
        
