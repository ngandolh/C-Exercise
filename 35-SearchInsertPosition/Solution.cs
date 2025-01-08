using System.Linq;

namespace _35_SearchInsertPosition
{
    internal class Solution
    {
        //Example 1:
        //Input: nums = [1, 3, 5, 6], target = 5
        //Output: 2

        //Example 2:
        //Input: nums = [1, 3, 5, 6], target = 2
        //Output: 1

        //Example 3:
        //Input: nums = [1, 3, 5, 6], target = 7
        //Output: 4
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public int SearchInsert(int[] nums, int target)
        {
            int result = 0;
            if (nums.Contain(target))
            {
                result = nums.IndexOf(target);
            }

        }
    }
}
