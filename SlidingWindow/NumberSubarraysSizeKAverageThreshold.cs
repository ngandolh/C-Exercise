using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlidingWindow
{
    internal class NumberSubarraysSizeKAverageThreshold
    {
        public int NumOfSubarrays(int[] arr, int k, int threshold)
        {
            int count = 0, start = 0, windowSum = 0, n = arr.Length;
            int thresholdSum = k * threshold;

            for (int end = 0; end < n; end++)
            {
                windowSum += arr[end];
                if (end >= k - 1)
                {
                    if (windowSum >= thresholdSum)
                    {
                        count++;
                    }
                    windowSum -= arr[start];
                    start++;
                }
            }
            return count;
        }

        public int NumOfSubarraysBruteForce(int[] arr, int k, int threshold)
        {
            int count = 0;
            int n = arr.Length;
            int windowSum = 0;
            int thresholdSum = k * threshold;
            for (int i = 0; i < n; i++)
            {
                windowSum += arr[i];
                if (i + 1>= k)
                {
                    if (windowSum >= thresholdSum)
                    {
                        count++;
                    }
                    windowSum -= arr[i - k + 1];
                }
            }
            return count;
        }
    }
}
