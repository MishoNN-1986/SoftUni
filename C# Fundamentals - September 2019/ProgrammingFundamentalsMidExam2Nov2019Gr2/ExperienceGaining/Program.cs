using System;

namespace ExperienceGaining
{
    class Program
    {
        static void Main(string[] args)
        {
            double neededExperience = double.Parse(Console.ReadLine());
            int countOfBattles = int.Parse(Console.ReadLine());
            int count = 0;
            while (count < countOfBattles && neededExperience > 0)
            {
                double earnedExperience = double.Parse(Console.ReadLine());
                count++;
                if (count % 3 == 0)
                {
                    earnedExperience *= 1.15;
                }
                if (count % 5 == 0)
                {
                    earnedExperience *= 0.9;
                }

                neededExperience -= earnedExperience;
            }
            if (neededExperience <= 0)
            {
                Console.WriteLine($"Player successfully collected his needed experience for {count} battles.");
            }
            else
            {
                Console.WriteLine($"Player was not able to collect the needed experience, {neededExperience:F2} more needed.");
            }
        }
    }
}
