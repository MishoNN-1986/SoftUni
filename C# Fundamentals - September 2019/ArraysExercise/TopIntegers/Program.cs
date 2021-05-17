using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int maxNum = int.MinValue;
            //int count = 0;
            for (int j = 0; j < arr.Length; j++)
            {
                for (int i = arr.Length - 1; i > j; i--)
                {
                    if (arr[i] > maxNum)
                    {
                        //count++;
                        maxNum = arr[i];
                        //Console.Write($"{arr[i]} ");
                    }
                }
                if (arr[j] > maxNum)
                {
                    Console.Write($"{arr[j]} ");
                }
                maxNum = int.MinValue;
            }
        }
    }
}
