using System;
using System.Collections.Generic;
using System.Linq;

namespace Exam
{
    class TrLimit
    {
        public int TrCount;
        public int Sec;

        public TrLimit(int c, int s)
        {
            TrCount = c;
            Sec = s;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            //var dropedIndexes = new List<int>();
            //int previousNum = input[0];
            //int currentNum = 0;

            //TrLimit[] limits2 =
            //{
            //    new TrLimit(3, 1),
            //    new TrLimit(20, 10),
            //    new TrLimit(60, 60),
            //};

            (int TrCount, int Sec)[] limits =  //Tuple types (C# reference)
            {
                (3, 1),
                (20, 10),
                (60, 60)
            };

            int result = 0;
            for (int i = 0; i < input.Count; i++)
            {
                var cur = input[i];

                for (int j = 0; j < limits.Length; j++)
                {
                    var lim = limits[j];

                    if (lim.TrCount <= i)
                    {
                        var prev = input[i - lim.TrCount];
                        if (cur - prev < lim.Sec)
                        {
                            result++;
                            break;
                        }
                    }
                }
            }
            Console.WriteLine(result);

            //for (int i = 1; i < input.Count; i++)
            //{
            //    currentNum = input[i];
            //    if (currentNum == previousNum)
            //    {
            //        dropedIndexes.Add(i);
            //    }
            //    else
            //    {
            //        previousNum = currentNum;
            //    }
            //}
            //if (input.Count > 10)
            //{
            //    for (int j = 20; j < input.Count; j++)
            //    {
            //        int currentElement = input[j];
            //        int prediousElement = input[j - 20];
            //        if (currentElement - prediousElement < 10)
            //        {
            //            if (!dropedIndexes.Contains(j))
            //            {
            //                dropedIndexes.Add(j);
            //            }
            //        }
            //    }
            //}
            //if (input.Count > 60)
            //{
            //    for (int j = 60; j < input.Count; j++)
            //    {
            //        int currentElement = input[j];
            //        int prediousElement = input[j - 60];
            //        if (currentElement - prediousElement < 60)
            //        {
            //            if (!dropedIndexes.Contains(j))
            //            {
            //                dropedIndexes.Add(j);
            //            }
            //        }
            //    }
            //}
            //Console.WriteLine(dropedIndexes.Count);
        }
    }
}
