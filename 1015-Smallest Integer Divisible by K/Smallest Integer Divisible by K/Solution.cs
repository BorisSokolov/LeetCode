namespace Smallest_Integer_Divisible_by_K
{
    /// <summary>
    /// Given a positive integer K, you need to find the length of the smallest positive integer N such that N is divisible by K, and N only contains the digit 1.
    /// Return the length of N.If there is no such N, return -1.
    /// Note: N may not fit in a 64-bit signed integer.
    /// </summary>
    public class Solution
    {
        public int SmallestRepunitDivByK(int k)
        {
            int remainder = 0;
            for (int i = 1; i <= k; i++)
            {
                remainder = (remainder * 10 + 1) % k;
                if (remainder == 0)
                    return i;
            }
            return -1;
        }
    }
}
