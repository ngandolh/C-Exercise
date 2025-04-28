using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlidingWindow
{
    internal class MaximumAverageSubarraySolution
    {
        public double MaximumAverageSubarray(int[] nums, int k)
        {
            int start = 0;
            double maxAverage = double.MinValue, windowAverage = 0;

            for (int end = 0; end < nums.Length; end++)
            {
                windowAverage += nums[end];
                if (end >= k - 1)
                {
                    double currentAvarage = windowAverage / k;
                    maxAverage = Math.Max(maxAverage, currentAvarage) * 1.0;
                    windowAverage -= nums[start];
                    start++;
                }
            }

            return maxAverage;
        }
    }
}
