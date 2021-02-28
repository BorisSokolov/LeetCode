using System;

namespace Find_the_Most_Competitive_Subsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            //Input: nums = [3, 5, 2, 6], k = 2
            //Output: [2, 6]
            //Explanation: Among the set of every possible subsequence: {[3,5], [3,2], [3,6], [5,2], [5,6], [2,6]
            //    }, [2,6] is the most competitive.
            Console.WriteLine(string.Join(", ", s.MostCompetitive(new[] { 3, 5, 2, 6 }, 2)));
            //Input: nums = [2,4,3,3,5,4,9,6], k = 4
            //Output: [2,3,3,4]
            Console.WriteLine(string.Join(", ", s.MostCompetitive(new[] { 2, 4, 3, 3, 5, 4, 9, 6 }, 4)));
        }
    }
}
