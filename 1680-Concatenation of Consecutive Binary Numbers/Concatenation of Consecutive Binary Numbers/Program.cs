using System;

namespace Concatenation_of_Consecutive_Binary_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            //Input: n = 1
            //Output: 1
            //Explanation: "1" in binary corresponds to the decimal value 1.
            Console.WriteLine(s.ConcatenatedBinary(1));
            //Input: n = 3
            //Output: 27
            //Explanation: In binary, 1, 2, and 3 corresponds to "1", "10", and "11".
            //After concatenating them, we have "11011", which corresponds to the decimal value 27.
            Console.WriteLine(s.ConcatenatedBinary(3));
            //Input: n = 12
            //Output: 505379714
            //Explanation: The concatenation results in "1101110010111011110001001101010111100".
            //The decimal value of that is 118505380540.
            //After modulo 109 + 7, the result is 505379714.
            Console.WriteLine(s.ConcatenatedBinary(12));
        }
    }
}
