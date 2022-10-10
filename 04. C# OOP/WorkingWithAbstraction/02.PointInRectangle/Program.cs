using System;
using System.Linq;

namespace _02.PointInRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] coordinates = GetReadInt();
            int topLeftX = coordinates[0];
            int topLeftY = coordinates[1];
            int bottomRightX = coordinates[2];
            int bottomRightY = coordinates[3];
            Point topLeft = new Point(topLeftX, topLeftY);
            Point topRight = new Point(bottomRightX, bottomRightY);
            Rectangle rectangle = new Rectangle(topLeft, topRight);

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int[] coordinatesOfPoints = GetReadInt();
                Point point = new Point(coordinatesOfPoints[0], coordinatesOfPoints[1]);
                Console.WriteLine(rectangle.Contains(point));
            }

        }

        private static int[] GetReadInt()
        {
            return Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
        }
    }
}
