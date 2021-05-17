using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());    // брой сайтове
            int salary = int.Parse(Console.ReadLine()); // заплата
            for (int i = 0; i < n; i++)
            {
                string nameOfWebsite = Console.ReadLine();
                if (nameOfWebsite == "Facebook")
                {
                    salary -= 150;
                    if (salary <= 0)
                    {
                        Console.WriteLine("You have lost your salary.");
                        break;
                    }
                }
                else if (nameOfWebsite == "Instagram")
                {
                    salary -= 100;
                    if (salary <= 0)
                    {
                        Console.WriteLine("You have lost your salary.");
                        break;
                    }
                }
                else if (nameOfWebsite == "Reddit")
                {
                    salary -= 50;
                    if (salary <= 0)
                    {
                        Console.WriteLine("You have lost your salary.");
                        break;
                    }
                }
            }
            if (salary > 0)
            {
                Console.WriteLine($"{salary}");
            }
        }
    }
}
