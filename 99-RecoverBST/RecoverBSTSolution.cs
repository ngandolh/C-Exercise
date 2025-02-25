using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _99_RecoverBST
{
    public class RecoverBSTSolution
    {
        //Input: root = [1, 3, null, null, 2]
        //Output: [3, 1, null, null, 2]
        //Explanation: 3 cannot be a left child of 1 because 3 > 1. Swapping 1 and 3 makes the BST valid.

        //Input: root = [3, 1, 4, null, null, 2]
        //Output: [2, 1, 4, null, null, 3]
        //Explanation: 2 cannot be in the right subtree of 3 because 2 < 3. Swapping 2 and 3 makes the BST valid.

        private TreeNode first, second, prev;
        public void RecoverTree(TreeNode root)
        {
            first = second = prev = null;

            InorderTraverse(root);

            if(first != null && second != null)
            {
                int temp = first.val;
                first.val = second.val;
                second.val = temp;
            }
        }

        public void InorderTraverse(TreeNode root)
        {
            if (root == null)
            {
                return;
            }

            if (prev != null && root.val < prev.val)
            {
                if (first == null) first = prev;

                second = root;
            }

            prev = root;

            InorderTraverse(root.right);
        }

        public TreeNode Search(TreeNode root, int value)
        {
            if (root == null) return null;
            if (root.val == value) return root;
            if (value < root.val) return Search(root.left, value);
            return Search(root.right, value);
        }

        public TreeNode InsertBST(TreeNode root, int value)
        {
            if (root == null) return new TreeNode(value);
            if(value < root.val)
            {
                root.left = InsertBST(root.left, value);
            }
            else
            {
                root.right = InsertBST(root.right, value);
            }

            return root;
        }

        public TreeNode BuildBST(int[] values)
        {
            TreeNode root = null;
            foreach (var value in values)
            {
                root = InsertBST(root, value);
            }
            return root;
        }
    }
}
