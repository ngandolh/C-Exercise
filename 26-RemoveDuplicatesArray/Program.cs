using System.Net.Http.Headers;

namespace _26_RemoveDuplicatesArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 0, 0, 1, 1, 1, 1, 2, 2, 3, 4, 5 };
            var result = RemoveDuplicates(nums);
            Console.WriteLine(result);
        }

        public static int[] RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0)
                return new int[0];

            Array.Sort(nums);

            List<int> list = new List<int>(nums);
            for (int i = 0; i < nums.Length; i++)
            {
                if(nums[i] != nums[i - 1])
                {
                    list.Add(nums[i]);
                }
            }
            return list.ToArray();
        }
    }
}
