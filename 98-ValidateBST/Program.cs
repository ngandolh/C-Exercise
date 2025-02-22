namespace _98_ValidateBST
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ValidateBSTSolution validateBSTSolution = new ValidateBSTSolution();
            int[] case1 = new int[] { 2, 1, 3 };
            TreeNode root = validateBSTSolution.BuildBST(case1);
            bool result = validateBSTSolution.IsValidBST(root);
            System.Console.WriteLine("Case 1: " + result);

            Console.WriteLine("======================================");

            int[] case2 = new int[] { 5, 1, 4, 0, 0, 3, 6 };
            TreeNode root2 = validateBSTSolution.BuildBSTCase2(case2);
            bool result2 = validateBSTSolution.IsValidBST(root2);
            System.Console.WriteLine("Case 2: " + result2);

            Console.WriteLine("======================================");

            int[] case3 = { 0 };
            TreeNode root3 = validateBSTSolution.BuildBST(case3);
            bool result3 = validateBSTSolution.IsValidBST(root3);
            System.Console.WriteLine("Case 3: " + result3);
        }
    }
}
