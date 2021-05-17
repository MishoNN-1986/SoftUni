using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());
            int capacity = 255;
            int quantityCapacity = 0;
            for (int i = 0; i < numberOfLines; i++)
            {
                int liters = int.Parse(Console.ReadLine());
                if (liters <= capacity)
                {
                    capacity -= liters;
                    quantityCapacity += liters;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }
            }
            Console.WriteLine(quantityCapacity);
        }
    }
}
