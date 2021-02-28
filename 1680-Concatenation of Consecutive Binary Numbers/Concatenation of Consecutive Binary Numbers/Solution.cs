namespace Concatenation_of_Consecutive_Binary_Numbers
{
    /// <summary>
    /// Given an integer n, return the decimal value of the binary string formed by concatenating the binary representations of 1 to n in order, modulo 109 + 7.
    /// </summary>
    public class Solution
    {
        public int ConcatenatedBinary(int n)
        {
            int MOD = 1000000007;
            int length = 0; // bit length of addends
            long result = 0; // long accumulator
            for (int i = 1; i <= n; i++)
            {
                // when meets power of 2, increase the bit length
                if ((i & (i - 1)) == 0)
                {
                    length++;
                }
                result = ((result << length) | i) % MOD;
            }
            return (int)result;
        }
    }
}
