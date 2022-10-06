using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleCalculations
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());
            double pi = Math.PI;
            double area = pi * r * r;
            double perimeter = 2 * pi * r;
            Console.WriteLine("{0:F2}", area);
            Console.WriteLine("{0:F2}", perimeter);




        }
    }
}
