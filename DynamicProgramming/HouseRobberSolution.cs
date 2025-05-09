using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicProgramming
{
    internal class HouseRobberSolution
    {
        public int Rob(int[] nums)
        {
            if(nums.Length <= 2)
            {
                return nums.Length;
            }

            int[] dp = new int[nums.Length];
            dp[0] = nums[0];
            dp[1] = Math.Max(nums[0], nums[1]);

            for (int i = 2; i < nums.Length; i++)
            {
                Console.WriteLine("i: " + i + " dp[i - 1]: " + dp[i - 1] + " dp[i - 2]: " + dp[i - 2] + " nums[i]: " + nums[i]);
                dp[i] = Math.Max(dp[i - 1], dp[i - 2] + nums[i]);
            }

            return dp[nums.Length - 1];
        }
    }
}
