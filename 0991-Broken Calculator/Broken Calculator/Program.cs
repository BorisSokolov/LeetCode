using System;

namespace Broken_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            //Input: X = 2, Y = 3
            //Output: 2
            //Explanation: Use double operation and then decrement operation { 2-> 4-> 3}.
            Console.WriteLine(s.BrokenCalc(2, 3));
            //Input: X = 5, Y = 8
            //Output: 2
            //Explanation: Use decrement and then double { 5-> 4-> 8}.
            Console.WriteLine(s.BrokenCalc(5, 8));
            //Input: X = 3, Y = 10
            //Output: 3
            //Explanation: Use double, decrement and double { 3-> 6-> 5-> 10}.
            Console.WriteLine(s.BrokenCalc(3, 10));
            //Input: X = 1024, Y = 1
            //Output: 1023
            //Explanation: Use decrement operations 1023 times.
            Console.WriteLine(s.BrokenCalc(1024, 1));
        }
    }
}
