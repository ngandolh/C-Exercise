namespace _700_SearchBST
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SearchBSTSolution searchBSTSolution = new SearchBSTSolution();
            int[] case1 = { 4, 2, 7, 1, 3 };
            int val1 = 2;
            TreeNode root = searchBSTSolution.BuildBST(case1, 0, case1.Length - 1);
            TreeNode result = searchBSTSolution.SearchBST(root, val1);
            searchBSTSolution.PrintTree(result);

            Console.WriteLine("======================================");

            int val2 = 5;
            TreeNode result2 = searchBSTSolution.SearchBST(root, val2);
            searchBSTSolution.PrintTree(result2);


        }
    }
}
