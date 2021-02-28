using System;

namespace Determine_if_Two_Strings_Are_Close
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            //Input: word1 = "abc", word2 = "bca"
            //Output: true
            //Explanation: You can attain word2 from word1 in 2 operations.
            //Apply Operation 1: "abc"-> "acb"
            //Apply Operation 1: "acb"-> "bca"
            Console.WriteLine(s.CloseStrings("abc", "bca"));
            //Input: word1 = "a", word2 = "aa"
            //Output: false
            //Explanation: It is impossible to attain word2 from word1, or vice versa, in any number of operations.
            Console.WriteLine(s.CloseStrings("a", "aa"));
            //Input: word1 = "cabbba", word2 = "abbccc"
            //Output: true
            //Explanation: You can attain word2 from word1 in 3 operations.
            //Apply Operation 1: "cabbba"-> "caabbb"
            //Apply Operation 2: "caabbb"-> "baaccc"
            //Apply Operation 2: "baaccc"-> "abbccc"
            Console.WriteLine(s.CloseStrings("cabbba", "abbccc"));
            //Input: word1 = "cabbba", word2 = "aabbss"
            //Output: false
            //Explanation: It is impossible to attain word2 from word1, or vice versa, in any amount of operations.
            Console.WriteLine(s.CloseStrings("cabbba", "aabbss"));
        }
    }
}
