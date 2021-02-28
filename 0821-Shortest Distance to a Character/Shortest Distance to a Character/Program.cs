using System;

namespace Shortest_Distance_to_a_Character
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            //Input: s = "loveleetcode", c = "e"
            //Output: [3, 2, 1, 0, 1, 0, 0, 1, 2, 2, 1, 0]
            Console.WriteLine(string.Join(',', s.ShortestToChar("loveleetcode", 'e')));
            //Input: s = "aaab", c = "b"
            //Output: [3, 2, 1, 0]
            Console.WriteLine(string.Join(',', s.ShortestToChar("aaab", 'b')));
        }
    }
}
