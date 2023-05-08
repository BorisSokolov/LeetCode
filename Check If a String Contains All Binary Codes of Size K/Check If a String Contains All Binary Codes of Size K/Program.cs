using System;

namespace Check_If_a_String_Contains_All_Binary_Codes_of_Size_K
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            //Input: s = "00110110", k = 2
            //Output: true
            //Explanation: The binary codes of length 2 are "00", "01", "10" and "11".They can be all found as substrings at indicies 0, 1, 3 and 2 respectively.
            Console.WriteLine(s.HasAllCodes("00110110", 2));
            //Input: s = "00110", k = 2
            //Output: true
            Console.WriteLine(s.HasAllCodes("00110", 2));
            //Input: s = "0110", k = 1
            //Output: true
            //Explanation: The binary codes of length 1 are "0" and "1", it is clear that both exist as a substring.
            Console.WriteLine(s.HasAllCodes("0110", 1));
            //Input: s = "0110", k = 2
            //Output: false
            //Explanation: The binary code "00" is of length 2 and doesn't exist in the array.
            Console.WriteLine(s.HasAllCodes("0110", 2));
            //Input: s = "0000000001011100", k = 4
            //Output: false
            Console.WriteLine(s.HasAllCodes("0000000001011100", 4));
        }
    }
}
