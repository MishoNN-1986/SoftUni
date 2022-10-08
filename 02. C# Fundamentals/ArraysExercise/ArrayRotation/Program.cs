using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int[] tempArr = new int[arr.Length];
                for (int j = 0; j < tempArr.Length; j++)
                {
                    if (j + 1 >= tempArr.Length)
                    {
                        tempArr[j] = arr[0];
                    }
                    else
                    {
                        tempArr[j] = arr[j + 1];
                    }
                }
                arr = tempArr;
            }
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
