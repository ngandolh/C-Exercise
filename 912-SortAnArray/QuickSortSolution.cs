using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _912_SortAnArray
{
    public class QuickSortSolution
    {
        public int[] SortArray(int[] nums)
        {
            QuickSort(nums, 0, nums.Length - 1);
            return nums;
        }

        public static void QuickSort(int[] array, int leftIndex, int rightIndex)
        {
            var i = leftIndex;
            var j = rightIndex;
            var pivot = array[leftIndex];
            //int mid = leftIndex + (rightIndex - leftIndex) / 2;
            //int pivot = MedianOfThree(array, leftIndex, mid, rightIndex);

            while (i <= j)
            {
                while (array[i] < pivot)
                {
                    i++;
                }

                while (array[j] > pivot)
                {
                    j--;
                }

                if (i <= j)
                {
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                    i++;
                    j--;
                }

                Console.WriteLine("i: " + i + " j: " + j + " pivot: " + pivot + " array[]: " + string.Join(" , ", array));
            }

            if (leftIndex < j)
            {
                QuickSort(array, leftIndex, j);
            }

            if (i < rightIndex)
            {
                QuickSort(array, i, rightIndex);
            }
        }

        private static int MedianOfThree(int[] array, int a, int b, int c)
        {
            if ((array[a] > array[b]) != (array[a] > array[c])) return array[a];
            if ((array[b] > array[a]) != (array[b] > array[c])) return array[b];
            return array[c];
        }
    }
}
