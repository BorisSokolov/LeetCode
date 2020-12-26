using System;

namespace Balanced_Binary_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            //Input: root = [3, 9, 20, null, null, 15, 7]
            //Output: true
            Console.WriteLine(s.IsBalanced(new TreeNode(3, new TreeNode(9), new TreeNode(20, new TreeNode(15), new TreeNode(7)))));
            //Input: root = [1, 2, 2, 3, 3, null, null, 4, 4]
            //Output: false
            Console.WriteLine(s.IsBalanced(new TreeNode
            {
                val = 1,
                right = new TreeNode(2),
                left = new TreeNode
                {
                    val = 2,
                    right = new TreeNode(3),
                    left = new TreeNode(3, new TreeNode(4), new TreeNode(4))
                }
            }));
        }
    }
}
