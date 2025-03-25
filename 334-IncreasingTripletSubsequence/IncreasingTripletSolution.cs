using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;

namespace _334_IncreasingTripletSubsequence
{
    internal class IncreasingTripletSolution
    {
        public bool IncreasingTriplet2(int[] nums)
        {
            int n = nums.Length;
            bool result = false;
            for (int i = 0; i < nums.Length - 2; i++)
            {
                if (i == n) break; 
                if(nums[i] < nums[i + 1] && nums[i + 1] < nums[i + 2])
                {
                    result = true;
                }
            }

            return result;
        }

        public bool IncreasingTriplet3(int[] nums)
        {
            int n = nums.Length;
            bool result = false;

            bool first = false;
            for(int i = 0; i < n; i++)
            {
                int firstElement = nums[i];
                first = nums.Contains(firstElement + 1) && nums.Contains(firstElement + 2);
                Console.WriteLine($"i = {i} 1E = {firstElement} 2E = {firstElement + 1} 3E = {firstElement + 2} first = {first}");
                if (first)
                {
                    break;
                }
            }

            if (!first)
            {
                result = false;
            }

            return result;
        }

        public bool IncreasingTriplet(int[] nums)
        {
            int first = int.MaxValue, second = int.MaxValue;
            Console.WriteLine($"first = {first} second = {second}");
            foreach (int num in nums)
            {
                if (num <= first)
                {
                    first = num; 
                    Console.WriteLine($"first = {first}");
                }
                else if (num <= second)
                {
                    second = num; 
                    Console.WriteLine($"second = {second}");
                }
                //third > second > first
                else
                {
                    return true;
                }
            }

            return false;
        }
    }
}
