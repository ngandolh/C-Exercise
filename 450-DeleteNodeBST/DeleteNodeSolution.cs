using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _450_DeleteNodeBST
{
    internal class DeleteNodeSolution
    {
        public TreeNode DeleteNode(TreeNode root, int key)
        {
            //Find the node = key
            if (root == null) return null;

            //Case 1: key is leaf nodea
            //Case 2: key is single child node
            //Case 3: key is two children node

            if (key < root.val)
            {
                root.left = DeleteNode(root.left, key);
            }
            else if (key > root.val)
            {
                root.right = DeleteNode(root.right, key);
            }
            else
            {
                if (root.left == null) return root.right;
                if (root.right == null) return root.left;

                //Case 3: key is two children node
                TreeNode minNode = FindMin(root.right); //4
                Console.WriteLine("Min Node: " + minNode.val);
                root.val = minNode.val; //change value = 3 to 4 
                //TreeNode: 5, 4, 6, 2, 4, 7
                root.right = DeleteNode(root.right, minNode.val); //Delete 4
            }

            return root;
        }

        public TreeNode FindMin(TreeNode node)
        {
            while (node.left != null) node = node.left;
            return node;
        }

        public void PrintTree(TreeNode root)
        {
            if (root == null)
            {
                return;
            }

            Console.WriteLine(root.val + " ");
            PrintTree(root.left);
            PrintTree(root.right);
        }
    }
}
