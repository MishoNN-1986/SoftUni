using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsGradeExcellent
{
    class Program
    {
        static void Main(string[] args)
        {
            // read grade from console
            double grate = double.Parse(Console.ReadLine());
            double lowestExcellentGradeValue = 5.50;
            bool isGradeExcellent = grate >= lowestExcellentGradeValue;

            // make the chek
            if (isGradeExcellent)
            {
                // true
                Console.WriteLine("Excellent");
            }
            // nothing
            Console.WriteLine("End of program");

            // true or false
            // write to console
        }
    }
}
