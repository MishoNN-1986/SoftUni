using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasterEggs
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumEggs = int.Parse(Console.ReadLine());
            int quantityRedEggs = 0;
            int quantityOrangeEggs = 0;
            int quantityBlueEggs = 0;
            int quantityGreenEggs = 0;
            int quantityColorMaxEggs = 0;
            string maxColor = "";
            for (int i = 0; i < sumEggs; i++)
            {
                string color = Console.ReadLine();
                switch (color)
                {
                    case "red":
                        quantityRedEggs++;
                        break;
                    case "orange":
                        quantityOrangeEggs++;
                        break;
                    case "blue":
                        quantityBlueEggs++;
                        break;
                    case "green":
                        quantityGreenEggs++;
                        break;
                }
            }
            if (quantityRedEggs > quantityColorMaxEggs)
            {
                quantityColorMaxEggs = quantityRedEggs;
                maxColor = "red";
            }
            if (quantityOrangeEggs > quantityColorMaxEggs)
            {
                quantityColorMaxEggs = quantityOrangeEggs;
                maxColor = "orange";
            }
            if (quantityBlueEggs > quantityColorMaxEggs)
            {
                quantityColorMaxEggs = quantityBlueEggs;
                maxColor = "blue";
            }
            if (quantityGreenEggs > quantityColorMaxEggs)
            {
                quantityColorMaxEggs = quantityGreenEggs;
                maxColor = "green";
            }
            Console.WriteLine($"Red eggs: {quantityRedEggs}");
            Console.WriteLine($"Orange eggs: {quantityOrangeEggs}");
            Console.WriteLine($"Blue eggs: {quantityBlueEggs}");
            Console.WriteLine($"Green eggs: {quantityGreenEggs}");
            Console.WriteLine($"Max eggs: {quantityColorMaxEggs} -> {maxColor}");
        }
    }
}
