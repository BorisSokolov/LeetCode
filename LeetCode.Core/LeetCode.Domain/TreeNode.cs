using Newtonsoft.Json;
using System;

namespace LeetCode.Domain
{
    /// <summary>
    /// Definition for a binary tree node.
    /// </summary>
    public class TreeNode : IEquatable<TreeNode>
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }

        public static bool operator ==(TreeNode node1, TreeNode node2)
        {
            return (object)node1 == null ? (object)node2 == null : node1.Equals(node2);
        }

        public static bool operator !=(TreeNode node1, TreeNode node2)
        {
            return !(node1 == node2);
        }

        public bool Equals(TreeNode other)
        {            
            return other == null ? false : JsonConvert.SerializeObject(this).Equals(JsonConvert.SerializeObject(other));
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as TreeNode);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
