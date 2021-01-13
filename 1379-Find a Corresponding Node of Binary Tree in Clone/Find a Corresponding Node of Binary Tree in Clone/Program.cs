using LeetCode.Domain;
using System;

namespace Find_a_Corresponding_Node_of_Binary_Tree_in_Clone
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            //Input: tree = [7, 4, 3, null, null, 6, 19], target = 3
            //Output: 3
            //Explanation: In all examples the original and cloned trees are shown. The target node is a green node from the original tree.The answer is the yellow node from the cloned tree.
            var tree = new TreeNode(7, new TreeNode(4), new TreeNode(3, new TreeNode(6), new TreeNode(19)));
            Console.WriteLine(s.GetTargetCopy(tree, tree, new TreeNode(3, new TreeNode(6), new TreeNode(19)))?.val);
        }
    }
}
