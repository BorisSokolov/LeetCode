using System;

namespace Basic_Calculator_II
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            //Input: "3+2*2"
            //Output: 7
            Console.WriteLine(s.Calculate("3+2*2"));
            //Input: " 3+5 / 2 "
            //Output: 5
            Console.WriteLine(s.Calculate(" 3+5 / 2 "));
        }
    }
}
