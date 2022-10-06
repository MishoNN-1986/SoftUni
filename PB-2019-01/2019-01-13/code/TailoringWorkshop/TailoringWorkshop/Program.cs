using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TailoringWorkshop
{
    class Program
    {
        static void Main(string[] args)
        {
            int rectangleTable = int.Parse(Console.ReadLine());
            double lenghtRectangleTable = double.Parse(Console.ReadLine());
            double widthRectangleTable = double.Parse(Console.ReadLine());
            double lenghtCover = lenghtRectangleTable + 0.60;
            double widthCover = widthRectangleTable + 0.60;
            double sideSquare = lenghtRectangleTable / 2;
            double areaCover = lenghtCover * widthCover;
            double areaSquare = sideSquare * sideSquare;
            double priceCoverUSD = areaCover * 7 * rectangleTable;
            double priceCoverBGN = areaCover * 7 * 1.85 * rectangleTable;
            double priceSquareUSD = areaSquare * 9 * rectangleTable;
            double priceSquareBGN = areaSquare * 9 * 1.85 * rectangleTable;
            Console.WriteLine($"{priceCoverUSD + priceSquareUSD:F2} USD");
            Console.WriteLine($"{priceCoverBGN + priceSquareBGN:F2} BGN");



        }
    }
}
