using System;

namespace Construct_Binary_Tree_from_String
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            //Input: s = "4(2(3)(1))(6(5))"
            //Output: [4, 2, 6, 3, 1, 5]

            //Input: s = "4(2(3)(1))(6(5)(7))"
            //Output: [4, 2, 6, 3, 1, 5, 7]

            //Input: s = "-4(2(3)(1))(6(5)(7))"
            //Output: [-4, 2, 6, 3, 1, 5, 7]


            Console.WriteLine(s.Str2tree("4").val);
        }
    }
}
