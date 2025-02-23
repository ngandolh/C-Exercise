namespace _99_RecoverBST
{
    internal class Program
    {
        static void Main(string[] args)
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

                // Mảng test: [3, 1, 4, 2]
                // Cây BST được xây dựng từ mảng này có dạng:
                //       3
                //      / \
                //     1   4
                //        /
                //       2
                // Ở đây, node 2 được chèn vào bên trái của 4 (do 2 < 4) nhưng lại nằm trong cây con bên phải của 3 (do 2 < 3),
                // làm cho cây không phải là BST đúng.
                int[] arr = { 3, 1, 4, 2 };
                TreeNode root = solution.BuildBST(arr);

                Console.WriteLine("Inorder traversal của BST trước khi khôi phục:");
                InorderPrint(root);
                Console.WriteLine();

                // Khôi phục BST bằng cách tìm và hoán đổi 2 node bị lỗi
                solution.RecoverTree(root);

                Console.WriteLine("Inorder traversal của BST sau khi khôi phục:");
                InorderPrint(root);
                Console.WriteLine();

                // Kiểm tra hàm Search
                int searchValue = 2;
                TreeNode found = solution.Search(root, searchValue);
                if (found != null)
                {
                    Console.WriteLine($"Tìm thấy node có giá trị {searchValue}.");
                }
                else
                {
                    Console.WriteLine($"Không tìm thấy node có giá trị {searchValue}.");
                }

                // Giữ cửa sổ console mở
                Console.ReadLine();
            }
        }
    }
}
