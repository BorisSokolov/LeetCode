using System;

namespace Balanced_Binary_Tree
{
    public class Solution
    {
        public bool IsBalanced(TreeNode root)
        {
            return Dfs(root) != -1;
        }

        private int Dfs(TreeNode root)
        {
            if (root == null)
                return 0;

            int left = Dfs(root.left);

            if (left == -1)
                return -1;

            int right = Dfs(root.right);

            if (right == -1 || Math.Abs(right - left) > 1)
                return -1;

            return Math.Max(left, right) + 1;
        }
    }
}
