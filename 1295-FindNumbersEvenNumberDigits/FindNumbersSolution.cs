using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1295_FindNumbersEvenNumberDigits
{
    internal class FindNumbersSolution
    {
        public int FindNumbers(int[] nums)
        {
            int count = 0;
            foreach(int num in nums)
            {
                if (num.ToString().Length % 2 == 0)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
