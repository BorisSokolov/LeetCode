namespace Validate_Binary_Search_Tree
{
    /// <summary>
    /// Given the root of a binary tree, determine if it is a valid binary search tree (BST).
    /// A valid BST is defined as follows:
    /// The left subtree of a node contains only nodes with keys less than the node's key.
    /// The right subtree of a node contains only nodes with keys greater than the node's key.
    /// Both the left and right subtrees must also be binary search trees.
    /// </summary>
    public class Solution
    {
        private int? previous;

        public bool IsValidBST(TreeNode root)
        {
            previous = null;
            return Inorder(root);
        }

        private bool Inorder(TreeNode root)
        {
            if (root == null)
                return true;
            if (!Inorder(root.left))
                return false;
            if (previous != null && root.val <= previous)
                return false;

            previous = root.val;

            return Inorder(root.right);
        }
    }
}
