using System;

namespace Max_Number_of_K_Sum_Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            //Input: nums = [1, 2, 3, 4], k = 5
            //Output: 2
            //Explanation: Starting with nums = [1, 2, 3, 4]:
            //-Remove numbers 1 and 4, then nums = [2, 3]
            //- Remove numbers 2 and 3, then nums = []
            //There are no more pairs that sum up to 5, hence a total of 2 operations.
            Console.WriteLine(s.MaxOperations(new[] { 1, 2, 3, 4 }, 5));
            //Input: nums = [3, 1, 3, 4, 3], k = 6
            //Output: 1
            //Explanation: Starting with nums = [3, 1, 3, 4, 3]:
            //-Remove the first two 3's, then nums = [1,4,3]
            Console.WriteLine(s.MaxOperations(new[] { 3, 1, 3, 4, 3 }, 6));
        }
    }
}
