using LeetCode.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Merge_Two_Sorted_Lists
{
    /// <summary>
    /// Merge two sorted linked lists and return it as a sorted list. The list should be made by splicing together the nodes of the first two lists.
    /// </summary>
    public class Solution
    {
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            //keep the head of the list
            var answer = new ListNode(-1);
            var current = answer;
            while (l1 != null && l2 != null)
            {
                if (l1.val < l2.val)
                {
                    current.next = l1;
                    l1 = l1.next;
                }
                else
                {
                    current.next = l2;
                    l2 = l2.next;
                }
                current = current.next;
            }

            current.next = l1 == null ? l2 : l1;
            return answer.next;
        }
    }
}
