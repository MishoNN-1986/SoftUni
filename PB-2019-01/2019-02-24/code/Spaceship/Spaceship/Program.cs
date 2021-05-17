using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spaceship
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine()); // shirina na koraba
            double b = double.Parse(Console.ReadLine());  // dyljina na koraba
            double h = double.Parse(Console.ReadLine()); //visochina na koraba
            double hForAstronauts = double.Parse(Console.ReadLine()); // sredna visochina na stronaftite
            double area = a * b * h;
            double roomForOneAstronauts = 2 * 2 * (hForAstronauts + 0.40);
            double numRoom = Math.Floor(area / roomForOneAstronauts);
            if (numRoom >= 3 && numRoom <= 10)
            {
                Console.WriteLine($"The spacecraft holds {numRoom} astronauts.");
            }
            else if (numRoom < 3)
            {
                Console.WriteLine("The spacecraft is too small.");
               
                
            }
            else
            {
                Console.WriteLine("The spacecraft is too big.");
            }
        }
    }
}
