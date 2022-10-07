using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintingEggs
{
    class Program
    {
        static void Main(string[] args)
        {
            string size = Console.ReadLine();
            string color = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            int price = 0;
            switch (size)
            {
                case "Large":
                    switch (color)
                    {
                        case "Red":
                            price = 16;
                            break;
                        case "Green":
                            price = 12;
                            break;
                        case "Yellow":
                            price = 9;
                            break;
                    }
                    break;
                case "Medium":
                    switch (color)
                    {
                        case "Red":
                            price = 13;
                            break;
                        case "Green":
                            price = 9;
                            break;
                        case "Yellow":
                            price = 7;
                            break;
                    }
                    break;
                case "Small":
                    switch (color)
                    {
                        case "Red":
                            price = 9;
                            break;
                        case "Green":
                            price = 8;
                            break;
                        case "Yellow":
                            price = 5;
                            break;
                    }
                    break;
            }
            double allSum = quantity * price * 0.65;
            Console.WriteLine($"{allSum:F2} leva.");
        }
    }
}
