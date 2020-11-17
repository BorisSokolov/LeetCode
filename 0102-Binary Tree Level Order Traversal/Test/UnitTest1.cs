using LeetCode102;
using System;
using System.Collections.Generic;
using Xunit;

namespace Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            TreeNode testData = new TreeNode(3)
            {
                left = new TreeNode(9),
                right = new TreeNode(20)
                {
                    left = new TreeNode(15),
                    right = new TreeNode(7)
                }
            };

            List<List<int>> check = new List<List<int>>()
            {
                new List<int>{3},
                new List<int>{9, 20},
                new List<int>{15, 7}
            };

            Solution solution = new Solution();

            Assert.Equal(check, solution.LevelOrder(testData));
        }
    }
}
