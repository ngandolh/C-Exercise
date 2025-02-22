using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _98_ValidateBST
{
    //A valid BST is defined as follows:
    //The left subtree of a node contains only nodes with keys less than the node's key.
    //The right subtree of a node contains only nodes with keys greater than the node's key.
    //Both the left and right subtrees must also be binary search trees.
    public class ValidateBSTSolution
    {
        public bool IsValidBST(TreeNode root)
        {
            var result = Validate(root, long.MinValue, long.MaxValue);
            return result;
        }

        public bool Validate(TreeNode root, long? min, long? max)
        {
            if (root == null)
            {
                return true;
            }

            if ((min != null && root.val <= min) || (max != null && root.val >= max))
            {
                Console.WriteLine("Root value: " + root.val);
                return false;
            }
            return Validate(root.left, min, root.val) && Validate(root.right, root.val, max);
        }

        public TreeNode BuildBST(int[] array)
        {
            TreeNode root = null;
            foreach (int val in array)
            {
                root = Insert(root, val);
            }
            return root;
        }

        public TreeNode Insert(TreeNode root, int val)
        {
            if (root == null)
            {
                return new TreeNode(val);
            }
            if (val < root.val)
            {
                root.left = Insert(root.left, val);
            }
            else
            {
                root.right = Insert(root.right, val);
            }
            return root;
        }

        public TreeNode BuildBSTCase2(int[] array)
        {
            TreeNode root = null;
           root = new TreeNode(5,
                new TreeNode(1),  
                new TreeNode(4, 
                    new TreeNode(3),  
                    new TreeNode(6)  
                )
            );

            return root;
        }
    }
}
