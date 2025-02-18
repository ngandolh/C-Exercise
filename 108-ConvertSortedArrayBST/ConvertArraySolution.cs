using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _108_ConvertSortedArrayBST
{
    public class ConvertArraySolution
    {
        public TreeNode SortedArrayToBST(int[] nums)
        {
            TreeNode result = BuildBST(nums, 0, nums.Length - 1);
            return result;
        }

        private TreeNode BuildBST(int[] nums, int left, int right)
        {
            if (left > right) return null;

            int mid = left + (right - left) / 2;
            TreeNode root = new TreeNode(nums[mid]);
            root.left = BuildBST(nums, left, mid - 1);
            root.right = BuildBST(nums, mid + 1, right);

            return root;
        }

        public void PrintInOrder(TreeNode node)
        {
            if (node == null) return;
            PrintInOrder(node.left);
            Console.Write(node.val + " ");
            PrintInOrder(node.right);
        }
    }
}
