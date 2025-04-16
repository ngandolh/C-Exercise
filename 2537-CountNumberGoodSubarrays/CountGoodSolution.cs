using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2537_CountNumberGoodSubarrays
{
    internal class CountGoodSolution
    {
        public long CountGood(int[] nums, int k)
        {
            Dictionary<int, int> freq = new Dictionary<int, int>();
            long count = 0;
            int pairs = 0;
            int n = nums.Length;
            int left = 0;

            for(int right = 0; right < n; right++)
            {
                int num = nums[right];
                Console.WriteLine($"num: {num} - right: {right}");

                if (!freq.ContainsKey(num))
                {
                    freq[num] = 0;
                }
                pairs += freq[num];
                freq[num]++;

                while (pairs >= k)
                {
                    count += n - right;
                    freq[nums[left]]--;
                    pairs -= freq[nums[left]];
                    left++;
                }
            }
            return count;
        }

        public long CountGood2(int[] nums, int k)
        {
            //Conditions: i < j and arr[i] == arr[j]
            long count = 0;
            int n = nums.Length;

            for(int start = 0; start < n; start++)
            {
                Dictionary<int, int> freq = new Dictionary<int, int>();
                int pairs = 0;

                for(int end = start; end < n; end++)
                {
                    int num = nums[end];
                    if (freq.ContainsKey(num))
                    {
                        pairs += freq[num];
                        freq[num]++;
                    } else
                    {
                        freq[num] = 1;
                    }

                    if (pairs >= k)
                    {
                        count++;
                    }
                }
            }


            return count;
        }
    }
}
