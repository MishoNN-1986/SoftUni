using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareArea
{
    class Program
    {
        static void Main(string[] args)
        {
            // get square side size
            int squareSide = int.Parse(Console.ReadLine());

            // calculate area
            int squareArea = squareSide * squareSide;

            // write to console
            Console.WriteLine(squareArea); 

        }
    }
}
