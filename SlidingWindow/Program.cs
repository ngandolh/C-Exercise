namespace SlidingWindow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MaximumSumSubarraySizeKSolution maximumSumSubarraySizeKSolution = new MaximumSumSubarraySizeKSolution();
            int[] nums = { 2, 1, 5, 1, 3, 2 };
            int k = 2;
            int result = maximumSumSubarraySizeKSolution.MaximumSumSubarraySize(nums, k);
            Console.WriteLine($"Maximum sum of subarray of size {k} is: {result}");
        }
    }
}
