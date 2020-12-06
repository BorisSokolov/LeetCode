using System;

namespace Shortest_Word_Distance
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            var words = new[] { "practice", "makes", "perfect", "coding", "makes" };
            //3
            Console.WriteLine(s.ShortestDistance(words, "coding", "practice"));
            //1
            Console.WriteLine(s.ShortestDistance(words, "makes", "coding"));
        }
    }
}
