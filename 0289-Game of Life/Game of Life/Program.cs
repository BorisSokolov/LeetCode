using System;

namespace Game_of_Life
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            //Input: board = [[0, 1, 0],[0,0,1],[1,1,1],[0,0,0]]
            //Output: [[0,0,0],[1,0,1],[0,1,1],[0,1,0]]
            var arr = new int[][]{
                new int[] { 0, 1, 0 },
                new int[] { 1, 1, 1 },
                new int[] { 0, 0, 0 }
            };
            s.GameOfLife(arr);

            foreach (var row in arr)
                Console.WriteLine(string.Join(", ", row));
        }
    }
}
