using System;

namespace BlackFlag
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int daylyPlunder = int.Parse(Console.ReadLine());
            double expectedPlunder = double.Parse(Console.ReadLine());
            double plunder = 0;
            int countDays = 1;
            //double losePlunder = 0;
            while (countDays <= days)
            {
                plunder += daylyPlunder;
                if (countDays % 3 == 0)
                {
                    plunder += 0.5 * daylyPlunder;
                }
                if (countDays % 5 == 0)
                {
                    //losePlunder = plunder * 0.3;
                    plunder *= 0.7;
                }
                countDays++;
            }
            if (plunder >= expectedPlunder)
            {
                Console.WriteLine($"Ahoy! {plunder:F2} plunder gained.");
            }
            else
            {
                Console.WriteLine($"Collected only {((plunder / expectedPlunder) * 100.0):F2}% of the plunder.");
            }
        }
    }
}
