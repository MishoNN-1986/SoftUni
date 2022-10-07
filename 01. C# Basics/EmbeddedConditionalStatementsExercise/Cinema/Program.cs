using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            double price = 0;
            switch (type)
            {
                case "Premiere":
                    price = 12.0;
                    break;
                case "Normal":
                    price = 7.5;
                    break;
                case "Discount":
                    price = 5.0;
                    break;
            }
            price *= a * b;
            Console.WriteLine($"{price:F2} leva");
        }
    }
}
