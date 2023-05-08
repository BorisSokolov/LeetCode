using LeetCode.Domain;
using System;

namespace Average_of_Levels_in_Binary_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            //        Input:
            //    3
            //   / \
            //  9  20
            //    /  \
            //   15   7
            //Output: [3, 14.5, 11]
            //Explanation:
            //The average value of nodes on level 0 is 3,  on level 1 is 14.5, and on level 2 is 11.Hence return [3, 14.5, 11].
            Solution s = new Solution();
            var root = new TreeNode(3, new TreeNode(9), new TreeNode(20, new TreeNode(15), new TreeNode(7)));
            Console.WriteLine(string.Join(',', s.AverageOfLevels(root)));
        }
    }
}
