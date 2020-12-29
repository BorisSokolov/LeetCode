using System;

namespace Maximum_Depth_of_Binary_Tree
{
    public class Solution
    {
        public int MaxDepth(TreeNode root)
        {
            int maxDepth = 0;

            ProcessNode(root, 1, ref maxDepth);

            return maxDepth;
        }

        private void ProcessNode(TreeNode node, int depth, ref int maxDepth)
        {
            if (node == null)
            {
                maxDepth = Math.Max(depth - 1, maxDepth);
                return;
            }

            ProcessNode(node.left, ++depth, ref maxDepth);
            ProcessNode(node.right, depth, ref maxDepth);
        }
    }
}
