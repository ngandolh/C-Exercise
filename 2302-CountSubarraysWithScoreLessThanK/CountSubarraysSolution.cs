using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2302_CountSubarraysWithScoreLessThanK
{
    internal class CountSubarraysSolution
    {
        public long CountSubarrays(int[] nums, long k)
        {
            //Approve subarray
            long result = 0;
            int n = nums.Length;
            int start = 0;
            long windowSum = 0;

            for(int end = 0; end < n; end++)
            {
                windowSum += nums[end];
                //if (windowSum * count < k)
                //{
                //    result++;
                //}

                //When it's satisfy the conditions , we need to shrink the window from the left side
                while (start <= end && windowSum * (end - start + 1) >= k)
                {
                    windowSum -= nums[start];
                    start++;
                }

                result += (end - start + 1);
            }

            return result;
        }
    }
}
