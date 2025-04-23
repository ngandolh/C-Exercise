using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1399_CountLargestGroup
{
    internal class CountLargestGroupSolution
    {
        public int CountLargestGroup(int n)
        {
            //Save the size of each group in a dictionary
            //The key is the digit sum, and the value is the size of the group
            Dictionary<int, int> groupSizes = new Dictionary<int, int>();

            for (int i = 1; i <= n; i++)
            {
                int sum = GetDigitSum(i);
                if (groupSizes.ContainsKey(sum))
                {
                    groupSizes[sum]++;
                }
                else
                {
                    groupSizes[sum] = 1;
                }
            }

            int maxSize = groupSizes.Values.Max();
            int count = groupSizes.Values.Count(size => size == maxSize);

            return count;
        }

        private int GetDigitSum(int num)
        {
            int sum = 0;
            while(num > 0)
            {
                sum += num % 10;
                num /= 10;
            }

            return sum;
        }
    }
}
