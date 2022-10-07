using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalTitles
{
    class Program
    {
        static void Main(string[] args)
        {
            double age = double.Parse(Console.ReadLine());
            string gender = Console.ReadLine();

            switch (gender)
            {
                case "m":
                    if (age >= 16)
                    {
                        Console.WriteLine("Mr.");
                    }
                    else
                    {
                        Console.WriteLine("Master");
                    }
                    break;
                case "f":
                    if (age >= 16)
                    {
                        Console.WriteLine("Ms.");
                    }
                    else
                    {
                        Console.WriteLine("Miss");
                    }
                    break;
            }
        }
    }
}
