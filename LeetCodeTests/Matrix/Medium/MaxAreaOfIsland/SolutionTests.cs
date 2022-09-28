using LeetCode.Matrix.Medium.MaxAreaOfIsland;
using Xunit;

namespace LeetCodeTests.Matrix.Medium.MaxAreaOfIsland
{
    public class SolutionTests
    {
        [Fact]
        public void MaxAreaOfIsland_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var solution = new Solution();
            int[][] grid = new int[3][];
            grid[0] = new int[] { 0, 0, 1 };
            grid[1] = new int[] { 0, 1, 0 };
            grid[2] = new int[] { 0, 1, 1 };

            // Act
            var result = solution.MaxAreaOfIsland(grid);

            // Assert
            Assert.True(result == 3);
        }
    }
}
