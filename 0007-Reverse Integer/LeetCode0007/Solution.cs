using System;

namespace LeetCode0007
{
    public class Solution
    {
        public int Reverse(int x)
        {
            int reversed = 0;
            while (x != 0)
            {
                int digit = x % 10;
                //x -= digit;
                x /= 10;

                //The int type represents signed 32-bit integers with values between –2,147,483,648 and 2,147,483,647.
                if (reversed > int.MaxValue / 10 ||
                   reversed < int.MinValue / 10 ||
                   (reversed == int.MaxValue && digit > 8) ||
                   (reversed == int.MinValue && digit < -7))
                    return 0;

                reversed = reversed * 10 + digit;

            }
            return reversed;

        }
    }
}
