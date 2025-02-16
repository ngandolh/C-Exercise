using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _704_BinarySearch
{
    public class BinarySearchSolution
    {
        public int Search(int[] nums, int target)
        {
            int result = -1;
            for(int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == target)
                {
                    result = Array.IndexOf(nums, target);
                }
            }
            return result;
        }
    }
}
