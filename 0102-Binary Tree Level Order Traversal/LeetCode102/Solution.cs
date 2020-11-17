using System.Collections.Generic;

namespace LeetCode102
{
    public class Solution
    {
        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            IList<IList<int>> result = new List<IList<int>>();

            ProcessNode(root, 0, result);

            return result;
        }

        private void ProcessNode(TreeNode node, int depth, IList<IList<int>> result)
        {
            if (node == null)
                return;

            if (result.Count <= depth)
                result.Add(new List<int>());

            result[depth].Add(node.val);

            ProcessNode(node.left, ++depth, result);
            ProcessNode(node.right, depth, result);
        }
    }
}
