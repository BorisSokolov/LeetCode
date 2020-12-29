using System;

namespace Reach_a_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            //Input: target = 3
            //Output: 2
            //Explanation:
            //            On the first move we step from 0 to 1.
            //On the second step we step from 1 to 3.
            Console.WriteLine(s.ReachNumber(3));
        }
    }
}
