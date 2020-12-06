using System;

namespace Linked_List_Random_Node
{
    class Program
    {
        static void Main(string[] args)
        {
            // Init a singly linked list [1,2,3].
            ListNode head = new ListNode(1);
            head.next = new ListNode(2);
            head.next.next = new ListNode(3);
            Solution solution = new Solution(head);
            Console.WriteLine(solution.GetRandom());
            Console.WriteLine(solution.GetRandom());
            Console.WriteLine(solution.GetRandom());
            Console.WriteLine(solution.GetRandom());
        }
    }
}
