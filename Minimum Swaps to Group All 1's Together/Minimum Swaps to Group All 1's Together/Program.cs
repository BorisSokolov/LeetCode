using System;

namespace Minimum_Swaps_to_Group_All_1_s_Together
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            //Input: data = [1, 0, 1, 0, 1]
            //Output: 1
            //Explanation:
            //There are 3 ways to group all 1's together:
            //[1, 1, 1, 0, 0] using 1 swap.
            //[0, 1, 1, 1, 0] using 2 swaps.
            //[0, 0, 1, 1, 1] using 1 swap.
            //The minimum is 1.
            Console.WriteLine(s.MinSwaps(new[] { 1, 0, 1, 0, 1 }));
            //Input: data = [0, 0, 0, 1, 0]
            //Output: 0
            //Explanation:
            //Since there is only one 1 in the array, no swaps needed.
            Console.WriteLine(s.MinSwaps(new[] { 0, 0, 0, 1, 0 }));
            //Input: data = [1, 0, 1, 0, 1, 0, 0, 1, 1, 0, 1]
            //Output: 3
            //Explanation:
            //One possible solution that uses 3 swaps is [0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1].
            Console.WriteLine(s.MinSwaps(new[] { 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1 }));
            //Input: data = [1, 0, 1, 0, 1, 0, 1, 1, 1, 0, 1, 0, 0, 1, 1, 1, 0, 0, 1, 1, 1, 0, 1, 0, 1, 1, 0, 0, 0, 1, 1, 1, 1, 0, 0, 1]
            //Output: 8
            Console.WriteLine(s.MinSwaps(new[] { 1, 0, 1, 0, 1, 0, 1, 1, 1, 0, 1, 0, 0, 1, 1, 1, 0, 0, 1, 1, 1, 0, 1, 0, 1, 1, 0, 0, 0, 1, 1, 1, 1, 0, 0, 1 }));
        }
    }
}
