using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadiansToDegrees
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. read radians
            //2. Calkulate degrees -> radians * 180 / pi
            //3. Print -> round
            //4. Test
            double rad = double.Parse(Console.ReadLine());
            double degrees = rad * 180 / Math.PI;
            Console.WriteLine(Math.Round(degrees));
        }
    }
}
