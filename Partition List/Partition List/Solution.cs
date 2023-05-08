using LeetCode.Domain;

namespace Partition_List
{
    public class Solution
    {
        public ListNode Partition(ListNode head, int x)
        {
            // before and after are the two pointers used to create the two list
            // before_head and after_head are used to save the heads of the two lists.
            // All of these are initialized with the dummy nodes created.
            ListNode beforeHead = new ListNode(0);
            ListNode before = beforeHead;
            ListNode afterHead = new ListNode(0);
            ListNode after = afterHead;

            while (head != null)
            {
                // If the original list node is lesser than the given x,
                // assign it to the before list.
                if (head.val < x)
                {
                    before.next = head;
                    before = before.next;
                }
                else
                {
                    // If the original list node is greater or equal to the given x,
                    // assign it to the after list.
                    after.next = head;
                    after = after.next;
                }

                // move ahead in the original list
                head = head.next;
            }

            // Last node of "after" list would also be ending node of the reformed list
            after.next = null;

            // Once all the nodes are correctly assigned to the two lists,
            // combine them to form a single list which would be returned.
            before.next = afterHead.next;

            return beforeHead.next;
        }
    }    
}
