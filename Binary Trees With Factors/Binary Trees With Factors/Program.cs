using System;

namespace Binary_Trees_With_Factors
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            //Input: arr = [2, 4]
            //Output: 3
            //Explanation: We can make these trees: [2], [4], [4, 2, 2]
            Console.WriteLine(s.NumFactoredBinaryTrees(new[] { 2, 4 }));
            //Input: arr = [2,4,5,10]
            //Output: 7
            //Explanation: We can make these trees: [2], [4], [5], [10], [4, 2, 2], [10, 2, 5], [10, 5, 2].
            Console.WriteLine(s.NumFactoredBinaryTrees(new[] { 2, 4, 5, 10 }));
        }
    }
}
