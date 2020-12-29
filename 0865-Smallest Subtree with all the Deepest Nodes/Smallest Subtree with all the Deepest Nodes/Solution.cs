using System.Collections.Generic;
using System.Linq;

namespace Smallest_Subtree_with_all_the_Deepest_Nodes
{
    public class Solution
    {
        private Dictionary<TreeNode, int> depth = new Dictionary<TreeNode, int>();
        private int maxDepth;

        public TreeNode SubtreeWithAllDeepest(TreeNode root)
        {
            Dfs(root, 0);

            maxDepth = depth.Values.Max();

            return Result(root);
        }

        private TreeNode Result(TreeNode node)
        {
            if (node == null || depth[node] == maxDepth)
                return node;

            var left = Result(node.left);
            var right = Result(node.right);

            if (left != null && right != null)
                return node;

            if (left != null)
                return left;

            if (right != null)
                return right;

            return null;
        }

        private void Dfs(TreeNode node, int parentDepth)
        {
            if (node != null)
            {
                int currentDepth = parentDepth + 1;
                depth.Add(node, currentDepth);
                Dfs(node.left, currentDepth);
                Dfs(node.right, currentDepth);
            }
        }
    }
}
