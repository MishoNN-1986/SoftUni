using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace squareAreaDouble
{
    class Program
    {
        static void Main(string[] args)
        {
            // get square size from console
            double squareSide = double.Parse(Console.ReadLine());

            //calculate area
            double squareArea = squareSide * squareSide;

            //write to console
            Console.WriteLine(squareArea);

        }
    }
}
