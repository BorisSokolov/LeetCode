using System;

namespace Strobogrammatic_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            //Input: num = "69"
            //Output: true
            Console.WriteLine(s.IsStrobogrammatic("69"));
            //Input: num = "88"
            //Output: true
            Console.WriteLine(s.IsStrobogrammatic("88"));
            //Input: num = "962"
            //Output: false
            Console.WriteLine(s.IsStrobogrammatic("962"));
            //Input: num = "1"
            //Output: true
            Console.WriteLine(s.IsStrobogrammatic("1"));
        }
    }
}
