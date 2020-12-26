using System;
using System.Collections.Generic;
using System.Text;

namespace Plus_One_Linked_List
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

        public override string ToString()
        {
            return $"{val}, {next?.ToString()}";
        }
    }
}
