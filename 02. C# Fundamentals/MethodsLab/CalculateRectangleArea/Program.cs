using System;

namespace CalculateRectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = ReadDouble();
            double height = ReadDouble();

            double area = GetRectangleArea(width, height);
            
            Console.WriteLine(area);
        }

        static double ReadDouble()
        {
            return double.Parse(Console.ReadLine());
        }

        static double GetRectangleArea(double width, double height)
        {
            return width * height;
        }
    }
}
