namespace _912_SortAnArray
{
    public class InsertSortSolution
    {
        public int[] SortArray(int[] nums)
        {

            for (int i = 0; i < nums.Length; i++)
            {
                //key save Temporary value
                var key = nums[i];
                int j = i - 1;
                while (j >= 0 && nums[j] > key)
                {
                    nums[j + 1] = nums[j]; // duplicate value that need to move
                    j--; // descrease j to check the next value
                }

                //nums = { 86, 13, 60, 73, 52, 40 }
                //i = 5, j = 4 , Result runs this line: { 13, 52, 60, 73, 86, 86 }

                nums[j + 1] = key; // save the value key

                //Result: 13, 40, 52, 60, 73, 86
                Console.WriteLine("i: " + i + " nums: " + string.Join(" , ", nums));
            }
            return nums;
        }
    }
}
