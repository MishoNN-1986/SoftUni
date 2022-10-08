using System;

namespace BiscuitsFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int amountOfBiscuitsForADay = int.Parse(Console.ReadLine());
            int countOfWorkers = int.Parse(Console.ReadLine());
            int competingFactoryBiscuits = int.Parse(Console.ReadLine());
            int allBiscuitsForOneDay = amountOfBiscuitsForADay * countOfWorkers;
            double allBiscuits = 0;
            for (int i = 1; i <= 30; i++)
            {
                if (i % 3 == 0)
                {
                    allBiscuits += Math.Floor(allBiscuitsForOneDay * 0.75);
                    continue;
                }
                allBiscuits += allBiscuitsForOneDay;
            }
            Console.WriteLine($"You have produced {allBiscuits} biscuits for the past month.");
            if (allBiscuits > competingFactoryBiscuits)
            {
                Console.WriteLine($"You produce {(allBiscuits - competingFactoryBiscuits) / competingFactoryBiscuits * 100.0:F2} percent more biscuits.");
            }
            else if (allBiscuits < competingFactoryBiscuits)
            {
                Console.WriteLine($"You produce {(competingFactoryBiscuits - allBiscuits) / competingFactoryBiscuits * 100.0:F2} percent less biscuits.");
            }
        }
    }
}
