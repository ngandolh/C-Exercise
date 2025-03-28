using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _104_MaximumDepthBinaryTree
{
    internal class MaxDepthSolution
    {
        public int MaxDepth(TreeNode root)
        {
            if(root == null)
            {
                return 0;
            } else
            {
                int leftDepth = MaxDepth(root.left);
                int rightDepth = MaxDepth(root.right);
                return Math.Max(leftDepth, rightDepth) + 1;
            }
        }
    }
}
