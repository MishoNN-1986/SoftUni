using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int outputCount = 0;
            int count = 0;
            int start = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i].ToString() == arr[i + 1].ToString())
                {
                    count++;
                    if (count > outputCount)
                    {
                        outputCount = count;
                        start = i - count;
                    }
                }
                else
                {
                    count = 0;
                }
            }
            for (int j = start + 1; j <= start + outputCount + 1; j++)
            {
                Console.Write(arr[j] + " ");
            }
        }
    }
}
