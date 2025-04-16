namespace _2537_CountNumberGoodSubarrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CountGoodSolution countGoodSolution = new CountGoodSolution();
            int[] nums1 = { 3, 1, 4, 3, 2, 2, 4 };
            int k1 = 2;
            long result1 = countGoodSolution.CountGood(nums1, k1);
            Console.WriteLine($"Result for nums1: {result1}"); // Expected output: 4

            int[] nums2 = { 1, 1, 1, 1, 1 };
            int k2 = 10;
            long result2 = countGoodSolution.CountGood(nums2, k2);
            Console.WriteLine($"Result for nums2: {result2}"); // Expected output: 1
        }
    }
}
