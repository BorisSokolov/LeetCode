using System;

namespace Minimum_Operations_to_Reduce_X_to_Zero
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            //Input: nums = [1, 1, 4, 2, 3], x = 5
            //Output: 2
            //Explanation: The optimal solution is to remove the last two elements to reduce x to zero.
            Console.WriteLine(s.MinOperations(new[] { 1, 1, 4, 2, 3 }, 5));
            //Input: nums = [5, 6, 7, 8, 9], x = 4
            //Output: -1
            Console.WriteLine(s.MinOperations(new[] { 5, 6, 7, 8, 9 }, 4));
            //Input: nums = [3, 2, 20, 1, 1, 3], x = 10
            //Output: 5
            //Explanation: The optimal solution is to remove the last three elements and the first two elements(5 operations in total) to reduce x to zero.
            Console.WriteLine(s.MinOperations(new[] { 3, 2, 20, 1, 1, 3 }, 10));
        }
    }
}
