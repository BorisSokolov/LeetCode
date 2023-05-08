using LeetCode.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Construct_Binary_Tree_from_Inorder_and_Postorder_Traversal
{
    public class Solution
    {
        public TreeNode BuildTree(int[] inorder, int[] postorder)
        {
            if (inorder?.Any() != true || postorder?.Any() != true)
                return null;

            var root = new TreeNode(postorder[^1]);

            if (postorder.Length == 1)
                return root;

            int index = Array.IndexOf(inorder, root.val);

            root.left = BuildTree(inorder[..index], postorder[..index]);
            root.right = BuildTree(inorder[(index+1)..], postorder[index..^1]);

            return root;
        }
    }
}
