using System.Linq;
using System.Text;

namespace LeetCode.Domain
{
    /// <summary>
    ///   Definition for singly-linked list.
    /// </summary>
    public class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }

        public ListNode(int[] nodes)
        {
            if (nodes != null && nodes.Length > 0)
            {
                val = nodes[0];
                if (nodes.Length > 1)
                    next = new ListNode(nodes.Skip(1).ToArray());
            }
        }

        public override string ToString()
        {
            var builder = new StringBuilder($"{val}");
            var current = this;
            while (current.next != null)
            {
                builder.Append($", {current.next.val}");
                current = current.next;
            }

            return builder.ToString();
        }
    }
}
