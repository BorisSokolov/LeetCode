using System.Collections.Generic;

namespace Find_Nearest_Right_Node_in_Binary_Tree
{
    public class Solution
    {
        public TreeNode FindNearestRightNode(TreeNode root, TreeNode u)
        {
            if (root == null || u == null)
                return null;

            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            while (queue.Count != 0)
            {
                int size = queue.Count;

                for (int i = 0; i < size; i++)
                {
                    var current = queue.Dequeue();

                    if (current.val == u.val)
                    {
                        if (i + 1 == size)
                        {
                            return null;
                        }
                        else
                        {
                            return queue.Dequeue();
                        }
                    }

                    if (current.left != null)
                        queue.Enqueue(current.left);

                    if (current.right != null)
                        queue.Enqueue(current.right);
                }
            }

            return null;
        }
    }
}
