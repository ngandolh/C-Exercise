namespace _2215_FindDifferenceTwoArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FindDifferenceSolution findDifferenceSolution = new FindDifferenceSolution();
            int[] nums1 = { 1, 2, 3 };
            int[] nums2 = { 2, 4, 6 };
            IList<IList<int>> result = findDifferenceSolution.FindDifference(nums1, nums2); //Expected [[1,3],[4,6]]
            Console.WriteLine("Result case 1:" );
            foreach (var list in result)
            {
                Console.WriteLine("List:");
                foreach (var item in list)
                {
                    Console.WriteLine(item);
                }
            }

            Console.WriteLine("======================");

            nums1 = new int[] { 1, 2, 3, 3 };
            nums2 = new int[] { 1, 1, 2, 2 };
            result = findDifferenceSolution.FindDifference(nums1, nums2); //Expected [[3],[]]
            Console.WriteLine("Result case 2:");
            foreach (var list in result)
            {
                foreach (var item in list)
                {
                    Console.Write(item);
                }
            }
        }
    }
}
