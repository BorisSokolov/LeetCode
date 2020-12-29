using System;

namespace Find_Nearest_Right_Node_in_Binary_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            //Input: root = [1, 2, 3, null, 4, 5, 6], u = 4
            //Output: 5
            //Explanation: The nearest node on the same level to the right of node 4 is node 5.
            Console.WriteLine(s.FindNearestRightNode(new TreeNode(1, new TreeNode(2, null, new TreeNode(4)), new TreeNode(3, new TreeNode(5), new TreeNode(6))), new TreeNode(4))?.val);
        }
    }
}
