using System.Linq;

namespace Reordered_Power_of_2
{
    public class Solution
    {
        public bool ReorderedPowerOf2(int N)
        {
            int[] digitCount = CountDigits(N);

            for (int i = 0; i < 31; i++)
            {
                // 2^N = 1 << N
                if (Enumerable.SequenceEqual(digitCount, CountDigits(1 << i)))
                    return true;
            }
            return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="n"></param>
        /// <returns>a[i] - the count of i-digit in the <paramref name="n"/></returns>
        private int[] CountDigits(int n)
        {
            int[] count = new int[10];
            while (n > 0)
            {
                count[n % 10]++;
                n /= 10;
            }

            return count;
        }
    }
}
