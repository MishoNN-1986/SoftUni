using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookieFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            for (int i = 1; i <= count; i++)
            {
                string ingradient = Console.ReadLine();

                bool eggs = false;
                bool flour = false;
                bool sugar = false;

                while (true)
                {
                    if (ingradient == "eggs")
                    {
                        eggs = true;
                    }
                    else if (ingradient == "flour")
                    {
                        flour = true;
                    }
                    else if (ingradient == "sugar")
                    {
                        sugar = true;
                    }
                    else if (ingradient == "Bake!")
                    {
                        if (eggs && sugar && flour == true)
                        {
                            Console.WriteLine($"Baking batch number {i}...");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("The batter should contain flour, eggs and sugar!");
                        }
                    }
                    ingradient = Console.ReadLine();
                }
            }
        }
    }
}