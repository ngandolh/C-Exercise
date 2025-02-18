namespace _108_ConvertSortedArrayBST
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] case1 = { -10, -3, 0, 5, 9 };
            ConvertArraySolution solution = new ConvertArraySolution();
            TreeNode result1 = solution.SortedArrayToBST(case1);
            solution.PrintInOrder(result1);


            Console.WriteLine("====================================");

            int[] case2 = { 1, 3 };
            TreeNode result2 = solution.SortedArrayToBST(case2);
            solution.PrintInOrder(result2);
        }
    }
}
