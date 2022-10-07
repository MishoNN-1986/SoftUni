using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighJump
{
    class Program
    {
        static void Main(string[] args)
        {
            int desiredHeight = int.Parse(Console.ReadLine());
            int countJump = 0;
            for (int i = desiredHeight - 30; i <= desiredHeight; i += 5)
            {
                for (int j = 0; j < 3; j++)
                {
                    int heightJump = int.Parse(Console.ReadLine());
                    countJump++;
                    if (heightJump > i)
                    {
                        break;
                    }
                    else
                    {
                        if (j == 2)
                        {
                            Console.WriteLine($"Tihomir failed at {i}cm after {countJump} jumps.");
                            return;
                        }
                    }
                }
            }
            Console.WriteLine($"Tihomir succeeded, he jumped over {desiredHeight}cm after {countJump} jumps.");
        }
    }
}
