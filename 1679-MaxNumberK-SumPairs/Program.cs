namespace _1679_MaxNumberK_SumPairs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MaxOperationsSolution maxOperationsSolution = new MaxOperationsSolution();
            //int[] nums = new int[] { 1, 2, 3, 4 }; // Output: 2
            //int k = 5;
            //int result = maxOperationsSolution.MaxOperations(nums, k);
            //Console.WriteLine(result);

            //Console.WriteLine("======================================");
            //int[] nums2 = new int[] { 3, 1, 3, 4, 3 }; // Output: 1
            //int k2 = 6;
            //int result2 = maxOperationsSolution.MaxOperations(nums2, k2);
            //Console.WriteLine(result2);

            Console.WriteLine("======================================");
            int[] nums3 = new int[] { 4, 4, 1, 3, 1, 3, 2, 2, 5, 5, 1, 5, 2, 1, 2, 3, 5, 4 }; // Output: 2
            int k3 = 2;
            int result3 = maxOperationsSolution.MaxOperations(nums3, k3);
            Console.WriteLine(result3);
        }
    }
}
