using System;

namespace Squares_of_a_Sorted_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            //Input: nums = [-4, -1, 0, 3, 10]
            //Output: [0, 1, 9, 16, 100]
            //Explanation: After squaring, the array becomes[16, 1, 0, 9, 100].
            //After sorting, it becomes[0, 1, 9, 16, 100].
            Console.WriteLine(string.Join(", ", s.SortedSquares(new[] { -4, -1, 0, 3, 10 })));
        }
    }
}
