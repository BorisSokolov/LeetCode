using System;

namespace Find_Smallest_Common_Element_in_All_Rows
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            //Input: mat = [[1, 2, 3, 4, 5],[2,4,5,8,10],[3,5,7,9,11],[1,3,5,7,9]]
            //Output: 5
            Console.WriteLine(s.SmallestCommonElement(new int[][] { new []{ 1, 2, 3, 4, 5 }, new []{ 2, 4, 5, 8, 10 }, new[] { 3, 5, 7, 9, 11 }, new[] { 1, 3, 5, 7, 9 } }));
        }
    }
}
