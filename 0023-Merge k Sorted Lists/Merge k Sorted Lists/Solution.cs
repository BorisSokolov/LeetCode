using LeetCode.Domain;
using System.Linq;

namespace Merge_k_Sorted_Lists
{
    /// <summary>
    /// You are given an array of k linked-lists lists, each linked-list is sorted in ascending order.
    /// Merge all the linked-lists into one sorted linked-list and return it.
    /// </summary>
    public class Solution
    {
        public ListNode MergeKLists(ListNode[] lists)
        {
            if (lists?.Any() != true)
                return null;

            int interval = 1;

            while (interval < lists.Length)
            {
                for (int i = 0; i < lists.Length - interval; i += 2 * interval)
                {
                    lists[i] = MergeTwoLists(lists[i], lists[i + interval]);
                }
                interval *= 2;
            }

            return lists[0];
        }

        /// <summary>
        /// Already solved in 21
        /// </summary>
        /// <param name="l1"></param>
        /// <param name="l2"></param>
        /// <returns></returns>
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

            current.next = l1 ?? l2;
            return answer.next;
        }
    }
}
