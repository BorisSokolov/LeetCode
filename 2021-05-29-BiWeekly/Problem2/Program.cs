using System;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            Console.WriteLine(s.MinPairSum(new[] { 3, 5, 2, 3 }));
            Console.WriteLine(s.MinPairSum(new[] { 3, 5, 4, 2, 4, 6 }));
        }
    }
}
