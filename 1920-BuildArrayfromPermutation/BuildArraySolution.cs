using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1920_BuildArrayfromPermutation
{
    internal class BuildArraySolution
    {
        public int[] BuildArray(int[] nums)
        {
            int[] build = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                build[i] = nums[nums[i]];
            }
            return build;
        }
    }
}
