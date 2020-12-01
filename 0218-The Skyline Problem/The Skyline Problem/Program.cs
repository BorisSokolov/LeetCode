using System;

namespace The_Skyline_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            var input = new int[][] { new[] { 2, 9, 10 }, new[] { 3, 7, 15 }, new[] { 5, 12, 12 }, new[] { 15, 20, 10 }, new[] { 19, 24, 8 } }; 
            Console.WriteLine($"{string.Join(", ", s.GetSkyline(input))}");
        }
    }
}
