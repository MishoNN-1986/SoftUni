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
            int sum = int.Parse(Console.ReadLine());
            bool flour = false;
            bool eggs = false;
            bool sugar = false;
            bool bake = false;
            int count = 1;
            while (count <= sum)
            {
                string text = Console.ReadLine();
                if (text == "flour")
                {
                    flour = true;
                }
                else if (text == "eggs")
                {
                    eggs = true;
                }
                else if (text == "sugar")
                {
                    sugar = true;
                }
                if (flour && eggs && sugar)
                {
                    bake = true;
                }
                if (text == "Bake!")
                {
                    if (bake)
                    {
                        Console.WriteLine($"Baking batch number {count}...");
                        count++;
                        flour = false;
                        eggs = false;
                        sugar = false;
                    }
                    else
                    {
                        Console.WriteLine("The batter should contain flour, eggs and sugar!");
                    }
                }
            }
        }
    }
}
