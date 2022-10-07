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
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x = Math.Abs(x1 - x2);                 // определяме страната х като взимаме разстоянието между координатните точки и взимаме абсолютната им стойност
            double y = Math.Abs(y1 - y2);
            double area = x * y;
            double perimeter = 2 * (x + y);
            Console.WriteLine($"{area:F2}");
            Console.WriteLine($"{perimeter:F2}");



        }
    }
}
