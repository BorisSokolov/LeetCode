using System;

namespace Validate_Binary_Search_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            //Input: root = [2, 1, 3]
            //Output: true
            Console.WriteLine(s.IsValidBST(new TreeNode(2, new TreeNode(1), new TreeNode(3))));
            //Input: root = [5, 1, 4, null, null, 3, 6]
            //Output: false
            //Explanation: The root node's value is 5 but its right child's value is 4.
            Console.WriteLine(s.IsValidBST(new TreeNode(5, new TreeNode(1), new TreeNode(4, new TreeNode(3), new TreeNode(6)))));
        }
    }
}
