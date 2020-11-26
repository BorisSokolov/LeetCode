using System;
using System.Collections.Generic;
using System.Text;

namespace House_Robber_III
{
    /// <summary>
    /// The thief has found himself a new place for his thievery again. There is only one entrance to this area, called the "root." Besides the root, each house has one and only one parent house. After a tour, the smart thief realized that "all houses in this place forms a binary tree". It will automatically contact the police if two directly-linked houses were broken into on the same night.
    /// Determine the maximum amount of money the thief can rob tonight without alerting the police.
    /// </summary>
    public class Solution
    {
        public int[] Helper(TreeNode node)
        {
            //  return [rob this node, not rob this node]
            if (node == null)
                return new int[] { 0, 0 };

            int[] left = Helper(node.left);
            int[] right = Helper(node.right);
            //  if we rob this node, we cannot rob its children
            int rob = node.val + left[1] + right[1];
            //  else, we free to choose rob its children or not
            int notRob = Math.Max(left[0], left[1]) + Math.Max(right[0], right[1]);
            return new int[] { rob, notRob };
        }

        public int Rob(TreeNode root)
        {
            int[] answer = Helper(root);
            return Math.Max(answer[0], answer[1]);
        }
    }
}
