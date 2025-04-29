namespace _2962_CountSubarraysWhereMaxElementAppearsatLeast_KTimes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CountSubarraysSolution countSubarraysSolution = new CountSubarraysSolution();
            int[] nums = { 1, 3, 2, 3, 3 };
            int k1 = 2;
            long result1 = countSubarraysSolution.CountSubarrays(nums, k1);
            Console.WriteLine($"Result for k={k1}: {result1}"); // Expected output: 6
        }
    }
}
