using System;

namespace Beautiful_Arrangement
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            //        Input: n = 2
            //Output: 2
            //Explanation:
            //            The first beautiful arrangement is [1, 2]:
            //Number at the 1st position(i= 1) is 1, and 1 is divisible by i(i = 1).
            //Number at the 2nd position(i= 2) is 2, and 2 is divisible by i(i = 2).
            //The second beautiful arrangement is [2, 1]:
            //Number at the 1st position(i= 1) is 2, and 2 is divisible by i(i = 1).
            //Number at the 2nd position(i= 2) is 1, and i(i= 2) is divisible by 1.
            Console.WriteLine(s.CountArrangement(2));
            //1->1
            Console.WriteLine(s.CountArrangement(1));
            //15->24679
            Console.WriteLine(s.CountArrangement(15));
        }
    }
}
