using System;

namespace Construct_Binary_Tree_from_Inorder_and_Postorder_Traversal
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Solution();
            var k = s.BuildTree(new [] { 9, 3, 15, 20, 7 }, new [] { 9, 15, 7, 20, 3 });
            Console.WriteLine(k.val);
        }
    }
}
