using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeTheWedding
{
    class Program
    {
        static void Main(string[] args)
        {
            int man = int.Parse(Console.ReadLine());
            int woman = int.Parse(Console.ReadLine());
            int maxTables = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 1; i <= man; i++)
            {
                for (int j = 1; j <= woman; j++)
                {
                    count++;
                    if (count <= maxTables)
                    {
                        Console.Write($"({i} <-> {j}) ");
                    }
                }
            }
        }
    }
}
