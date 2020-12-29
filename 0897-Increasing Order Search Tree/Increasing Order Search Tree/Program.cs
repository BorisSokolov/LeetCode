using System;

namespace Increasing_Order_Search_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            //Input: root = [5,3,6,2,4,null,8,1,null,null,null,7,9]
            //Output: [1,null,2,null,3,null,4,null,5,null,6,null,7,null,8,null,9]
            var tree = new TreeNode
            {
                val = 5,
                left = new TreeNode
                {
                    val = 3,
                    left = new TreeNode(2, new TreeNode(1)),
                    right = new TreeNode(4)
                },
                right = new TreeNode
                {
                    val = 6,
                    right = new TreeNode(9, new TreeNode(7), new TreeNode(9))
                }
            };

            var newTree = s.IncreasingBST(tree);
            Console.WriteLine(newTree.val);
            Console.WriteLine(newTree.left == null);
            Console.WriteLine(newTree.right.val);
        }
    }
}
