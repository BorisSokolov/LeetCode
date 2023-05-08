using System;

namespace Largest_Unique_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            //Input: [5, 7, 3, 9, 4, 9, 8, 3, 1]
            //Output: 8
            //Explanation:
            //            The maximum integer in the array is 9 but it is repeated.The number 8 occurs only once, so it's the answer.
            Console.WriteLine(s.LargestUniqueNumber(new[] { 5, 7, 3, 9, 4, 9, 8, 3, 1 }));
            //Input: [9, 9, 8, 8]
            //Output: -1
            //Explanation:
            //            There is no number that occurs only once.
            Console.WriteLine(s.LargestUniqueNumber(new[] { 9, 9, 8, 8 }));
        }
    }
}
