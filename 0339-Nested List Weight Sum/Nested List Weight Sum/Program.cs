using LeetCode.Domain;
using System;
using System.Collections.Generic;

namespace Nested_List_Weight_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            //Input: nestedList = [0]
            //Output: 0
            Console.WriteLine(s.DepthSum(new List<NestedInteger> { new NestedInteger(0)}));
        }
    }
}
