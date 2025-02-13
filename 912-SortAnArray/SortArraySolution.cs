using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _912_SortAnArray
{
    public class SortArraySolution
    {
        //Bubble Sort
        public int[] SortArray(int[] nums)
        {
            var n = nums.Length;
            for(int i = 0; i < n - 1; i++)
            {
                for(int j = 0; j < n - i - 1; j++)
                {
                    if (nums[j] > nums[j + 1])
                    {
                        var temp = nums[j];
                        nums[j] = nums[j + 1];
                        nums[j + 1] = temp;
                    }
                }
            }
            return nums;
        }

        //
    }
}
