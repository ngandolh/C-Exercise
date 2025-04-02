namespace _724_FindPivotIndex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PivotIndexSolution pivotIndexSolution = new PivotIndexSolution();
            int[] nums = new int[] { 1, 7, 3, 6, 5, 6 };
            int result = pivotIndexSolution.PivotIndex(nums);
            Console.WriteLine(result);

            Console.WriteLine("=====================================");

            int[] nums2 = new int[] { 1, 2, 3 };
            int result2 = pivotIndexSolution.PivotIndex(nums2);
            Console.WriteLine(result2);

            Console.WriteLine("=====================================");

            int[] nums3 = new int[] { -1, -1, -1, -1, -1, 0 };
            int result3 = pivotIndexSolution.PivotIndex(nums3);
            Console.WriteLine(result3);
        }
    }
}
