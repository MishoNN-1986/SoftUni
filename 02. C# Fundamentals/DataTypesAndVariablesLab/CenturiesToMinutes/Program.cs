using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenturiesToMinutes
{
    class Program
    {
        static void Main(string[] args)
        {
            var centuries = byte.Parse(Console.ReadLine());
            var years = (short)(centuries * 100);
            var days = (uint)Math.Floor(years * 365.2422);
            var hours = (uint)days * 24;
            var minutes = (ulong)hours * 60;
            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");
        }
    }
}
