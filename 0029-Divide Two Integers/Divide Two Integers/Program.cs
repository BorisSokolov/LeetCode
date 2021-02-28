using System;

namespace Divide_Two_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();

            //Input: dividend = 10, divisor = 3
            //Output: 3
            //Explanation: 10 / 3 = truncate(3.33333..) = 3.
            Console.WriteLine(s.Divide(10, 3));
            //Input: dividend = 7, divisor = -3
            //Output: -2
            //Explanation: 7 / -3 = truncate(-2.33333..) = -2.
            Console.WriteLine(s.Divide(7, -3));
            //Input: dividend = 0, divisor = 1
            //Output: 0
            Console.WriteLine(s.Divide(0, 1));
            //Input: dividend = 1, divisor = 1
            //Output: 1
            Console.WriteLine(s.Divide(1, 1));
        }
    }
}
