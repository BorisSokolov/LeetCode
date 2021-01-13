using System;

namespace Range_Sum_of_BST
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            //Input: root = [10, 5, 15, 3, 7, null, 18], low = 7, high = 15
            //Output: 32
            TreeNode t = new TreeNode
            {
                val = 10,
                left = new TreeNode
                {
                    val = 5,
                    left = new TreeNode(3, null, null),
                    right = new TreeNode(7, null, null)
                },
                right = new TreeNode
                {
                    val = 15,
                    left = null,
                    right = new TreeNode(18, null, null)
                }
            };
            Console.WriteLine(s.RangeSumBST(t, 7, 15));

            //Input: root = Input:[18,9,27,6,15,24,30,3,null,12,null,21], low = 18, high = 24
            //Output: 63
            TreeNode t2 = new TreeNode
            {
                val = 18,
                left = new TreeNode
                {
                    val = 9,
                    left = new TreeNode
                    {
                        val = 6,
                        left = new TreeNode(3),
                        right = null
                    },
                    right = new TreeNode
                    {
                        val = 15,
                        left = new TreeNode(12),
                        right = null
                    }
                },
                right = new TreeNode
                {
                    val = 27,
                    left = new TreeNode(24, new TreeNode(21)),
                    right = new TreeNode(30)
                }
            };
            Console.WriteLine(s.RangeSumBST(t2, 18, 24));
        }
    }
}
