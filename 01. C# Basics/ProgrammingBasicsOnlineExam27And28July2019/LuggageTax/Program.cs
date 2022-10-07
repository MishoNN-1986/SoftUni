using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuggageTax
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            string priority = Console.ReadLine();
            int tax = 0;
            int volume = width * height * length;
            switch (priority)
            {
                case "true":
                    if (volume <= 100)
                    {
                        tax = 0;
                    }
                    else if (volume > 100 && volume <= 200)
                    {
                        tax = 10;
                    }
                    else if (volume > 200 && volume <= 300)
                    {
                        tax = 20;
                    }
                    break;
                case "false":
                    if (volume <= 50)
                    {
                        tax = 0;
                    }
                    else if (volume > 50 && volume <= 100)
                    {
                        tax = 25;
                    }
                    else if (volume > 100 && volume <= 200)
                    {
                        tax = 50;
                    }
                    else if (volume > 200 && volume <= 300)
                    {
                        tax = 100;
                    }
                    break;
            }
            Console.WriteLine($"Luggage tax: {tax:F2}");
        }
    }
}
