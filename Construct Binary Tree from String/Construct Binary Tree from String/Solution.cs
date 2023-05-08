using LeetCode.Domain;
using System.Collections.Generic;
using System.Linq;

namespace Construct_Binary_Tree_from_String
{
    public class Solution
    {
        public TreeNode Str2tree(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
                return null;

            TreeNode root = new TreeNode();
            Stack<TreeNode> nodes = new Stack<TreeNode>();
            nodes.Push(root);

            for (int i = 0; i < s.Length; i++)
            {
                TreeNode node = nodes.Pop();

                if (char.IsDigit(s[i]) || s[i].Equals('-'))
                {
                    node.val = ParseNumber(s, ref i);

                    if (i < s.Length && s[i].Equals('('))
                    {
                        nodes.Push(node);

                        node.left = new TreeNode();
                        nodes.Push(node.left);
                    }
                }
                else if (s[i].Equals('(') && node.left != null)
                {
                    nodes.Push(node);

                    node.right = new TreeNode();
                    nodes.Push(node.right);
                }
            }

            return nodes.Any() ? nodes.Pop() : root;
        }

        private int ParseNumber(string s, ref int index)
        {
            bool isNegative = false;

            if (s[index].Equals('-'))
            {
                isNegative = true;
                index++;
            }

            int result = 0;
            while (index < s.Length && char.IsDigit(s[index]))
            {
                result = 10 * result + (s[index] - '0');
                index++;
            }

            return isNegative ? -result : result;
        }
    }
}
