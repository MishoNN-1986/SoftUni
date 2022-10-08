using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackIn30Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            var hours = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());
            var allMinutes = hours * 60 + minutes + 30;
            var newHours = allMinutes / 60;
            var newMinutes = allMinutes % 60;
            if (newHours >= 24)
            {
                newHours -= 24;
            }
            Console.WriteLine($"{newHours}:{newMinutes:D2}");
        }
    }
}
