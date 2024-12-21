using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.QuickSort
{
    internal class QuickSort
    {
        public static void QuickSortAlgorithm(int[] arr, int left, int right)
        {
            //How to find the median pivot in array.
            int pivot = (int) Math.Ceiling(arr.Length/2.0);
            for (int i = left; i < right; i++)
            {
                if (arr[i] < arr[pivot])
                {
                    if (arr[i] > arr[right])
                    {
                        swap(arr[i], arr[right]);
                    }
                }
            }
        }

        private static void Swap(int i, int j)
        {
            int temp = i;
            i = j;
            temp = j;
        }

        static void Main()
        {
            int[] arry = { 52, 14, 67, 71, 42, 38, 39, 40, 96 };
        }
    }
}
