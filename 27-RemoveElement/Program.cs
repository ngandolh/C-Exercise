using System.Diagnostics;

namespace _27_RemoveElement
{
    internal class Solution
    {
        //Phần tham chiếu(reference) đến mảng nums được lưu trong stack.
        //Dữ liệu thực tế của mảng(các giá trị số nguyên) được lưu trong heap.
        //RemoveElement2 will change direct in heap memory
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            int[] nums1 = { 3, 2, 2, 3 };
            int value1 = 2;
            var result1 = new Solution().RemoveElement(nums1, value1);
            Console.WriteLine(String.Join(",", result1));

            int[] nums2 = { 0, 1, 2, 2, 3, 0, 4, 2 };
            int value2 = 2;
            var result2 = new Solution().RemoveElement2(nums2, value2);

            Console.WriteLine($"Remove [] int: {String.Join(",", nums2.Take(result2))}");

            stopwatch.Stop();
            Console.WriteLine($"Time elapsed: {stopwatch.Elapsed.TotalMilliseconds} ms");
        }

        public int[] RemoveElement(int[] nums, int val)
        {
            int index = Array.IndexOf(nums, val);
            //nums = nums.Where((e, i) => i != index).ToArray();
            nums = nums.Where(e => e != val).ToArray();
            return nums;
        }

        public int RemoveElement2(int[] nums, int val)
        {
            int index = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[index] = nums[i];
                    index++;
                }
            }
            return index;
        }
    }
}
