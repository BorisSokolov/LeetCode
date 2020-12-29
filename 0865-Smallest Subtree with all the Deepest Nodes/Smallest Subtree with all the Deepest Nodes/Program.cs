using System;

namespace Smallest_Subtree_with_all_the_Deepest_Nodes
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            //Input: root = [3,5,1,6,2,0,8,null,null,7,4]
            //        Output: [2,7,4]
            //        Explanation: We return the node with value 2, colored in yellow in the diagram.
            //        The nodes coloured in blue are the deepest nodes of the tree.
            //Notice that nodes 5, 3 and 2 contain the deepest nodes in the tree but node 2 is the smallest subtree among them, so we return it.
            TreeNode root = new TreeNode
            {
                val = 3,
                left = new TreeNode
                {
                    val = 5,
                    left = new TreeNode(6),
                    right = new TreeNode(2, new TreeNode(7), new TreeNode(4))
                },
                right = new TreeNode(1, new TreeNode(0), new TreeNode(8))
            };
            var result = s.SubtreeWithAllDeepest(root);
            Console.WriteLine(result.val);
            Console.WriteLine(result.left.val);
            Console.WriteLine(result.right.val);
        }
    }
}
