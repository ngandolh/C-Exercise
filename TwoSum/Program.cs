public class Solution
{
    //public static void Main(string[] args)
    //{
    //    int[] arr = { 3, 2, 3 };
    //    Solution solution = new Solution();
    //    solution.TwoSum(arr, 6);
    //}
    public int[] TwoSum(int[] nums, int target)
    {
        int sum = 0;
        for (int i = 0; i <= nums.Length; i++)
        {
            for (int y = i + 1; y < nums.Length; y++)
            {
                if (nums[i] + nums[y] == target)
                {
                    return new int[] { i, y };
                }
                return new int[] { };
            }
        }
        return new int[] { };
    }
}