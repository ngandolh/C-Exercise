using System.Net.Http.Headers;

namespace _26_RemoveDuplicatesArray
{
    internal class Solution
    {
        static void Main(string[] args)
        {
            int[] nums = { 0, 0, 1, 1, 1, 1, 2, 2, 3, 4, 5 };
            var result = RemoveDuplicates(nums);

            int[] nums2 = { 1, 1, 2 };
            var result2 = RemoveDuplicates(nums2);

            Console.WriteLine(string.Join(", ", result));
            Console.WriteLine(string.Join(", ", result2));
        }

        public static int[] RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0)
                return new int[0];

            Array.Sort(nums);

            List<int> list = new List<int>();
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] != nums[i - 1])
                {
                    list.Add(nums[i]);
                }
            }
            return list.ToArray();
        }
    }
}
