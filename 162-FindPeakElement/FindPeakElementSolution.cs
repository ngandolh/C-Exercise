using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _162_FindPeakElement
{
    internal class FindPeakElementSolution
    {
        //Input: nums = [1, 2, 3, 1]
        //Output: 2
        //Explanation: 3 is a peak element and your function should return the index number 2.
        public int FindPeakElement(int[] nums)
        {
            if(nums.Length == 0)
            {
                return 0;
            }

            if (nums.Length > 0)
            {
                var num = nums.Max();
                return Array.IndexOf(nums, num);

            }
            return -1;
        }

        public int FindPeakElement2(int[] nums)
        {
            int n = nums.Length;
            int low = 0, high = nums.Length - 1;

            while (low < high)
            {
                int mid = low + (high - low) / 2;
                Console.WriteLine($"mid: {mid} - nums[mid] = {nums[mid]} - nums[mid+1] = {nums[mid+1]}");
                if (nums[mid] < nums[mid + 1])
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid;
                }
            }
            return low;
        }
    }
}
