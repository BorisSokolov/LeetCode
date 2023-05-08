using LeetCode.Domain;
namespace Intersection_of_Two_Linked_Lists
{
    /// <summary>
    /// Write a program to find the node at which the intersection of two singly linked lists begins.
    /// </summary>
    public class Solution
    {
        public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            ListNode pA = headA;
            ListNode pB = headB;
            while (pA != pB)
            {
                pA = pA == null ? headB : pA.next;
                pB = pB == null ? headA : pB.next;
            }
            return pA;
        }
    }
}
