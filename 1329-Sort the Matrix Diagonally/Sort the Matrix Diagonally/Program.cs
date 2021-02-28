using System;

namespace Sort_the_Matrix_Diagonally
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            //Input: mat = [[3, 3, 1, 1],[2,2,1,2],[1,1,1,2]]
            //Output: [[1,1,1,1],[1,2,2,2],[1,2,3,3]]
            var arr = new int[][]
                {
                    new int[]{ 3, 3, 1, 1 },
                    new int[]{ 2, 2, 1, 2 },
                    new int[]{ 1, 1, 1, 2 }
            };
            s.DiagonalSort(arr);
            foreach(var line in arr)
                Console.WriteLine(string.Join(", ", line));
        }
    }
}
