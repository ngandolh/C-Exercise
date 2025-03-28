namespace _450_DeleteNodeBST
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DeleteNodeSolution deleteNodeSolution = new DeleteNodeSolution();
            TreeNode root = new TreeNode(5);
            root.left = new TreeNode(3);
            root.right = new TreeNode(6);
            root.left.left = new TreeNode(2);
            root.left.right = new TreeNode(4);
            root.right.right = new TreeNode(7);

            Console.WriteLine("BST before deleting node:");
            deleteNodeSolution.PrintTree(root);
            Console.WriteLine("\n=====================================");

            TreeNode result = deleteNodeSolution.DeleteNode(root, 0);

            Console.WriteLine("BST after deleting node:");
            deleteNodeSolution.PrintTree(result);
            Console.WriteLine("\n=====================================");
        }
    }
}
