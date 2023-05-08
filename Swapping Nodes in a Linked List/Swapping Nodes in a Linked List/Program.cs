using LeetCode.Domain;
using System;

namespace Swapping_Nodes_in_a_Linked_List
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            //Input: head = [1, 2, 3, 4, 5], k = 2
            //Output: [1, 4, 3, 2, 5]
            Console.WriteLine(s.SwapNodes(new ListNode(new[] { 1, 2, 3, 4, 5 }), 2).ToString());
            //Input: head = [7, 9, 6, 6, 7, 8, 3, 0, 9, 5], k = 5
            //Output: [7, 9, 6, 6, 8, 7, 3, 0, 9, 5]
            Console.WriteLine(s.SwapNodes(new ListNode(new[] { 7, 9, 6, 6, 7, 8, 3, 0, 9, 5 }), 5).ToString());
            //Input: head = [1], k = 1
            //Output: [1]
            Console.WriteLine(s.SwapNodes(new ListNode(new[] { 1 }), 1).ToString());
            //Input: head = [1, 2], k = 1
            //Output: [2, 1]
            Console.WriteLine(s.SwapNodes(new ListNode(new[] { 1, 2 }), 1).ToString());
            //Input: head = [1, 2, 3], k = 2
            //Output: [1, 2, 3]
            Console.WriteLine(s.SwapNodes(new ListNode(new[] { 1, 2, 3 }), 2).ToString());
        }
    }
}
