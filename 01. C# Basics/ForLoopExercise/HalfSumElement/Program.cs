using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalfSumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int biggest = int.MinValue;
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                sum += num;
                if (num > biggest)
                {
                    biggest = num;
                }
            }
            sum = sum - biggest;
            if (biggest == sum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {sum}");
            }
            else
            {
                int dif = Math.Abs(biggest - sum);
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {dif}");
            }
        }
    }
}
