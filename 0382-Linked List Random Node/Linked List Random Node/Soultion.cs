using System;
using System.Collections.Generic;
using System.Text;

namespace Linked_List_Random_Node
{
    /// <summary>
    /// Given a singly linked list, return a random node's value from the linked list. Each node must have the same probability of being chosen.
    /// Follow up:
    /// What if the linked list is extremely large and its length is unknown to you? Could you solve this efficiently without using extra space?
    /// </summary>
    public class Solution
    {
        private ListNode head;

        /// <summary>
        /// Note that the head is guaranteed to be not null, so it contains at least one node.
        /// </summary>
        /// <param name="head">The linked list's head.</param>
        public Solution(ListNode head)
        {
            this.head = head;
        }

        /// <summary>
        /// Returns a random node's value.
        /// https://en.wikipedia.org/wiki/Reservoir_sampling
        /// </summary>            
        public int GetRandom()
        {
            int scope = 1;
            int value = 0;
            var currentNode = head;
            var rand = new Random();
            while (currentNode != null)
            {
                if (rand.NextDouble() < 1.0 / scope++)
                    value = currentNode.val;

                currentNode = currentNode.next;
            }

            return value;
        }
    }
}
