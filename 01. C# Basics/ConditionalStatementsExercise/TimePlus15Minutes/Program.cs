using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimePlus15Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int allTimeInMinutes = hours * 60 + minutes + 15;
            hours = allTimeInMinutes / 60;
            minutes = allTimeInMinutes % 60;
            if (hours >= 24)
            {
                hours -= 24;
            }
            Console.WriteLine($"{hours}:{minutes:D2}");
        }
    }
}
