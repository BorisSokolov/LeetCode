using LeetCode.Domain;
using System;

namespace Binary_Tree_Longest_Consecutive_Sequence_II
{
    public class Solution
    {
        private int max = 0;

        private int[] LongestPath(TreeNode root)
        {
            if (root == null)
                return new[] { 0, 0 };

            int i = 1;
            int d = 1;

            if (root.left != null)
            {
                var left = LongestPath(root.left);

                if (root.val == root.left.val + 1)
                    d = left[1] + 1;
                else if (root.val == root.left.val - 1)
                    i = left[0] + 1;
            }

            if (root.right != null)
            {
                var right = LongestPath(root.right);

                if (root.val == root.right.val + 1)
                    d = Math.Max(d, right[1] + 1);
                else if (root.val == root.right.val -1)
                    i = Math.Max(i, right[0] + 1);
            }

            max = Math.Max(max, i + d - 1);

            return new[] { i, d };
        }

        public int LongestConsecutive(TreeNode root)
        {
            LongestPath(root);
            return max;
        }
    }
}
