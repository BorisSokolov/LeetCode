namespace Plus_One_Linked_List
{
    /// <summary>
    /// Given a non-negative integer represented as a linked list of digits, plus one to the integer.
    /// The digits are stored such that the most significant digit is at the head of the list.
    /// </summary>
    public class Solution
    {
        public ListNode PlusOne(ListNode head)
        {
            // sentinel head
            ListNode sentinel = new ListNode(0)
            {
                next = head
            };
            ListNode notNine = sentinel;

            // find the rightmost not-nine digit
            while (head != null)
            {
                if (head.val != 9)
                {
                    notNine = head;
                }
                head = head.next;
            }

            // increase this rightmost not-nine digit by 1
            notNine.val++;
            notNine = notNine.next;

            // set all the following nines to zeros
            while (notNine != null)
            {
                notNine.val = 0;
                notNine = notNine.next;
            }

            return sentinel.val != 0 ? sentinel : sentinel.next;
        }
    }
}
