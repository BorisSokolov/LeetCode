using System;

namespace Longest_Mountain_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            //Input: [2,1,4,7,3,2,5]
            //Output: 5
            //Explanation: The largest mountain is [1, 4, 7, 3, 2] which has length 5.
            var a = new int[] { 2, 1, 4, 7, 3, 2, 5 };
            Console.WriteLine(s.LongestMountain(a));

            //Input: [2,2,2]
            //Output: 0
            //Explanation: There is no mountain.
            var a2 = new int[] { 2, 2, 2 };
            Console.WriteLine(s.LongestMountain(a2));
        }
    }
}
