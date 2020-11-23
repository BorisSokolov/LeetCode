using System;
using System.Collections.Generic;
using System.Text;

namespace Numbers_At_Most_N_Given_Digit_Set
{
    /// <summary>
    /// Given an array of digits, you can write numbers using each digits[i] as many times as we want.  For example, if digits = ['1','3','5'], we may write numbers such as '13', '551', and '1351315'.
    /// Return the number of positive integers that can be generated that are less than or equal to a given integer n.
    /// </summary>
    public class Solution
    {
        public int AtMostNGivenDigitSet(string[] digits, int n)
        {
            string s = n.ToString();
            int k = s.Length;
            int[] dp = new int[k + 1];
            dp[k] = 1;

            for (int i = k - 1; i >= 0; --i)
            {
                //  compute dp[i]
                int si = s[i] - '0';
                foreach (string d in digits)
                {
                    if (int.Parse(d) < si)
                        dp[i] += IntPow(digits.Length, k - i - 1);
                    else if (int.Parse(d) == si)
                        dp[i] += dp[i + 1];
                }

            }

            for (int i = 1; i < k; i++)
                dp[0] += IntPow(digits.Length, i);

            return dp[0];
        }

        int IntPow(int x, int pow)
        {
            int ret = 1;
            while (pow != 0)
            {
                if ((pow & 1) == 1)
                    ret *= x;
                x *= x;
                pow >>= 1;
            }
            return ret;
        }
    }
}
