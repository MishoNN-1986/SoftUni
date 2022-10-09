using System;
using System.Collections.Generic;
using System.Linq;

namespace KeyRevolver
{
    class Program
    {
        static void Main(string[] args)
        {
            int bulletPrice = int.Parse(Console.ReadLine());
            int sizeGunBarel = int.Parse(Console.ReadLine());
            Stack<int> bullets = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            Queue<int> locks = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            int value = int.Parse(Console.ReadLine());
            int countShoots = 0;
            int allShoots = 0;
            for (int i = 0; i < locks.Count; i++)
            {
                int bullet = bullets.Pop();
                int openLock = locks.Peek();
                if (bullet > openLock)
                {
                    Console.WriteLine("Ping!");
                }
                else
                {
                    Console.WriteLine("Bang!");
                    locks.Dequeue();
                }
                countShoots++;
                allShoots++;
                if (!bullets.Any() && !locks.Any())
                {
                    break;
                }
                if (!bullets.Any())
                {
                    Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
                    return;
                }

                if (countShoots == sizeGunBarel)
                {
                    Console.WriteLine("Reloading!");
                    countShoots = 0;
                }
                if (!locks.Any())
                {
                    break;
                }
                i--;
            }
            int earnedMoney = value - (allShoots * bulletPrice);
            int bulletsLeft = bullets.Count;
            Console.WriteLine($"{bulletsLeft} bullets left. Earned ${earnedMoney}");
        }
    }
}
