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
            var day = new DateTime(2020, 1, 13);
            Console.WriteLine(day);
            var birthday = new { Day = 22, Month = 6, Year = 1990 };
            Console.WriteLine(birthday);
            DateTime today = DateTime.Now;
            Console.WriteLine(today);

            Random rnd = new Random();
            int randomNumber = rnd.Next(1, 99);
            Console.WriteLine(randomNumber);
            
        }
    }
}
