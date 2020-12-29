using System;
using System.Collections.Generic;
using System.Text;

namespace Populating_Next_Right_Pointers_in_Each_Node_II
{
    /// <summary>
    /// Given a binary tree
    /// Populate each next pointer to point to its next right node. If there is no next right node, the next pointer should be set to NULL.
    /// Initially, all next pointers are set to NULL.
    /// Follow up:
    /// -You may only use constant extra space.
    /// -Recursive approach is fine, you may assume implicit stack space does not count as extra space for this problem.
    /// </summary>
    public class Solution
    {
        private Node previous = new Node();
        private Node leftmost = new Node();

        public Node Connect(Node root)
        {
            if (root == null)
                return root;

            leftmost = root;
            Node current = leftmost;

            while (leftmost != null)
            {
                previous = null;
                current = leftmost;
                leftmost = null;

                while (current != null)
                {
                    ProcessChild(current.left);
                    ProcessChild(current.right);

                    current = current.next;
                }
            }

            return root;
        }

        private void ProcessChild(Node child)
        {
            if (child != null)
            {
                if (previous != null)
                {
                    previous.next = child;
                }
                else
                {
                    leftmost = child;
                }
                previous = child;
            }
        }
    }
}
