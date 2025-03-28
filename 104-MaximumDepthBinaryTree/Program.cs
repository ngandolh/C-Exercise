namespace _104_MaximumDepthBinaryTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MaxDepthSolution maxDepthSolution = new MaxDepthSolution();
            TreeNode root = new TreeNode(3);
            root.left = new TreeNode(9);
            root.right = new TreeNode(20);
            root.right.left = new TreeNode(15);
            root.right.right = new TreeNode(7);
            int result = maxDepthSolution.MaxDepth(root);
            Console.WriteLine(result);

            Console.WriteLine("=========================================");
            TreeNode root2 = new TreeNode(1);
            root2.right = new TreeNode(2);
            int result2 = maxDepthSolution.MaxDepth(root2);
            Console.WriteLine(result2);
        }
    }
}
