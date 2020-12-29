namespace Increasing_Order_Search_Tree
{
    /// <summary>
    /// Given the root of a binary search tree, rearrange the tree in in-order so that the leftmost node in the tree is now the root of the tree, and every node has no left child and only one right child.
    /// </summary>
    public class Solution
    {
        private TreeNode current;

        public TreeNode IncreasingBST(TreeNode root)
        {
            TreeNode answer = new TreeNode();
            current = answer;
            Inorder(root);

            return answer.right;
        }

        private void Inorder(TreeNode node)
        {
            if (node == null)
                return;

            Inorder(node.left);
            node.left = null;
            current.right = node;
            current = node;
            Inorder(node.right);
        }
    }
}
