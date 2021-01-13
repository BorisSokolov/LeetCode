using LeetCode.Domain;
using System.Collections.Generic;

namespace Find_Root_of_N_Ary_Tree
{
    public class Solution
    {
        public Node FindRoot(List<Node> tree)
        {
            int sum = 0;

            foreach (var node in tree)
            {
                // the value is added as a parent node
                sum += node.val;
                foreach (var child in node.children)
                    // the value is deducted as a child node.
                    sum -= child.val;
            }

            Node root = null;
            // the value of the root node is `valueSum`
            foreach (var node in tree)
            {
                if (node.val == sum)
                {
                    root = node;
                    break;
                }
            }
            return root;
        }
    }
}
