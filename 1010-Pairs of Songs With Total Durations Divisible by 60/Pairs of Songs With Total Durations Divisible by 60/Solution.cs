using System;
using System.Collections.Generic;
using System.Text;

namespace Pairs_of_Songs_With_Total_Durations_Divisible_by_60
{
    /// <summary>
    /// You are given a list of songs where the ith song has a duration of time[i] seconds.
    /// Return the number of pairs of songs for which their total duration in seconds is divisible by 60. Formally, we want the number of indices i, j such that i<j with (time[i] + time[j]) % 60 == 0.
    /// </summary>
    public class Solution
    {
        public int NumPairsDivisibleBy60(int[] time)
        {
            var remainders = new int[60];
            int count = 0;
            foreach (int t in time)
            {
                if (t % 60 == 0)
                { // check if a%60==0 && b%60==0
                    count += remainders[0];
                }
                else
                { // check if a%60+b%60==60
                    count += remainders[60 - t % 60];
                }
                remainders[t % 60]++; // remember to update the remainders
            }
            return count;
        }
    }
}
