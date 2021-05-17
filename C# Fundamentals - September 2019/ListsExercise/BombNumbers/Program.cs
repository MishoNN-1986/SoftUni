using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] specialNumberWithPower = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == specialNumberWithPower[0])
                {
                    int start = Math.Max(0, i - specialNumberWithPower[1]);
                    int stop = Math.Min(numbers.Count - 1, i + specialNumberWithPower[1]);
                    for (int j =start; j <= stop; j++)
                    {
                        numbers.RemoveAt(start);
                    }
                    i = start - 1; //!!!
                }
            }
            int sum = 0;
            for (int i = 0; i < numbers.Count; i++)  // numbers.Sum()
            {
                sum += numbers[i];
            }
            Console.WriteLine(sum);
        }
    }
}
