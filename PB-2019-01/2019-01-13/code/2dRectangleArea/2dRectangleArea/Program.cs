using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2dRectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read coordinats x1, y1, x2, y2
            // Calculate lenght = x1 - x2
            // Calculate wight = y1 - y2
            // Calculate area = lenght * wight
            // Calculate per = 2 * (len + wi)
            // Print
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double lenght = Math.Abs(x1 - x2); //math.abs - absoliutna stoinost
            double wight = Math.Abs(y1 - y2);
            double area = lenght * wight;
            double perimeter = 2 * (lenght + wight);
            Console.WriteLine($"{area:F2}");
            Console.WriteLine($"{perimeter:F2}");
        }
    }
}
