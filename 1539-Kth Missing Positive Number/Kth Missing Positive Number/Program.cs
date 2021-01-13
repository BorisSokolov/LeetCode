using System;

namespace Kth_Missing_Positive_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            //Input: arr = [2, 3, 4, 7, 11], k = 5
            //Output: 9
            //Explanation: The missing positive integers are[1, 5, 6, 8, 9, 10, 12, 13, ...].The 5th missing positive integer is 9.
            Console.WriteLine(s.FindKthPositive(new[] { 2, 3, 4, 7, 11 }, 5));
            //Input: arr = [1, 2, 3, 4], k = 2
            //Output: 6
            //Explanation: The missing positive integers are[5, 6, 7, ...].The 2nd missing positive integer is 6.
            Console.WriteLine(s.FindKthPositive(new[] { 1, 2, 3, 4 }, 2));
        }
    }
}
