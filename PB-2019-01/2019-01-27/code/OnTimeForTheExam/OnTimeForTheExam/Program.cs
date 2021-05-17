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
            int examHours = int.Parse(Console.ReadLine());
            int examMinutes = int.Parse(Console.ReadLine());
            int comingHours = int.Parse(Console.ReadLine());
            int comingMinutes = int.Parse(Console.ReadLine());
            int examInMinutesOnly = examHours * 60 + examMinutes;
            int comingInMinutesOnly = comingHours * 60 + comingMinutes;
            int minutesBeforeTheStart = 0;
            int hoursBeforeTheStart = 0;
            int minutesAfterTheStart = 0;
            int hoursAfterTheStart = 0;
            int minutesWithoutHoursBeforeTheStart = 0;
            int minutesWithoutHoursAfterTheStart = 0;
            if (examInMinutesOnly < comingInMinutesOnly)
            {
                minutesAfterTheStart = comingInMinutesOnly - examInMinutesOnly;
                hoursAfterTheStart = minutesAfterTheStart / 60;

                Console.WriteLine("Late");
            }
            else if ((examInMinutesOnly - comingInMinutesOnly) <= 30)
            {
                minutesBeforeTheStart = examInMinutesOnly - comingInMinutesOnly;

                Console.WriteLine("On time");
            }
            else if ((examInMinutesOnly - comingInMinutesOnly) > 30)
            {
                minutesBeforeTheStart = examInMinutesOnly - comingInMinutesOnly;
                hoursBeforeTheStart = minutesBeforeTheStart / 60;

                Console.WriteLine("Early");
            }
            if (minutesBeforeTheStart < 60 && minutesBeforeTheStart != 0)
            {
                minutesBeforeTheStart = examInMinutesOnly - comingInMinutesOnly;
                Console.WriteLine($"{minutesBeforeTheStart} minutes before the start");
            }
            else if (minutesBeforeTheStart >= 60)
            {
                minutesBeforeTheStart = examInMinutesOnly - comingInMinutesOnly;
                hoursBeforeTheStart = minutesBeforeTheStart / 60;
                minutesWithoutHoursBeforeTheStart = minutesBeforeTheStart % 60;
                Console.WriteLine($"{hoursBeforeTheStart}:{minutesWithoutHoursBeforeTheStart:D2} hours before the start");
            }
            else if (minutesAfterTheStart < 60 && minutesAfterTheStart != 0)
            {
                minutesAfterTheStart = comingInMinutesOnly - examInMinutesOnly;
                Console.WriteLine($"{minutesAfterTheStart} minutes after the start");
            }
            else if (minutesAfterTheStart >= 60)
            {
                minutesAfterTheStart = comingInMinutesOnly - examInMinutesOnly;
                hoursAfterTheStart = minutesAfterTheStart / 60;
                minutesWithoutHoursAfterTheStart = minutesAfterTheStart % 60;
                Console.WriteLine($"{hoursAfterTheStart}:{minutesWithoutHoursAfterTheStart:D2} hours after the start");
            }
        }
    }
}
