using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTimeForTheExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int hourOfExam = int.Parse(Console.ReadLine());
            int minuteOfExam = int.Parse(Console.ReadLine());
            int hourOfArrival = int.Parse(Console.ReadLine());
            int minuteOfArrival = int.Parse(Console.ReadLine());

            int examInMinutes = hourOfExam * 60 + minuteOfExam;
            int arrivalInMinutes = hourOfArrival * 60 + minuteOfArrival;
            int difference = examInMinutes - arrivalInMinutes;
            if (difference < 0)
            {
                Console.WriteLine("Late");
            }
            else if (difference > 30)
            {
                Console.WriteLine("Early");
            }
            else
            {
                Console.WriteLine("On time");
            }
            if (difference > 0 && difference < 60)
            {
                Console.WriteLine($"{difference} minutes before the start");
            }
            else if (difference >= 60)
            {
                int hoursBeforeTheStart = difference / 60;
                int minutesBeforeTheStart = difference % 60;
                Console.WriteLine($"{hoursBeforeTheStart}:{minutesBeforeTheStart:D2} hours before the start");
            }
            else if (difference < 0 && difference > -60)
            {
                difference = Math.Abs(difference);
                Console.WriteLine($"{difference} minutes after the start");
            }
            else if (difference <= -60)
            {
                difference = Math.Abs(difference);
                int hourAfterTheStart = difference / 60;
                int minutesAfterTheStart = difference % 60;
                Console.WriteLine($"{hourAfterTheStart}:{minutesAfterTheStart:D2} hours after the start");
            }
        }
    }
}
