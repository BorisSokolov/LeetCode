using System;

namespace Sliding_Window_Maximum
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            //Input: nums = [1, 3, -1, -3, 5, 3, 6, 7], k = 3
            //Output: [3, 3, 5, 5, 6, 7]
            //Explanation:
            //Window position                Max
            // -------------- -             -----
            //[1  3 - 1] - 3  5  3  6  7     3
            // 1[3 - 1 - 3] 5  3  6  7       3
            // 1  3[-1 - 3  5] 3  6  7       5
            // 1  3 - 1[-3  5  3] 6  7       5
            // 1  3 - 1 - 3[5  3  6] 7       6
            // 1  3 - 1 - 3  5[3  6  7]      7
            Console.WriteLine($"{string.Join(", ", s.MaxSlidingWindow(new[] { 1, 3, -1, -3, 5, 3, 6, 7 }, 3))}");
            //Input: nums = [1], k = 1
            //Output: [1]
            Console.WriteLine($"{string.Join(", ", s.MaxSlidingWindow(new[] { 1 }, 1))}");
        }
    }
}
