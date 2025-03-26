using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _283_MoveZeroes
{
    internal class MoveZeroesSolution
    {
        public void MoveZeroes(int[] nums)
        {
            if(nums.Length == 1) { return; }

            for(int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    for (int j = i + 1; j < nums.Length; j++)
                    {
                        if (nums[j] != 0)
                        {
                            nums[i] = nums[j];
                            nums[j] = 0;
                            Console.WriteLine(string.Join(", ", nums));
                            break;
                        }
                    }
                }
            }
        }

        public void MoveZeroes2(int[] nums)
        {
            int n = nums.Length;
            int p = 0, i = 0;

            while (i < n)
            {
                if (nums[i] != 0)
                {
                    nums[i - p] = nums[i];
                    Console.WriteLine(string.Join(", ", nums));
                }
                else
                {
                    p++;
                }
                i++;
            }

            i = n - p;
            while(i < n)
            {
                nums[i++] = 0;
            }
        }
    }
}
