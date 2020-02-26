using Xunit;

namespace LeetCode200
{
    public class Test
    {
        [Fact]
        public void Example1()
        {
            char[][] array = new char[][]{
                "11110".ToCharArray(),
                "11000".ToCharArray(),
                "11000".ToCharArray(),
                "00000".ToCharArray()
            };

            Solution solution = new Solution();

            Assert.Equal(1, solution.NumIslands(array));
        }

        [Fact]
        public void Example2()
        {
            char[][] array = new char[][]{
                "11000".ToCharArray(),
                "11000".ToCharArray(),
                "00100".ToCharArray(),
                "00011".ToCharArray()
            };

            Solution solution = new Solution();

            Assert.Equal(3, solution.NumIslands(array));
        }
    }
}
