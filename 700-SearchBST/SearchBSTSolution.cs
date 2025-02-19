using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _700_SearchBST
{
    public class SearchBSTSolution
    {
        public TreeNode SearchBST(TreeNode root, int val)
        {
            if (root == null || root.val == val) return root;

            if (val < root.val)
            {
                return SearchBST(root.left, val);
            }

            return SearchBST(root.right, val);
        }

        public TreeNode BuildBST(int[] nums, int left, int right)
        {
            TreeNode root = null;
            foreach (int num in nums)
            {
                root = InsertIntoBST(root, num);
            }
            return root;
        }

        private TreeNode InsertIntoBST(TreeNode root, int val)
        {
            if (root == null) return new TreeNode(val);

            if (val < root.val)
                root.left = InsertIntoBST(root.left, val);
            else
                root.right = InsertIntoBST(root.right, val);

            return root;
        }

        public TreeNode PrintTree(TreeNode root)
        {
            if (root == null) return null;
            Console.WriteLine(root.val);
            PrintTree(root.left);
            PrintTree(root.right);
            return root;
        }
    }
}
