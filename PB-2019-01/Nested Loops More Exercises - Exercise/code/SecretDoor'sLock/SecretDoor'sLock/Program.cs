using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecretDoor_sLock
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());  // chislo otgovarqshto za maksimalnata stoinost na stoticite
            int b = int.Parse(Console.ReadLine());  // chislo otgovarqshto za maksimalnata stoinost na deseticite
            int c = int.Parse(Console.ReadLine());  //chislo otgovarqshto za maksimalnata stoinost na edinicite
            for (int first = 2; first <= a; first += 2)
            {
                for (int second = 2; second <= b; second++)
                {
                    if (second > 7)
                    {
                        break;
                    }
                    if (second == 4)
                    {
                        second += 1;
                    }
                    if (second == 6)
                    {
                        second += 1;
                    }

                    for (int thirth = 2; thirth <= c; thirth += 2)
                    {
                        Console.WriteLine($"{ first} {second} {thirth}");
                    }
                }
            }
        }
    }
}
