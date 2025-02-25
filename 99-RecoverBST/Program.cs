namespace _99_RecoverBST
{
    internal class Program
    {

        // Hàm duyệt inorder để in ra các giá trị của cây
        static void InorderPrint(TreeNode root)
        {
            if (root == null) return;
            InorderPrint(root.left);
            Console.Write(root.val + " ");
            InorderPrint(root.right);
        }

        static void Main(string[] args)
        {
            RecoverBSTSolution solution = new RecoverBSTSolution();

            // Ví dụ: Tạo cây thủ công theo mẫu đầu vào [3, 1, 4, null, null, 2]
            // Cây được biểu diễn như sau:
            //         3
            //        / \
            //       1   4
            //          /
            //         2
            //
            // Ở đây, cây không hợp lệ vì 2 < 3 nhưng nằm ở nhánh phải của 3.
            // Sau khi phục hồi, ta mong đợi cây có dạng:
            //         2
            //        / \
            //       1   4
            //          /
            //         3
            //
            // Với inorder sau khi phục hồi sẽ là: 1 2 3 4

            TreeNode root = new TreeNode(3);
            root.left = new TreeNode(1);
            root.right = new TreeNode(4);
            root.right.left = new TreeNode(2);

            Console.WriteLine("Inorder traversal của cây trước khi phục hồi:");
            InorderPrint(root);
            Console.WriteLine();

            // Gọi hàm phục hồi BST
            solution.RecoverTree(root);

            Console.WriteLine("Inorder traversal của cây sau khi phục hồi:");
            InorderPrint(root);
            Console.WriteLine();

            // Kiểm tra hàm Search
            int searchValue = 2;
            TreeNode found = solution.Search(root, searchValue);
            Console.WriteLine(found != null
                ? $"Tìm thấy node có giá trị {found.val}."
                : $"Không tìm thấy node có giá trị {searchValue}.");

            // Giữ cửa sổ console mở
            Console.ReadLine();
        }
    }
}
