using System;

namespace Arithmetic_Slices
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            //A = [1, 2, 3, 4]
            //return: 3, for 3 arithmetic slices in A: [1, 2, 3], [2, 3, 4] and[1, 2, 3, 4] itself.
            Console.WriteLine(s.NumberOfArithmeticSlices(new[] { 1, 2, 3, 4 }));
        }
    }
}
