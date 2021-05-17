using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            string dateAsText = Console.ReadLine();
            DateTime date = DateTime.ParseExact(dateAsText, "d-M-yyyy", CultureInfo.InvariantCulture);  // CultureInfo.InvariantCulture - взима само числата без нещата ммежду тях(пр:"-");
            Console.WriteLine(date.DayOfWeek);
        }
    }
}
