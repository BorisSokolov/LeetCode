using System;

namespace Missing_Ranges
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            //Input: nums = [0, 1, 3, 50, 75], lower = 0, upper = 99
            //Output: ["2", "4->49", "51->74", "76->99"]
            //Explanation: The ranges are:
            //[2, 2]-- > "2"
            //[4, 49]-- > "4->49"
            //[51, 74]-- > "51->74"
            //[76, 99]-- > "76->99"
            Console.WriteLine(string.Join(", ", s.FindMissingRanges(new[] { 0, 1, 3, 50, 75 }, 0, 99)));
            //Input: nums = [], lower = 1, upper = 1
            //Output: ["1"]
            //Explanation: The only missing range is [1, 1], which becomes "1".
            Console.WriteLine(string.Join(", ", s.FindMissingRanges(null, 1, 1)));
            //Input: nums = [], lower = -3, upper = -1
            //Output: ["-3->-1"]
            //Explanation: The only missing range is [-3, -1], which becomes "-3->-1".
            Console.WriteLine(string.Join(", ", s.FindMissingRanges(null, -3, -1)));
        }
    }
}
