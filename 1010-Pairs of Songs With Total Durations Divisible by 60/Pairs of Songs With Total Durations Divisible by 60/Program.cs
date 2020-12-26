using System;

namespace Pairs_of_Songs_With_Total_Durations_Divisible_by_60
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            //Input: time = [30, 20, 150, 100, 40]
            //Output: 3
            //Explanation: Three pairs have a total duration divisible by 60:
            //(time[0] = 30, time[2] = 150): total duration 180
            //(time[1] = 20, time[3] = 100): total duration 120
            //(time[1] = 20, time[4] = 40): total duration 60
            Console.WriteLine(s.NumPairsDivisibleBy60(new [] { 30, 20, 150, 100, 40 }));
            //Input: time = [60, 60, 60]
            //Output: 3
            //Explanation: All three pairs have a total duration of 120, which is divisible by 60.
            Console.WriteLine(s.NumPairsDivisibleBy60(new[] { 60, 60, 60 }));
        }
    }
}
