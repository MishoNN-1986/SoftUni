using System;
using System.Collections.Generic;
using System.Linq;
namespace ManOWar
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> pirateShip = Console.ReadLine().Split(">").Select(int.Parse).ToList();
            List<int> warship = Console.ReadLine().Split(">").Select(int.Parse).ToList();
            int maxHealthCapacity = int.Parse(Console.ReadLine());
            string[] command = Console.ReadLine().Split();
            while (command[0] != "Retire")
            {
                switch (command[0])
                {
                    case "Fire":

                        int index = int.Parse(command[1]);
                        int damage = int.Parse(command[2]);
                        Fire(warship, index, damage);
                        break;
                    case "Defend":
                        int startIndex = int.Parse(command[1]);
                        int endIndex = int.Parse(command[2]);
                        int damageDefend = int.Parse(command[3]);
                        Defend(pirateShip, startIndex, endIndex, damageDefend);
                        break;
                    case "Repair":
                        int repairIndex = int.Parse(command[1]);
                        int health = int.Parse(command[2]);
                        Repair(pirateShip, maxHealthCapacity, repairIndex, health);
                        break;
                    case "Status":
                        Status(pirateShip, maxHealthCapacity);
                        break;
                }
                //Console.WriteLine(string.Join(" ", pirateShip));
                command = Console.ReadLine().Split();
            }
            if (pirateShip.Count == 0 || warship.Count == 0)
            {
                return;
            }
                int pirateSum = 0;
                int warshipSum = 0;
                for (int i = 0; i < pirateShip.Count; i++)
                {
                    pirateSum += pirateShip[i];
                }
                for (int i = 0; i < warship.Count; i++)
                {
                    warshipSum += warship[i];
                }
                Console.WriteLine($"Pirate ship status: {pirateSum}");
                Console.WriteLine($"Warship status: {warshipSum}");
        }

        private static void Status(List<int> pirateShip, int maxHealthCapacity)
        {
            int count = 0;
            for (int i = 0; i < pirateShip.Count; i++)
            {
                if (pirateShip[i] * 1.0 / maxHealthCapacity < 0.2)
                {
                    count++;
                }
            }
            Console.WriteLine($"{count} sections need repair.");
            return;
        }

        private static void Repair(List<int> pirateShip, int maxHealthCapacity, int repairIndex, int health)
        {
            if (repairIndex < 0 || repairIndex >= pirateShip.Count)
            {
                return;
            }
            pirateShip[repairIndex] = pirateShip[repairIndex] + health;
            if (pirateShip[repairIndex] > maxHealthCapacity)
            {
                pirateShip[repairIndex] = maxHealthCapacity;
            }
        }

        private static void Defend(List<int> pirateShip, int startIndex, int endIndex, int damageDefend)
        {
            if (startIndex < 0 || startIndex >= pirateShip.Count || endIndex < 0 || endIndex >= pirateShip.Count)
            {
                return;
            }
            for (int i = startIndex; i <= endIndex; i++)
            {
                pirateShip[i] = pirateShip[i] - damageDefend;
                if (pirateShip[i] <= 0)
                {
                    pirateShip.Clear();
                    Console.WriteLine("You lost! The pirate ship has sunken.");
                    return;
                }
            }
        }

        private static void Fire(List<int> warship, int index, int damage)
        {
            if (index < 0 || index >= warship.Count)
            {
                return;
            }
            warship[index] = warship[index] - damage;
            if (warship[index] <= 0)
            {
                warship.Clear();
                Console.WriteLine("You won! The enemy ship has sunken.");
                return;
            }
        }
    }
}
