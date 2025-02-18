namespace _701_InsertBinarySearchTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            InsertBinarySearchTreeSolution solution = new InsertBinarySearchTreeSolution();
            int?[] case1 = { 4, 2, 7, 1, 3};
            int val1 = 5;

            TreeNode root = solution.BuildBST(case1); 
            root = solution.InsertIntoBST(root, val1);

            Console.WriteLine("Cây BST sau khi chèn giá trị " + val1 + ": ");
            solution.PrintInOrder(root);

            Console.WriteLine("==============================================================");

            int?[] case2 = { 40, 20, 60, 10, 30, 50, 70 };
            int val2 = 25;
            TreeNode root2 = solution.BuildBST(case2);
            root2 = solution.InsertIntoBST(root2, val2);
            Console.WriteLine("Cây BST sau khi chèn giá trị " + val2 + ":");
            solution.PrintInOrder(root2);

            Console.WriteLine("==============================================================");

            int?[] case3 = { 4, 2, 7, 1, 3, null, null, null, null, null, null };
            int val3 = 5;
            TreeNode root3 = solution.BuildBST(case3);
            root3 = solution.InsertIntoBST(root3, val3);
            Console.WriteLine("Cây BST sau khi chèn giá trị " + val3 + ":");
            solution.PrintInOrder(root3);
        }
    }
}
