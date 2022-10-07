using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanceHall
{
    class Program
    {
        static void Main(string[] args)
        {
            double Length = double.Parse(Console.ReadLine());
            double widht = double.Parse(Console.ReadLine());
            double side = double.Parse(Console.ReadLine()); // strana na kvadraten garderob
            double areaHall = Length * widht; //ploshtta na zalata
            double areaSquare = side * side; // ploshtta na kvadraten garderob
            double areaRectangle = areaHall / 10; // ploshtta na pravoygylna skameika
            double areaDancer = 7040d/10000; // ploshtta na tanciora
            double freeArea = areaHall - areaSquare - areaRectangle;
            double people = freeArea / areaDancer;
            Console.WriteLine(Math.Floor(people));
            


        }
    }
}
