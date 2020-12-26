using System;
using System.Collections.Generic;
using System.Text;

namespace Binary_Search_Tree_Iterator
{ 
    /// <summary>
    /// Implement the BSTIterator class that represents an iterator over the in-order traversal of a binary search tree (BST):
    /// BSTIterator(TreeNode root) Initializes an object of the BSTIterator class. The root of the BST is given as part of the constructor.The pointer should be initialized to a non-existent number smaller than any element in the BST.
    /// boolean hasNext() Returns true if there exists a number in the traversal to the right of the pointer, otherwise returns false.
    /// int next() Moves the pointer to the right, then returns the number at the pointer.
    /// Notice that by initializing the pointer to a non-existent smallest number, the first call to next() will return the smallest element in the BST.
    /// You may assume that next() calls will always be valid. That is, there will be at least a next number in the in-order traversal when next() is called.
    /// </summary>
    public class BSTIterator
    {
        Stack<TreeNode> stack = new Stack<TreeNode>();

        public BSTIterator(TreeNode root)
        {
            // Remember that the algorithm starts with a call to the helper function
            // with the root node as the input
            LeftmostInorder(root);
        }

        private void LeftmostInorder(TreeNode root)
        {

            // For a given node, add all the elements in the leftmost branch of the tree
            // under it to the stack.
            while (root != null)
            {
                stack.Push(root);
                root = root.left;
            }
        }

        public int Next()
        {
            // Node at the top of the stack is the next smallest element
            TreeNode topmostNode = stack.Pop();

            // Need to maintain the invariant. If the node has a right child, call the
            // helper function for the right child
            if (topmostNode.right != null)
            {
                LeftmostInorder(topmostNode.right);
            }

            return topmostNode.val;
        }

        public bool HasNext() => stack.Count > 0;
    }
}
