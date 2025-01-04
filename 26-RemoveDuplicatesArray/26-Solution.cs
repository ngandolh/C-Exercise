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

            //Case: Index[0]
            list.Add(nums[0]);
            //Case: for start Index[1]
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] != nums[i - 1])
                {
                    list.Add(nums[i]);
                }
            }
            return list.ToArray();
        }

        public int RemoveDuplicatesInt(int[] nums)
        {
            if (nums.Length == 0) return 0;

            int i = 0; // Con trỏ theo dõi vị trí phần tử không trùng lặp cuối cùng.
             
            for (int j = 1; j < nums.Length; j++)
            {
                if (nums[j] != nums[i])
                { // Nếu tìm thấy phần tử không trùng lặp.
                    i++; // Tăng vị trí lưu trữ.
                    nums[i] = nums[j]; // Ghi đè phần tử mới vào vị trí i.
                }
            }

            return i + 1; // Độ dài của mảng không trùng lặp.
        }
    }
}
