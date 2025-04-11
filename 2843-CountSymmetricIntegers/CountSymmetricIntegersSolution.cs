using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2843_CountSymmetricIntegers
{
    internal class CountSymmetricIntegersSolution
    {
        public int CountSymmetricIntegers(int low, int high)
        {
            int count = 0;
            for (int x = low; x <= high; x++)
            {
                string s = x.ToString();

                // Check if the length of the number is even
                if (s.Length % 2 != 0)
                {
                    continue;
                }

                int n = s.Length / 2;

                int sum1 = 0, sum2 = 0;

                // Calculate the sum of the first half and the second half
                for (int i = 0; i < n; i++)
                {
                    sum1 += s[i] - '0';
                }

                for (int i = n; i < 2 * n; i++)
                {
                    sum2 += s[i] - '0';
                }

                // Check if the two sums are equal
                if (sum1 == sum2)
                {
                    count++;
                }
            }

            return count++;
        }
    }
}
