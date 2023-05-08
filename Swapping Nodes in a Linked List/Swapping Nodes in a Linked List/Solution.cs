using LeetCode.Domain;

namespace Swapping_Nodes_in_a_Linked_List
{
    /// <summary>
    /// You are given the head of a linked list, and an integer k.
    /// Return the head of the linked list after swapping the values of the kth node from the beginning and the kth node from the end(the list is 1-indexed).
    /// </summary>
    public class Solution
    {
        public ListNode SwapNodes(ListNode head, int k)
        {
            if (head == null || head.next == null)
                return head;

            int listLength = 0;
            ListNode frontNode = null;
            ListNode endNode = null;
            ListNode currentNode = head;
            // set the front node and end node in single pass
            while (currentNode != null)
            {
                listLength++;
                if (endNode != null)
                    endNode = endNode.next;
                // check if we have reached kth node
                if (listLength == k)
                {
                    frontNode = currentNode;
                    endNode = head;
                }
                currentNode = currentNode.next;
            }
            // swap the values of front node and end node
            int temp = frontNode.val;
            frontNode.val = endNode.val;
            endNode.val = temp;

            return head;
        }
    }
}
