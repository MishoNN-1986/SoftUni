﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _10._Implement_Binary_Search
{
    public class BinarySearch
    {
        public static int IndexOf(int[] arr, int key)
        {
            int lo = 0;
            int hi = arr.Length - 1;

            while (lo <= hi)
            {
                int mid = lo + (hi - lo) / 2;

                if (key < arr[mid])
                {
                    hi = mid - 1;
                }
                else if (key > arr[mid])
                {
                    lo = mid + 1;
                }
                else
                {
                    return mid;
                }
            }

            return -1;
        }
    }
}
