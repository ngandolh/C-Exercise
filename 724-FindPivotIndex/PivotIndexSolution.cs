using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _724_FindPivotIndex
{
    internal class PivotIndexSolution
    {
        public int PivotIndex(int[] nums)
        {
            //Total sum of the array
            int totalSum = nums.Sum();
            int leftSum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (leftSum == totalSum - leftSum - nums[i])
                {
                    return i;
                }
                else
                {
                    leftSum += nums[i];
                }
            }

            return -1;
        }
    }
}
