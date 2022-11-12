using LeetCode.Matrix.Medium.MinimumPathSum;
using Xunit;

namespace LeetCodeTests.Matrix.Medium.MinimumPathSum
{
    public class SolutionTests
    {
        [Fact]
        public void MinPathSum_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var solution = new Solution();
            int[][] grid = new int[3][];
            grid[0] = new int[] { 1, 3, 1 };
            grid[1] = new int[] { 1, 5, 1 };
            grid[2] = new int[] { 4, 2, 1 };

            // Act
            var result = solution.MinPathSum(grid);

            // Assert
            Assert.True(result == 7);
        }
    }
}
