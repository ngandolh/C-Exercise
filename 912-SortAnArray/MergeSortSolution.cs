using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _912_SortAnArray
{
    public class MergeSortSolution
    {
        public static void MergeSort(int[] array, int left, int right)
        {
            if (left < right)
            {
                int mid = left + (right - left) / 2;

                // Đệ quy sắp xếp nửa trái
                MergeSort(array, left, mid);

                // Đệ quy sắp xếp nửa phải
                MergeSort(array, mid + 1, right);

                // Trộn hai nửa đã sắp xếp
                Merge(array, left, right, mid);
            }
        }

        public static void Merge(int[] array, int left, int right, int mid)
        {
            //Define the size of the two subarrays
            int n1 = mid - left + 1;
            int n2 = right - mid;

            //Create two temporary arrays
            int[] leftArray = new int[n1];
            int[] rightArray = new int[n2];

            //Copy the data to the temporary arrays
            for (int i = 0; i < n1; i++)
            {
                leftArray[i] = array[left + i];
            }
            for (int j = 0; j < n2; j++)
            {
                rightArray[j] = array[mid + 1 + j];
            }

            //Merge the temporary arrays
            int iIndex = 0, jIndex = 0, k = left;
            while (iIndex < n1 && jIndex < n2)
            {
                if (leftArray[iIndex] <= rightArray[jIndex])
                {
                    array[k] = leftArray[iIndex];
                    iIndex++;
                }
                else
                {
                    array[k] = rightArray[jIndex];
                    jIndex++;
                }
                k++;
            }

            //Copy the remaining elements of leftArray[], if there are any
            while(iIndex < n1)
            {
                array[k] = leftArray[iIndex];
                iIndex++;
                k++;
            }

            //Copy the remaining elements of rightArray[], if there are any
            while (jIndex < n2)
            {
                array[k] = rightArray[jIndex];
                jIndex++;
                k++;
            }
        }
    }
}
