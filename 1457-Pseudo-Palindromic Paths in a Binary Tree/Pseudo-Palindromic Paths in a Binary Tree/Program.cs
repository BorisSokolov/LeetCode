using System;

namespace Pseudo_Palindromic_Paths_in_a_Binary_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            //Input: root = [2, 3, 1, 3, 1, null, 1]
            //Output: 2
            //Explanation: The figure above represents the given binary tree. There are three paths going from the root node to leaf nodes: the red path[2, 3, 3], the green path[2, 1, 1], and the path[2, 3, 1].Among these paths only red path and green path are pseudo-palindromic paths since the red path[2, 3, 3] can be rearranged in [3,2,3] (palindrome) and the green path[2, 1, 1] can be rearranged in [1,2,1] (palindrome).

            Console.WriteLine(s.PseudoPalindromicPaths(new TreeNode(2, new TreeNode(3, new TreeNode(3), new TreeNode(1)), new TreeNode(1, new TreeNode(1)))));
        }
    }
}
