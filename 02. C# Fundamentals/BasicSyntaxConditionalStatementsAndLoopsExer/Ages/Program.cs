using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ages
{
    class Program
    {
        static void Main(string[] args)
        {
            var age = int.Parse(Console.ReadLine());
            string aPersonIs = "";
            if (age >= 0 && age < 3)
            {
                aPersonIs = "baby";
            }
            else if (age >= 3 && age <= 13)
            {
                aPersonIs = "child";
            }
            else if (age > 13 && age <= 19)
            {
                aPersonIs = "teenager";
            }
            else if (age >= 20 && age <= 65)
            {
                aPersonIs = "adult";
            }
            else if (age >= 66)
            {
                aPersonIs = "elder";
            }
            Console.WriteLine(aPersonIs);
        }
    }
}
