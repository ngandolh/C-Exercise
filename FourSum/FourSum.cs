namespace FourSum
{
    internal class FourSumSolution
    {
        //Example 1:

        //Input: nums = [1, 0, -1, 0, -2, 2], target = 0
        //Output: [[-2,-1,1,2],[-2,0,0,2],[-1,0,0,1]]
        //Example 2:

        //Input: nums = [2, 2, 2, 2, 2], target = 8 
        //Output: [[2, 2, 2, 2]]
        public static void Main(string[] args)
        {
            //Case 1: Done
            //int[] nums = { 1, 0, -1, 0, -2, 2 };
            //int target = 0;

            //Case 2: Done
            //int[] nums = { 2, 2, 2, 2 };
            //int target = 8;

            //Case 3: Done
            //int[] nums = { -2, -1, -1, 1, 1, 2, 2 };
            //int target = 0;

            //Case 4: 
            int[] nums = { 1000000000, 1000000000, 1000000000, 1000000000 };
            int target = -294967296;

            var results = new FourSumSolution().FourSum(nums, target);
            foreach (var combination in results)
            {
                Console.WriteLine(string.Join(", ", combination));
            }
        }


        public IList<IList<int>> FourSum(int[] nums, int target)
        {
            IList<IList<int>> result = new List<IList<int>>();
            if (nums.Length < 4)
            {
                return result;
            }

            Array.Sort(nums);

            for (int i = 0; i < nums.Length - 3; i++)
            {
                //Ignore duplicate value
                if (i > 0 && nums[i] == nums[i - 1]) continue;

                for (int j = i + 1; j < nums.Length - 2; j++)
                {
                    int left = j + 1;
                    int right = nums.Length - 1;

                    //Ignore duplicate value
                    if (j > i + 1 && nums[j] == nums[j - 1]) continue;

                    while (left < right)
                    {
                        //When the total exceeds the limit of int, resutl will is negative
                        long sum = (long)nums[i] + nums[j] + nums[left] + nums[right];

                        if (sum == target)
                        {
                            result.Add(new List<int> { nums[i], nums[j], nums[left], nums[right] });

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
            }
            return result;
        }
    }
}
