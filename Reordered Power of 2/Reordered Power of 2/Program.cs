using System;

namespace Reordered_Power_of_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            //Input: 1
            //Output: true
            Console.WriteLine(s.ReorderedPowerOf2(1));
            //Input: 10
            //Output: false
            Console.WriteLine(s.ReorderedPowerOf2(10));
            //Input: 16
            //Output: true
            Console.WriteLine(s.ReorderedPowerOf2(16));
            //Input: 24
            //Output: false
            Console.WriteLine(s.ReorderedPowerOf2(24));
            //Input: 46
            //Output: true
            Console.WriteLine(s.ReorderedPowerOf2(46));
        }
    }
}
