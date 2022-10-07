using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number1To9ToText
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string numText = "";
            if (num == 1)
            {
                numText = "one";
            }
            else if (num == 2)
            {
                numText = "two";
            }
            else if (num == 3)
            {
                numText = "three";
            }
            else if (num == 4)
            {
                numText = "four";
            }
            else if (num == 5)
            {
                numText = "five";
            }
            else if (num == 6)
            {
                numText = "six";
            }
            else if (num == 7)
            {
                numText = "seven";
            }
            else if (num == 8)
            {
                numText = "eight";
            }
            else if (num == 9)
            {
                numText = "nine";
            }
            else
            {
                Console.WriteLine("number too big");
            }
            Console.WriteLine(numText);

        }
    }
}
