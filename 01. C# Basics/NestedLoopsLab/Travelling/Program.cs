using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string text = Console.ReadLine();
                if (text == "End")
                {
                    break;
                }
                double minBudget = double.Parse(Console.ReadLine());
                double sum = 0;
                for (double i = 0; i < minBudget; i += sum)
                {
                    sum =double.Parse(Console.ReadLine());
                }
                Console.WriteLine($"Going to {text}!");
            }
        }
    }
}
