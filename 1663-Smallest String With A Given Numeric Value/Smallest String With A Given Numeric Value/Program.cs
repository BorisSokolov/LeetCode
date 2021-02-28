using System;

namespace Smallest_String_With_A_Given_Numeric_Value
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            //Input: n = 3, k = 27
            //Output: "aay"
            //Explanation: The numeric value of the string is 1 + 1 + 25 = 27, and it is the smallest string with such a value and length equal to 3.
            Console.WriteLine(s.GetSmallestString(3, 27));
            //Input: n = 5, k = 73
            //Output: "aaszz"
            Console.WriteLine(s.GetSmallestString(5, 73));
        }
    }
}
