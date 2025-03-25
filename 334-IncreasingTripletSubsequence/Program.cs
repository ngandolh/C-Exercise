namespace _334_IncreasingTripletSubsequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IncreasingTripletSolution increasingTripletSolution = new IncreasingTripletSolution();
            //int[] nums1 = { 1, 2, 3, 4, 5 };
            //Console.WriteLine("Case 1");
            //bool result1 = increasingTripletSolution.IncreasingTriplet(nums1);
            //System.Console.WriteLine(result1); // True

            //Console.WriteLine("=====================================");

            //int[] nums2 = { 5, 4, 3, 2, 1 };
            //Console.WriteLine("Case 2");
            //bool result2 = increasingTripletSolution.IncreasingTriplet(nums2);
            //System.Console.WriteLine(result2); // False

            //Console.WriteLine("=====================================");

            Console.WriteLine("Case 3");
            int[] nums3 = { 20, 100, 10, 12, 5, 13 };
            bool result3 = increasingTripletSolution.IncreasingTriplet(nums3);
            System.Console.WriteLine(result3); // True
        }
    }
}
