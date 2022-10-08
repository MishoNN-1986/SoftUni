using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergingLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int largerListCount = Math.Max(firstNumbers.Count, secondNumbers.Count);
            List<int> mergerList = new List<int>(firstNumbers.Count + secondNumbers.Count);

            for (int i = 0; i < largerListCount; i++)
            {
                if (i < firstNumbers.Count)
                {
                    mergerList.Add(firstNumbers[i]);
                }
                if (i < secondNumbers.Count)
                {
                    mergerList.Add(secondNumbers[i]);
                }
            }
            Console.WriteLine(string.Join(" ", mergerList));
        }
    }
}
