using System;

namespace Diagonal_Traverse
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            //Input:
            //[
            // [1, 2, 3],
            // [ 4, 5, 6 ],
            // [ 7, 8, 9 ]
            //]

            //Output:  [1,2,4,7,5,3,6,8,9]

            var matrix = new int[][] {
                new[] { 1, 2, 3 },
                new[] { 4, 5, 6 },
                new[] { 7, 8, 9 }
            };
            Console.WriteLine(string.Join(", ", s.FindDiagonalOrder(matrix)));
        }
    }
}
