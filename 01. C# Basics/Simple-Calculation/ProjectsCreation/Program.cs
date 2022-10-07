using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectsCreation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int numOfProjects = int.Parse(Console.ReadLine());
            int allHoursOfProjects = numOfProjects * 3;
            Console.WriteLine($"The architect {name} will need {allHoursOfProjects} " +
                $"hours to complete {numOfProjects} project/s.");
        }
    }
}
