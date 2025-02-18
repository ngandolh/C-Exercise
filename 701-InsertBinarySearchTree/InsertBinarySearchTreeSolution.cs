using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace _701_InsertBinarySearchTree
{
    //https://leetcode.com/problems/insert-into-a-binary-search-tree/
    public class InsertBinarySearchTreeSolution
    {
        public TreeNode InsertIntoBST(TreeNode root, int val)
        {
            if (root == null) return new TreeNode(val);
            if (val == root.val)
            {
                return root;
            }

            if (val < root.val)
            {
                root.left = InsertIntoBST(root.left, val);
            }
            else
            {
                root.right = InsertIntoBST(root.right, val);
            }
            return root;
        }

        public void PrintInOrder(TreeNode root)
        {
            if (root == null) return;

            PrintInOrder(root.left);
            Console.Write(root.val + " ");
            PrintInOrder(root.right);
        }

        public TreeNode BuildBST(int?[] values)
        {
            if (values == null || values.Length == 0 || values[0] == null)
                return null;

            TreeNode root = new TreeNode(values[0].Value);
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            int i = 1;
            while (i < values.Length)
            {
                TreeNode current = queue.Dequeue();

                if (values[i] != null) 
                {
                    current.left = new TreeNode(values[i].Value);
                    queue.Enqueue(current.left);
                }
                i++;

                if (i < values.Length && values[i] != null) 
                {
                    current.right = new TreeNode(values[i].Value);
                    queue.Enqueue(current.right);
                }
                i++;
            }

            return root;
        }
    }
}
