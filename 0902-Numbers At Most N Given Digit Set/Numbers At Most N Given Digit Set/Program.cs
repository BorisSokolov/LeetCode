using System;

namespace Numbers_At_Most_N_Given_Digit_Set
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            //Input: digits = ["1", "3", "5", "7"], n = 100
            //Output: 20
            //Explanation: The 20 numbers that can be written are: 1, 3, 5, 7, 11, 13, 15, 17, 31, 33, 35, 37, 51, 53, 55, 57, 71, 73, 75, 77.
            var digits = new string[] { "1", "3", "5", "7" };
            Console.WriteLine(s.AtMostNGivenDigitSet(digits, 100));
            //Input: digits = ["1", "4", "9"], n = 1000000000
            //Output: 29523
            //Explanation:
            //            We can write 3 one digit numbers, 9 two digit numbers, 27 three digit numbers,
            //81 four digit numbers, 243 five digit numbers, 729 six digit numbers,
            //2187 seven digit numbers, 6561 eight digit numbers, and 19683 nine digit numbers.
            //In total, this is 29523 integers that can be written using the digits array.
            var digits2 = new string[] { "1", "4", "9" };
            Console.WriteLine(s.AtMostNGivenDigitSet(digits2, 1000000000));
            //Input: digits = ["7"], n = 8
            //Output: 1
            var digits3 = new string[] { "7" };
            Console.WriteLine(s.AtMostNGivenDigitSet(digits3, 8));
        }
    }
}
