using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertFromInchesToCentimeters
{
    class Program
    {
        static void Main(string[] args)
        {
            // read inches from console
            double inches = double.Parse(Console.ReadLine());



            // convert to cm
            double centimeters = inches * 2.54;

            //write to console the centimeters
            Console.WriteLine(centimeters);
        }
    }
}
