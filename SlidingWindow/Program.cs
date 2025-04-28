using System.Diagnostics;

namespace SlidingWindow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();

            //MaximumSumSubarraySizeKSolution maximumSumSubarraySizeKSolution = new MaximumSumSubarraySizeKSolution();
            //int[] nums = { 2, 1, 5, 1, 3, 2 };
            //int k = 2;
            //int result = maximumSumSubarraySizeKSolution.MaximumSumSubarraySize(nums, k);
            //Console.WriteLine($"Maximum sum of subarray of size {k} is: {result}");

            //MaximumAverageSubarraySolution maximumAverageSubarraySolution = new MaximumAverageSubarraySolution();
            //int[] nums = { 1, 12, -5, -6, 50, 3 };
            //int k = 4;
            //double result = maximumAverageSubarraySolution.MaximumAverageSubarray(nums, k);
            //Console.WriteLine($"Maximum average of subarray of size {k} is: {result}"); //Output: 12.75

            //int[] nums2 = { 4, 4, 4, 4 };
            //int k2 = 2;
            //double result2 = maximumAverageSubarraySolution.MaximumAverageSubarray(nums2, k2);
            //Console.WriteLine($"Maximum average of subarray of size {k2} is: {result2}"); //Output: 4.0

            NumberSubarraysSizeKAverageThreshold numberSubarraysSizeKAverageThreshold = new NumberSubarraysSizeKAverageThreshold();
            int[] arr = { 2, 2, 2, 2, 5, 5, 5, 5 };
            int k = 3;
            int threshold = 4;

            stopwatch.Start();
            int result3 = numberSubarraysSizeKAverageThreshold.NumOfSubarrays(arr, k, threshold);
            stopwatch.Stop();
            Console.WriteLine($"Number of subarrays of size {k} with average at least {threshold} is: {result3}"); //Output: 4
            Console.WriteLine($"Elapsed time: {stopwatch.ElapsedMilliseconds} ms");

            stopwatch.Reset();
            stopwatch.Start();
            int result4 = numberSubarraysSizeKAverageThreshold.NumOfSubarraysBruteForce(arr, k, threshold);
            stopwatch.Stop();
            Console.WriteLine($"Number of subarrays of size {k} with average at least {threshold} (Brute Force) is: {result4}"); //Output: 4
            Console.WriteLine($"Elapsed time (Brute Force): {stopwatch.ElapsedMilliseconds} ms");
        }
    }
}
