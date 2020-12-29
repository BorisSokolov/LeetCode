using System;

namespace Plus_One_Linked_List
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            //Input: head = [1, 2, 3]
            //Output: [1, 2, 4]
            Console.WriteLine(s.PlusOne(new ListNode(1, new ListNode(2, new ListNode(3)))).ToString());
        }
    }
}
