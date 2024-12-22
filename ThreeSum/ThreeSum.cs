namespace ThreeSum
{
    internal class ThreeSumSolution
    {
        static void Main(string[] args)
        {
            int[] nums = { -1, 0, 1, 2, -1, -4 };

            var results = new ThreeSumSolution().ThreeSum(nums);
            foreach (var combination in results)
            {
                Console.WriteLine(string.Join(", ", combination));
            }
        }

        public IList<IList<int>> ThreeSum(int[] nums)
        {
            int target = 0;
            IList<IList<int>> result = new List<IList<int>>();
            if (nums.Length < 3)
            {
                return result;
            }

            Array.Sort(nums);

            for (int i = 0; i < nums.Length - 2; i++)
            {
                //Ignore duplicate value
                if (i > 0 && nums[i] == nums[i - 1]) continue;

                int left = i + 1;
                int right = nums.Length - 1;

                while (left < right)
                {
                    //When the total exceeds the limit of int, resutl will is negative
                    long sum = (long)nums[i] + nums[left] + nums[right];

                    if (sum == target)
                    {
                        result.Add(new List<int> { nums[i], nums[left], nums[right] });

                        while (left < right && nums[left] == nums[left + 1])
                            left++;
                        while (left < right && nums[right] == nums[right - 1])
                            right--;

                        left++;
                        right--;
                    }
                    else if (sum < target)
                    {
                        left++;
                    }
                    else
                    {
                        right--;
                    }
                }
            }
            return result;
        }
    }
}
