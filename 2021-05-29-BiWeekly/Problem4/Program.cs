using System;

namespace Problem4
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            Console.WriteLine(s.MinimumXORSum(new[] { 1, 2 }, new[] { 2, 3 }));
            Console.WriteLine(s.MinimumXORSum(new[] { 1, 0, 3 }, new[] { 5, 3, 4 }));
            Console.WriteLine(s.MinimumXORSum(new[] { 3, 2, 3, 83, 69, 1, 48, 87 }, new[] { 27, 54, 92, 3, 67, 28, 97, 56 }));
        }
    }
}
