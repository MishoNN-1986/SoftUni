using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertFromInchesTocentimetersFormating
{
    class Program
    {
        static void Main(string[] args)
        {
            double inches = double.Parse(Console.ReadLine());
            double convertRatio = 2.54;
            double centimeters = inches * convertRatio;
            Console.WriteLine("{0:F2}", centimeters);
        }
    }
}
