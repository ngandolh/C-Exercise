using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1679_MaxNumberK_SumPairs
{
    internal class MaxOperationsSolution
    {
        public int MaxOperations(int[] nums, int k)
        {
            Array.Sort(nums);
            int count = 0;
            int left = 0, run = nums.Length - 1;

            while (left < run)
            {
                int sum = nums[left] + nums[run];
                Console.WriteLine($"nums[{left}]={nums[left]} + nums[{run}]={nums[run]} = {k}");
                if (sum == k)
                {
                    count++;
                    left++;
                    run--;
                }
                else if (sum < k) 
                {
                    left++;
                }
                else
                {
                    run--;
                }
            }
            return count;
        }

        //        for (int i = 0; i<nums.Length - 1; i++)
        //            {
        //                for (int j = 0; j<nums.Length; j++)
        //                {
        //                    if (nums[i] + nums[j] == k)
        //                    {
        //                        Console.WriteLine($"nums[{i}]={nums[i]} + nums[{j}]={nums[j]} = {k}");
        //                        count++;
        //                    }
        //}
        //            }
    }
}
