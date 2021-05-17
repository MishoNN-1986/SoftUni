using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int firstSum = 0;
            int secondSum = 0;
            int count = 0;
            if (arr.Length == 1)
            {
                Console.WriteLine(0);
                return;
            }
            if (arr.Length == 2)
            {
                Console.WriteLine("no");
                return;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    firstSum += arr[j];
                    count++;
                }
                for (int k = arr.Length - 1; k > i; k--)
                {
                    secondSum += arr[k];
                }
                if (firstSum == secondSum)
                {
                    Console.WriteLine(count);
                    return;
                }
                else
                {
                    count = 0;
                    firstSum = 0;
                    secondSum = 0;
                }
            }
            if (firstSum == 0)
            {
                Console.WriteLine("no");
            }
        }
    }
}
