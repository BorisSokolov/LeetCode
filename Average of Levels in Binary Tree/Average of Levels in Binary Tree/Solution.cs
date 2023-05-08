using LeetCode.Domain;
using System.Collections.Generic;
using System.Linq;

namespace Average_of_Levels_in_Binary_Tree
{
    /// <summary>
    /// Given a non-empty binary tree, return the average value of the nodes on each level in the form of an array.
    /// </summary>
    public class Solution
    {
        public IList<double> AverageOfLevels(TreeNode root)
        {
            IList<double> result = new List<double>();
            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            double sum = 0;
            while (queue.Any())
            {
                int size = queue.Count();
                for (int i = 0; i < size; i++)
                {
                    var node = queue.Dequeue();
                    sum += node.val;

                    if (node.left != null)
                        queue.Enqueue(node.left);

                    if (node.right != null)
                        queue.Enqueue(node.right);
                }

                result.Add(sum / size);
                sum = 0;
            }

            return result;
        }
    }
}
