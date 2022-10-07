using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetricConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            //double num = double.Parse(Console.ReadLine());
            //string input = Console.ReadLine();
            //string output = Console.ReadLine();

            //if (input == "mm")
            //{
            //    num /= 1000;
            //}
            //else if (input == "cm")
            //{
            //    num /= 100;
            //}
            //if (output == "mm")
            //{
            //    num *= 1000;
            //}
            //else if (output == "cm")
            //{
            //    num *= 100;
            //}
            //Console.WriteLine($"{num:F3}");
            double num = double.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            string output = Console.ReadLine();
            double outputNum = 0.0;
            if (input == "mm")
            {
                if (output == "cm")
                {
                    outputNum = num / 10.0;
                }
                else if (output == "m")
                {
                    outputNum = num / 1000.0;
                }
                Console.WriteLine($"{outputNum:F3}");

            }
            else if (input == "cm")
            {
                if (output == "mm")
                {
                    outputNum = num * 10.0;
                }
                else if (output == "m")
                {
                    outputNum = num / 100.0;
                }
                Console.WriteLine($"{outputNum:F3}");
            }
            else if (input == "m")
            {
                if (output == "mm")
                {
                    outputNum = num * 1000.0;
                }
                else if (output == "cm")
                {
                    outputNum = num * 100.0;
                }
                Console.WriteLine($"{outputNum:F3}");
            }
        }
    }
}


