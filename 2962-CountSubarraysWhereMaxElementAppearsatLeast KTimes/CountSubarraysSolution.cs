using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2962_CountSubarraysWhereMaxElementAppearsatLeast_KTimes
{
    internal class CountSubarraysSolution
    {
        public long CountSubarrays(int[] nums, int k)
        {
            int start = 0, countMax = 0;
            long result = 0;

            //1. Define the max value in the current window
            int maxValue = nums.Max();

            for (int end = 0; end < nums.Length; end++)
            {
                //2. Check if the current number is the max value
                if (nums[end] == maxValue)
                {
                    countMax++;
                }

                while (countMax >= k)
                {
                    //3. If the count of max value is greater than or equal to k, we can count the subarrays
                    result += nums.Length - end;

                    //4. Move the start pointer to the right
                    if (nums[start] == maxValue)
                    {
                        countMax--;
                    }
                    start++;
                }
            }

            return result;
        }
    }
}
