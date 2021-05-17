using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowerOrUpper
{
    class Program
    {
        static void Main(string[] args)
        {
            char letter = char.Parse(Console.ReadLine());
            if ((int)letter >= 65 && (int)letter <= 90)
            {
                Console.WriteLine("upper-case");
            }
            else if ((int)letter >= 97 && (int)letter <= 122)
            {
                Console.WriteLine("lower-case");
            }
        }
    }
}
