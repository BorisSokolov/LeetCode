using System;

namespace _2021_02_20_BiWeekly
{
    class Program
    {
        static void Main(string[] args)
        {
            //Solution s = new Solution();

            //Console.WriteLine(s.LongestNiceSubstring("YazaAay"));
            //Console.WriteLine(s.LongestNiceSubstring("Bb"));
            //Console.WriteLine(s.LongestNiceSubstring("c"));
            //Console.WriteLine(s.LongestNiceSubstring("dDzeE"));
            //Console.WriteLine(s.LongestNiceSubstring("HkhBubUYy"));

            //Solution2 s2 = new Solution2();
            //var groups = new int[][] { new[] { 1, -1, -1 }, new[] { 3, -2, 0 } };
            //var nums = new[] { 1, -1, 0, 1, -1, -1, 3, -2, 0 };
            //Console.WriteLine(s2.CanChoose(groups, nums));
            //var groups2 = new int[][] { new[] { 10, -2 }, new[] { 1, 2, 3, 4 } };
            //var nums2 = new[] { 1, 2, 3, 4, 10, -2 };
            //Console.WriteLine(s2.CanChoose(groups2, nums2));
            //var groups3 = new int[][] { new[] { 1, 2, 3 }, new[] { 3, 4 } };
            //var nums3 = new[] { 7, 7, 1, 2, 3, 4, 7, 7 };
            //Console.WriteLine(s2.CanChoose(groups3, nums3));

            Solution3 s3 = new Solution3();
            var isWater = new int[][] { new[] { 0, 1 }, new[] { 0, 0 } };
            var result = s3.HighestPeak(isWater);
            foreach (var line in result)
                Console.WriteLine(string.Join(',', line));

            var isWater2 = new int[][] { new[] { 0, 0 }, new[] { 1, 1 }, new[] { 1, 0 } };
            var result2 = s3.HighestPeak(isWater2);
            foreach (var line in result2)
                Console.WriteLine(string.Join(',', line));

        }
    }
}
