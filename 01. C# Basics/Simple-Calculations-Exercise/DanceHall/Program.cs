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
            double l = double.Parse(Console.ReadLine());  //дължина на залата в метри
            double w = double.Parse(Console.ReadLine());  //ширина на залата в метри
            double a = double.Parse(Console.ReadLine());  //страна на гардероба в метри
            double allArea = l * w;
            double areaOfBench = allArea / 10;
            double freeArea = allArea - areaOfBench - (a * a);
            double numOfDancer = freeArea /0.704 ;
            Console.WriteLine(Math.Floor(numOfDancer));


        }
    }
}
