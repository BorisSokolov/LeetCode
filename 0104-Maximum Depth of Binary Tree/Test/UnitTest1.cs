using LeetCode104;
using System;
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

            Solution solution = new Solution();

            Assert.Equal(3, solution.MaxDepth(testData));
        }
    }
}
