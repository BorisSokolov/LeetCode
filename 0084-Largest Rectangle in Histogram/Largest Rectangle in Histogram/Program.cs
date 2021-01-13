using System;

namespace Largest_Rectangle_in_Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            //Input: [2, 1, 5, 6, 2, 3]
            //Output: 10
            Console.WriteLine(s.LargestRectangleArea(new[] { 2, 1, 5, 6, 2, 3 }));
        }
    }
}
