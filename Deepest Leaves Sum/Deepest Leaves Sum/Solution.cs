using LeetCode.Domain;
using System.Collections.Generic;
using System.Linq;

namespace Deepest_Leaves_Sum
{
    public class Solution
    {
        public int DeepestLeavesSum(TreeNode root)
        {
            var next = new Queue<TreeNode>();
            next.Enqueue(root);

            var current = new Queue<TreeNode>();

            while (next.Any())
            {
                current = new Queue<TreeNode>(next);
                next = new Queue<TreeNode>();

                foreach (var node in current)
                {
                    if (node.left != null)
                        next.Enqueue(node.left);

                    if (node.right != null)
                        next.Enqueue(node.right);
                }
            }

            int sum = 0;
            foreach (var node in current)
                sum += node.val;

            return sum;
        }
    }
}
