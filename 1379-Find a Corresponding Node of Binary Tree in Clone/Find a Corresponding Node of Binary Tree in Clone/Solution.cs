using LeetCode.Domain;
using System.Collections.Generic;

namespace Find_a_Corresponding_Node_of_Binary_Tree_in_Clone
{
    /// <summary>
    /// Given two binary trees original and cloned and given a reference to a node target in the original tree.
    /// The cloned tree is a copy of the original tree.
    /// Return a reference to the same node in the cloned tree.
    /// Note that you are not allowed to change any of the two trees or the target node and the answer must be a reference to a node in the cloned tree.
    /// Follow up: Solve the problem if repeated values on the tree are allowed.
    /// </summary>
    public class Solution
    {
        public TreeNode GetTargetCopy(TreeNode original, TreeNode cloned, TreeNode target)
        {
            var originalQueue = new Queue<TreeNode>();
            originalQueue.Enqueue(original);

           var clonedQueue = new Queue<TreeNode>();
            clonedQueue.Enqueue(cloned);

            while (originalQueue.Count > 0)
            {
                TreeNode originalNode = originalQueue.Dequeue();
                TreeNode clonedNode = clonedQueue.Dequeue();

                if (originalNode == target)
                {
                    return clonedNode;
                }

                if (originalNode.left != null)
                {
                    originalQueue.Enqueue(originalNode.left);
                    clonedQueue.Enqueue(clonedNode.left);
                }
                if (originalNode.right != null)
                {
                    originalQueue.Enqueue(originalNode.right);
                    clonedQueue.Enqueue(clonedNode.right);
                }
            }
            return null;
        }
    }
}
