using LeetCode0007;
using System;
using Xunit;

namespace Test
{
    public class UnitTest1
    {
        [Fact]
        public void TestSimple1()
        {
            Solution solution = new Solution();
            Assert.Equal(123, solution.Reverse(321));
        }

        [Fact]
        public void TestSimple2()
        {
            Solution solution = new Solution();
            Assert.Equal(321, solution.Reverse(123));
        }

        [Fact]
        public void TestNegative()
        {
            Solution solution = new Solution();
            Assert.Equal(-123, solution.Reverse(-321));
        }

        [Fact]
        public void TestWithZeroes()
        {
            Solution solution = new Solution();
            Assert.Equal(126, solution.Reverse(62100));
        }

        [Fact]
        public void TestOverflow()
        {
            Solution solution = new Solution();
            Assert.Equal(0, solution.Reverse(1111111999));
        }
    }
}
