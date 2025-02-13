using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _912_SortAnArray
{
    public class SelectionSortSolution
    {
        public int[] SortArray(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                var smallestValue = i;
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[j] < nums[smallestValue])
                    {
                        smallestValue = j;
                    }
                    Console.WriteLine("j: " + j + " nums[smallestValue]: " + string.Join(" , ", nums[smallestValue]));
                }
                //Swap the values
                var temp = nums[smallestValue];
                nums[smallestValue] = nums[i];
                nums[i] = temp;

                Console.WriteLine("i: " + i + " nums: " + string.Join(" , ", nums));
                Console.WriteLine("=============================");
            }

            return nums;
        }
    }
}
