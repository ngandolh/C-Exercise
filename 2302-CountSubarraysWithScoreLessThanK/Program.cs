namespace _2302_CountSubarraysWithScoreLessThanK
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CountSubarraysSolution countSubarraysSolution = new CountSubarraysSolution();
            int[] nums1 = { 2, 1, 4, 3, 5 };
            long k1 = 10;
            long result1 = countSubarraysSolution.CountSubarrays(nums1, k1);
            Console.WriteLine($"Result for nums1: {result1}"); // Expected output: 6
        }
    }
}
