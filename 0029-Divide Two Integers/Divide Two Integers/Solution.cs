namespace Divide_Two_Integers
{
    /// <summary>
    /// Given two integers dividend and divisor, divide two integers without using multiplication, division, and mod operator.
    /// Return the quotient after dividing dividend by divisor.
    /// The integer division should truncate toward zero, which means losing its fractional part. For example, truncate(8.345) = 8 and truncate(-2.7335) = -2.
    /// </summary>
    public class Solution
    {
        public int Divide(int dividend, int divisor)
        {
            // Special cases
            if (dividend == int.MinValue && divisor == -1)
                return int.MaxValue;
            if (divisor == 1 || dividend == 0)
                return dividend;
            if (dividend == divisor)
                return 1;
            if (divisor == -1)
                return -dividend;

            // if result should be a positive number
            bool positive = true;

            // converting to the positive numbers
            if (dividend < 0)
            {
                positive = false;
                dividend = -dividend;
            }
            if (divisor < 0)
            {
                positive = !positive;
                divisor = -divisor;
            }

            int count = 0;

            while (dividend - divisor >= 0)
            {
                count++;
                dividend -= divisor;
            }

            return positive ? count : -count;
        }
    }
}
