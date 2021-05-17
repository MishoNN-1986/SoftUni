using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LevaInEuro
{
    class Program
    {
        static void Main(string[] args)
        {
            double leva = double.Parse(Console.ReadLine());
            double euro = leva / 1.95583;
            Console.WriteLine(euro);
        }
    }
}
