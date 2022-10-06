using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            //conversion string in small letters
            string text = Console.ReadLine();
            string lowel = text.ToLower();
            Console.WriteLine(lowel);
            //conversion string in big letters
            string text = Console.ReadLine();
            string upper = text.ToUpper();
            Console.WriteLine(upper);
        }
    }
}
