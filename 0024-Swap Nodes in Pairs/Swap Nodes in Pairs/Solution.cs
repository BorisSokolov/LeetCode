namespace Swap_Nodes_in_Pairs
{
    /// <summary>
    /// Given a linked list, swap every two adjacent nodes and return its head.
    /// You may not modify the values in the list's nodes. Only nodes itself may be changed.
    /// </summary>
    public class Solution
    {
        public ListNode SwapPairs(ListNode head)
        {
            // Dummy node acts as the prevNode for the head node
            // of the list and hence stores pointer to the head node.
            ListNode dummy = new ListNode(-1)
            {
                next = head
            };

            ListNode prevNode = dummy;

            while ((head != null) && (head.next != null))
            {

                // Nodes to be swapped
                ListNode firstNode = head;
                ListNode secondNode = head.next;

                // Swapping
                prevNode.next = secondNode;
                firstNode.next = secondNode.next;
                secondNode.next = firstNode;

                // Reinitializing the head and prevNode for next swap
                prevNode = firstNode;
                head = firstNode.next; // jump
            }

            // Return the new head node.
            return dummy.next;
        }
    }
}
