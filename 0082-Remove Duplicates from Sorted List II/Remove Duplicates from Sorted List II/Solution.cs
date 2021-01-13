using LeetCode.Domain;

namespace Remove_Duplicates_from_Sorted_List_II
{
    /// <summary>
    /// Given the head of a sorted linked list, delete all nodes that have duplicate numbers, leaving only distinct numbers from the original list. Return the linked list sorted as well.
    /// </summary>
    public class Solution
    {
        public ListNode DeleteDuplicates(ListNode head)
        {
            // sentinel
            ListNode sentinel = new ListNode(0, head);

            // predecessor = the last node 
            // before the sublist of duplicates
            ListNode pred = sentinel;

            while (head != null)
            {
                // if it's a beginning of duplicates sublist 
                // skip all duplicates
                if (head.val == head.next?.val)
                {
                    // move till the end of duplicates sublist
                    while (head.val == head.next?.val)
                    {
                        head = head.next;
                    }
                    // skip all duplicates
                    pred.next = head.next;
                    // otherwise, move predecessor
                }
                else
                {
                    pred = pred.next;
                }

                // move forward
                head = head.next;
            }
            return sentinel.next;
        }
    }
}
