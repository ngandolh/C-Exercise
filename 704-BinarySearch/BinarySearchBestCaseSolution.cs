using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _704_BinarySearch
{
    public class BinarySearchBestCaseSolution
    {
        public int Search(int[] nums, int target)
        {
            //given an array and a target
            //find the target
            //if targer found return its index
            //if target is not found return -1

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == target)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
