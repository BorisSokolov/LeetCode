namespace Pseudo_Palindromic_Paths_in_a_Binary_Tree
{
    /// <summary>
    /// Given a binary tree where node values are digits from 1 to 9. A path in the binary tree is said to be pseudo-palindromic if at least one permutation of the node values in the path is a palindrome.
    /// Return the number of pseudo-palindromic paths going from the root node to leaf nodes.
    /// </summary>
    public class Solution
    {
        private int count;

        public void Preorder(TreeNode node, int path)
        {
            if (node != null)
            {
                // compute occurences of each digit 
                // in the corresponding register
                path = path ^ (1 << node.val);
                // if it's a leaf check if the path is pseudo-palindromic
                if (node.left == null && node.right == null)
                {
                    // check if at most one digit has an odd frequency
                    if ((path & (path - 1)) == 0)
                    {
                        ++count;
                    }
                }
                Preorder(node.left, path);
                Preorder(node.right, path);
            }
        }
        public int PseudoPalindromicPaths(TreeNode root)
        {
            Preorder(root, 0);

            return count;
        }
    }
}
