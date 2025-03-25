using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _238_ProductArrayExceptSelf
{
    internal class ProductExceptSelfSolution
    {
        public int[] ProductExceptSelf(int[] nums)
        {
            
            if (nums == null || nums.Length == 0)
            {
                return new int[0];
            }

            int n = nums.Length;
            int[] result = new int[n];
            int[] left = new int[n];
            left[0] = 1;
            for (int i = 1; i < n; i++)
            {
                left[i] = left[i- 1] * nums[i - 1];
            }

            int right = 1;
            for(int i = n - 1; i >= 0; i--)
            {
                result[i] = left[i] * right;
                right *= nums[i];
            }

            return result;
        }
    }
}
