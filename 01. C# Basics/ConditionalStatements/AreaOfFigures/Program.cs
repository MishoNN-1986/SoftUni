using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            double area = 0.0;
            switch (figure)
            {
                case "square":
                    double a = double.Parse(Console.ReadLine());
                    area = a * a;
                    break;
                case "rectangle":
                    double b = double.Parse(Console.ReadLine());
                    double c = double.Parse(Console.ReadLine());
                    area = b * c;
                    break;
                case "circle":
                    double r = double.Parse(Console.ReadLine());
                    area = Math.PI * r * r;
                    break;
                case "triangle":
                    double d = double.Parse(Console.ReadLine());
                    double h = double.Parse(Console.ReadLine());
                    area = d * h / 2;
                    break;

            }
            Console.WriteLine($"{ area}");
        }
    }
}
