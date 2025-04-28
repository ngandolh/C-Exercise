using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlidingWindow
{
    internal class MaximumSumSubarraySizeKSolution
    {
        public int MaximumSumSubarraySize(int[] nums, int k)
        {
            int start = 0, maxSum = 0, windowSum = 0;

            for (int end = 0; end < nums.Length; end++)
            {
                windowSum += nums[end];
                if (end >= k - 1)
                {
                    maxSum = Math.Max(maxSum, windowSum); // update maxSum if we have a valid window
                    windowSum -= nums[start]; // remove the element going out of the window
                    start++; // move the start of the window
                    //Ex: [4,2,7]
                    //maxSum = 13
                    //windowSum = 13 - 4 = 9
                    //start = 1
                    //for again: up end = 1 -> [2,7,1]
                }
            }
            return maxSum;
        }
    }
}
