using System;

namespace Cherry_Pickup_II
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            //Input: grid = [[3, 1, 1],[2,5,1],[1,5,5],[2,1,1]]
            //Output: 24
            //Explanation: Path of robot #1 and #2 are described in color green and blue respectively.
            //Cherries taken by Robot #1, (3 + 2 + 5 + 2) = 12.
            //Cherries taken by Robot #2, (1 + 5 + 5 + 1) = 12.
            //Total of cherries: 12 + 12 = 24.
            Console.WriteLine(s.CherryPickup(new[] {
                new[] { 3, 1, 1 },
                new[] { 2, 5, 1 },
                new[] { 1, 5, 5 },
                new[] { 2, 1, 1 }
            }));
            //Input: grid = [[1, 0, 0, 0, 0, 0, 1],[2,0,0,0,0,3,0],[2,0,9,0,0,0,0],[0,3,0,5,4,0,0],[1,0,2,3,0,0,6]]
            //Output: 28
            //Explanation: Path of robot #1 and #2 are described in color green and blue respectively.
            //Cherries taken by Robot #1, (1 + 9 + 5 + 2) = 17.
            //Cherries taken by Robot #2, (1 + 3 + 4 + 3) = 11.
            //Total of cherries: 17 + 11 = 28.
            Console.WriteLine(s.CherryPickup(new[] {
                new[] { 1, 0, 0, 0, 0, 0, 1 },
                new[] { 2, 0, 0, 0, 0, 3, 0 },
                new[] { 2, 0, 9, 0, 0, 0, 0 },
                new[] { 0, 3, 0, 5, 4, 0, 0 },
                new[] { 1, 0, 2, 3, 0, 0, 6 }
            }));
            //Input: grid = [[1, 0, 0, 3],[0,0,0,3],[0,0,3,3],[9,0,3,3]]
            //Output: 22
            Console.WriteLine(s.CherryPickup(new[] {
                new[] { 1, 0, 0, 3 },
                new[] { 0, 0, 0, 3 },
                new[] { 0, 0, 3, 3 },
                new[] { 9, 0, 3, 3 }
            }));
            //Input: grid = [[1,1],[1,1]]
            //Output: 4
            Console.WriteLine(s.CherryPickup(new[] {
                new[] { 1, 1 },
                new[] { 1, 1 }
            }));
        }
    }
}
